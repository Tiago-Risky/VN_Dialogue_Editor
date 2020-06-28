using System;
using System.Windows.Forms;

namespace VNDialogueEditor.DialogForms {
    public partial class NewChapterDialog : Form {

        private int NewChapterID;

        public NewChapterDialog() {
            InitializeComponent();
            if (Editor.Chapters.Count == 0) {
                boxPlaceAfter.Items.Add("No chapters. Placing this as first.");
                boxPlaceAfter.SelectedIndex = 0;
                boxPlaceAfter.Enabled = false;
            }
            else {
                //TODO
            }
            NewChapterID = Editor.LastChapterID + 1;
            labelChapterID.Text = "Internal ID: " + NewChapterID;
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
            //TODO
            DialogResult = DialogResult.OK;
        }
    }
}
