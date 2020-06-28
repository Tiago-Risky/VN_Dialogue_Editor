using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VNDialogueEditor.DialogForms;
using VisualNovel;
using System.Xml.Linq;

namespace VNDialogueEditor {
    public partial class Editor : Form {

        public static Dictionary<int, Chapter> Chapters { get; set; }
        public static int LastChapterID { get; set; } = 0;

        public Editor() {
            InitializeComponent();
            Chapters = new Dictionary<int, Chapter>();
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
        }
    }
}
