using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using VisualNovel;

namespace VNDialogueEditor {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void ButtonLegacyToV1_Click(object sender, EventArgs e) {
            while (true) {
                OpenFileDialog openFileDialog = new OpenFileDialog {
                    Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                    FilterIndex = 1
                };

                switch (openFileDialog.ShowDialog()) {
                    case DialogResult.OK:
                        XElement XMLFile = XElement.Load(openFileDialog.FileName);
                        List<Chapter> ChapterList;
                        if (XMLFile.Attribute("EditorVersion") == null) {
                            ChapterList = LoadDialogueLegacy(XMLFile);
                            SaveConvertedXML(ChapterList, openFileDialog.SafeFileName);
                            return;
                        }
                        MessageBox.Show("This file is already converted");
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }
        }

        private List<Chapter> LoadDialogueLegacy(XElement file) {
            // This serves for compatibility with older XML files generated before v1
            List<Chapter> LoadedChapters = new List<Chapter>();
            List<XElement> Chapters = file.Elements("Chapter").ToList();

            foreach (XElement chapter in Chapters) {
                int ChapterNumber = int.Parse(chapter.Attribute("number").Value);
                string ChapterBackground = (chapter.Attribute("background") != null) ? chapter.Attribute("background").Value : "";
                Chapter Chapter = new Chapter(ChapterNumber, ChapterBackground);
                List<XElement> DialogueList = chapter.Elements("Dialogue").ToList();

                foreach (XElement dialogue in DialogueList) {
                    int DialogueNumber = int.Parse(dialogue.Attribute("number").Value);
                    string DialogueText = dialogue.Element("text").Value;
                    string DialogueBackground = (dialogue.Attribute("background") != null) ? dialogue.Attribute("background").Value : "";

                    Redirect DialogueRedirect = null;
                    if (dialogue.Element("redirect") != null) {
                        DialogueRedirect = new Redirect(int.Parse(dialogue.Element("redirect").Attribute("chapter").Value),
                                                int.Parse(dialogue.Element("redirect").Attribute("dialogue").Value));
                    }
                    if (dialogue.Element("options") == null && dialogue.Element("redirect") == null) { //Redirects are now always needed, as such we will workaround the previous behaviour here
                        int RedirectDialogue = DialogueNumber;
                        int RedirectChapter = ChapterNumber;
                        if (DialogueNumber >= DialogueList.Count()) {
                            RedirectDialogue = 1;
                            RedirectChapter++;
                            if (RedirectChapter > Chapters.Count()) {
                                RedirectDialogue = -1;
                                RedirectChapter = -1;
                            }
                        }
                        else {
                            RedirectDialogue++;
                        }
                        DialogueRedirect = new Redirect(RedirectChapter, RedirectDialogue);
                    }

                    List<Option> DialogueOptions = null;
                    if (dialogue.Element("options") != null) {
                        DialogueOptions = new List<Option>();
                        foreach (XElement option in dialogue.Element("options").Elements("option").ToList()) {

                            Redirect optionRedir = new Redirect(int.Parse(option.Element("redirect").Attribute("chapter").Value),
                                                int.Parse(option.Element("redirect").Attribute("dialogue").Value));
                            DialogueOptions.Add(new Option(option.Element("option_text").Value, optionRedir, null, null));
                        }
                    }
                    List<Character> DialogueCharacters = new List<Character>();
                    if (dialogue.Element("characters") != null) {
                        foreach (XElement character in dialogue.Element("characters").Elements("character").ToList()) {
                            // Defaults: Name = "" ; Picture = "" ; Side = 0 (Left); Selected = true; Hidden = false
                            string CharacterName = (character.Attribute("name") != null) ? character.Attribute("name").Value : "";
                            string CharacterPicture = (character.Attribute("picture") != null) ? character.Attribute("picture").Value : "";
                            int CharacterSide = (character.Attribute("side") != null) ? int.Parse(character.Attribute("side").Value) : 0;
                            bool CharacterSelected = (character.Attribute("selected") != null) ? bool.Parse(character.Attribute("selected").Value) : true;
                            bool CharacterHidden = (character.Attribute("hidden") != null) ? bool.Parse(character.Attribute("hidden").Value) : false;
                            DialogueCharacters.Add(new Character(CharacterName, CharacterPicture, CharacterSide, CharacterSelected, CharacterHidden));
                        }
                    }

                    Dialogue Dialogue = new Dialogue(DialogueNumber, DialogueBackground, DialogueText, DialogueRedirect, null, null, DialogueOptions, DialogueCharacters);

                    Chapter.Dialogues.Add(Dialogue);
                }

                LoadedChapters.Add(Chapter);
            }
            return LoadedChapters;
        }

        private void SaveConvertedXML(List<Chapter> chapterList, string previousName) {
            XElement newDocument = new XElement("Document", new XAttribute("EditorVersion", "1"));
            foreach (Chapter chapter in chapterList) {
                newDocument.Add(chapter.ExportXML());
            }
            string[] previousNameArray = previousName.Split('.');
            previousNameArray = previousNameArray.Take(previousNameArray.Count() - 1).ToArray();
            string previousNameNoExtension = string.Join(null, previousNameArray);
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                FileName = previousNameNoExtension + "_Converted",
                Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };

            while (true) {
                switch (saveFileDialog.ShowDialog()) {
                    case DialogResult.OK:
                        if ((fileStream = saveFileDialog.OpenFile()) != null) {
                            StreamWriter streamWriter = new StreamWriter(fileStream);
                            streamWriter.Write(newDocument.ToString());
                            streamWriter.Flush();
                            fileStream.Position = 0;
                            fileStream.Close();
                            return;
                        }
                        MessageBox.Show("Can't write the file.", "Error writing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
        }

        private void ButtonNewStart_Click(object sender, EventArgs e) {
            Hide();
            new Editor().Show();
        }
    }
}
