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

            // chapterListBox setup
            bs.DataSource = Chapters;
            chapterListBox.DisplayMember = "Number";
            chapterListBox.DataSource = bs;
            chapterListBox.FormatString = "Chapter 0";
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
                bs.ResetBindings(false);
                chapterListBox.SelectedIndex = newChapterDialog.NewChapterIndex;
            }
        }
    }
}
