using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using VisualNovel;

namespace VNDialogueEditor {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private XElement XmlFile;
        public List<Chapter> ChapterList;

        public readonly int CurrentEditorVersion = 1;

        private void LoadXML() {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                XmlFile = XElement.Load(openFileDialog.FileName);
                PopulateTree(treeView1, XmlFile);
                if (XmlFile.Attribute("EditorVersion") != null) {
                    ChapterList = LoadDialogue(XmlFile);
                }
                else {
                    ChapterList = LoadDialogueLegacy(XmlFile);
                }
            }
        }

        private void ExportXML(string exportString) {
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if ((fileStream = saveFileDialog.OpenFile()) != null) {
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.Write(exportString);
                    streamWriter.Flush();
                    fileStream.Position = 0;
                    fileStream.Close();
                }
                else {
                    MessageBox.Show("Can't write the file.", "Error writing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public List<Chapter> LoadDialogueLegacy(XElement file) {
            List<Chapter> LoadedChapters = new List<Chapter>();
            List<XElement> Chapters = file.Elements("Chapter").ToList();

            foreach (XElement chapter in Chapters) {
                //Deprecated for now
                int ChapterNumber = int.Parse(chapter.Attribute("number").Value);
                string ChapterBackground = (chapter.Attribute("background") != null) ? chapter.Attribute("background").Value : "";
                Chapter Chapter = new Chapter(ChapterNumber, ChapterBackground);

                foreach (XElement dialogue in chapter.Elements("Dialogue").ToList()) {
                    int DialogueNumber = int.Parse(dialogue.Attribute("number").Value);
                    string DialogueText = dialogue.Element("text").Value;
                    string DialogueBackground = (dialogue.Attribute("background") != null) ? dialogue.Attribute("background").Value : "";

                    Redirect DialogueRedirect = null;
                    if (dialogue.Element("redirect") != null) {
                        DialogueRedirect = new Redirect(int.Parse(dialogue.Element("redirect").Attribute("chapter").Value),
                                                int.Parse(dialogue.Element("redirect").Attribute("dialogue").Value));
                    }

                    List<Option> DialogueOptions = null;
                    if (dialogue.Element("options") != null) {
                        DialogueOptions = new List<Option>();
                        foreach (XElement option in dialogue.Element("options").Elements("option").ToList()) {

                            Redirect optionRedir = new Redirect(int.Parse(option.Element("redirect").Attribute("chapter").Value),
                                                int.Parse(option.Element("redirect").Attribute("dialogue").Value));
                            DialogueOptions.Add(new Option(option.Element("option_text").Value, optionRedir));
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

                    Dialogue Dialogue = new Dialogue(DialogueNumber, DialogueText, DialogueBackground, DialogueRedirect, DialogueCharacters, DialogueOptions);

                    Chapter.Dialogues.Add(Dialogue);
                }

                LoadedChapters.Add(Chapter);
            }
            return LoadedChapters;
        }

        public List<Chapter> LoadDialogue(XElement file) {
            List<Chapter> LoadedChapters = new List<Chapter>();
            List<XElement> Chapters = file.Elements("Chapter").ToList();

            foreach (XElement chapter in Chapters) {
                LoadedChapters.Add(new Chapter(chapter));
            }
            return LoadedChapters;
        }

        private XElement Build() {
            XElement newDocument = new XElement("Document", new XAttribute("EditorVersion", CurrentEditorVersion));
            foreach (Chapter chapter in ChapterList) {
                newDocument.Add(chapter.ExportXML());
            }

            return newDocument;
        }

        public void PopulateTree(TreeView treeview, XElement xmlDocument) {
            treeview.Nodes.Clear();
            treeview.Enabled = false;
            TreeNode Document = new TreeNode("Document");
            Document.Tag = xmlDocument;
            treeview.Nodes.Add(Document);
            if (xmlDocument.Attribute("EditorVersion") != null) {
                AddNodes(Document, xmlDocument);
            }
            else {
                AddNodesLegacy(Document, xmlDocument);
            }
            treeview.ExpandAll();
            treeview.Nodes[0].EnsureVisible();
            treeview.Enabled = true;
        }

        private void AddNodesLegacy(TreeNode treeNode, XElement parent) {
            foreach (XElement child in parent.Elements()) {
                string label;
                switch (child.Name.ToString()) {
                    case "Chapter":
                    case "Dialogue":
                        label = "<" + child.Name.ToString() + "> " + child.Attribute("number").Value;
                        break;
                    case "text":
                        label = "<Text> " + child.Value;
                        break;
                    case "option":
                        label = "<Option> " + child.Value;
                        break;
                    case "character":
                        label = "<Character> " + child.Attribute("name").Value;
                        break;
                    case "redirect":
                        label = "<Redirect> Ch" + child.Attribute("chapter").Value + " D" + child.Attribute("dialogue").Value;
                        break;
                    default:
                        label = "<" + child.Name.ToString() + ">";
                        break;
                }
                TreeNode childNode = treeNode.Nodes.Add(label);
                childNode.Tag = child;
                AddNodesLegacy(childNode, child);
            }
        }

        private void AddNodes(TreeNode treeNode, XElement parent) {
            foreach (XElement child in parent.Elements()) {
                string label = "<" + child.Name.ToString() + ">";
                switch (child.Name.ToString()) {
                    case "Chapter":
                    case "Dialogue":
                        label += " " + child.Attribute("Number").Value;
                        break;
                    case "Text":
                    case "Option":
                        label += " " + child.Value;
                        break;
                    case "Character":
                        label += " " + child.Attribute("Name").Value;
                        break;
                    case "Redirect":
                        label += " Ch" + child.Attribute("Chapter").Value + " D" + child.Attribute("Dialogue").Value;
                        break;
                    default:
                        break;
                }
                TreeNode childNode = treeNode.Nodes.Add(label);
                childNode.Tag = child;
                AddNodes(childNode, child);
            }
        }

        private void RebuildNodes(TreeNode treeNode) {
            while (treeNode.Parent != null && treeNode.Parent.Tag != null) {
                XElement parentElement = (XElement)treeNode.Parent.Tag;
                parentElement.RemoveNodes();
                foreach (TreeNode node in treeNode.Parent.Nodes) {
                    parentElement.Add((XElement)node.Tag);
                }
                treeNode = treeNode.Parent;
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            textBox1.Text = treeView1.SelectedNode.Tag.ToString();
            textBox2.Text = treeView1.SelectedNode.Tag.ToString();
        }

        private void OpenXMLFile_Click(object sender, EventArgs e) {
            LoadXML();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            treeView1.SelectedNode.Tag = XElement.Parse(textBox2.Text);
            RebuildNodes(treeView1.SelectedNode);
        }

        private void ExportXMLFile_Click(object sender, EventArgs e) {
            ExportXML(treeView1.Nodes[0].Tag.ToString());
        }

        private void buildAndExport_Click(object sender, EventArgs e) {
            XElement export = Build();
            ExportXML(export.ToString());
        }
    }
}
