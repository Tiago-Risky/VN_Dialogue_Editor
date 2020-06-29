using System;
using System.Windows.Forms;
using VisualNovel;

namespace VNDialogueEditor.DialogForms {
    public partial class NewChapterDialog : Form {

        public NewChapterDialog() {
            InitializeComponent();
            if (Editor.Chapters.Count == 0) {
                boxPlaceAfter.Items.Add("No chapters. Placing this as first.");
                boxPlaceAfter.SelectedIndex = 0;
                boxPlaceAfter.Enabled = false;
            }
            else {
                boxPlaceAfter.Items.Add("Place at the start");
                foreach (Chapter chapter in Editor.Chapters) {
                    boxPlaceAfter.Items.Add("Chapter " + chapter.Number);
                }
                boxPlaceAfter.SelectedIndex = boxPlaceAfter.Items.Count - 1;
            }
        }

        private void NewChapterDialog_FormClosing(object sender, FormClosingEventArgs e) {
            switch (DialogResult) {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    if (MessageBox.Show("Are you sure you want to close without adding?\nThe form will be discarded.", "Confirm closing", MessageBoxButtons.YesNo) == DialogResult.No) {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void rbBgImg_CheckedChanged(object sender, EventArgs e) {
            textBgImg.Enabled = rbBgImg.Checked;
            if (rbBgImg.Checked) {
                textBgImg.SelectAll();
                ActiveControl = textBgImg;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e) {
            string Background = "";
            if (rbBgImg.Checked) {
                if ((textBgImg.TextLength < 1 || textBgImg.Text == "(background image)")) {
                    MessageBox.Show("Wrong background image name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Background = textBgImg.Text;
            }
            Chapter NewChapter = new Chapter(Editor.HighestChapterNumber + 1, Background);
            switch (Editor.Chapters.Count) {
                case 0:
                    Editor.Chapters.Add(NewChapter);
                    break;
                default:
                    Editor.Chapters.Insert(boxPlaceAfter.SelectedIndex, NewChapter);
                    break;
            }

            Editor.HighestChapterNumber = NewChapter.Number;

            DialogResult = DialogResult.OK;
        }
    }
}
