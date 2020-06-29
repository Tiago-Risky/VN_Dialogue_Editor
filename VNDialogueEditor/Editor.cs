using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using VisualNovel;
using VNDialogueEditor.DialogForms;

namespace VNDialogueEditor {
    public partial class Editor : Form {

        public static List<Chapter> Chapters { get; set; }
        public static int HighestChapterNumber { get; set; } = 0;

        private BindingSource bs = new BindingSource();

        public Editor() {
            InitializeComponent();
            Chapters = new List<Chapter>();
            bs.DataSource = Chapters;
        }

        public Editor(XElement file) {
            InitializeComponent();
            //TODO Starting from an existing file
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            Application.OpenForms["MainMenu"].Show();
        }

        private void btnNewChapter_Click(object sender, EventArgs e) {
            NewChapterDialog newChapterDialog = new NewChapterDialog();
            newChapterDialog.ShowDialog();
            if (newChapterDialog.DialogResult == DialogResult.OK) {
                //chapterList.Items.Clear();
                /*foreach (Chapter chapter in Chapters) {
                    chapterList.Items.Add("Chapter " + chapter.Number);
                }*/
                bs.ResetBindings(false);
                chapterList.DisplayMember = "Number";
                chapterList.DataSource = bs;
                chapterList.FormatString = "Chapter 0";
                //Not very clean, will need to fix to place cursor on the latest
            }
        }
    }
}
