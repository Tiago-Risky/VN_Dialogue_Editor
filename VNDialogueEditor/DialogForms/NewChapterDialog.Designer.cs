namespace VNDialogueEditor.DialogForms {
    partial class NewChapterDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.boxPlaceAfter = new System.Windows.Forms.ComboBox();
            this.labelBackground = new System.Windows.Forms.Label();
            this.rbNoBg = new System.Windows.Forms.RadioButton();
            this.rbBgImg = new System.Windows.Forms.RadioButton();
            this.textBgImg = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(14, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(141, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "New Chapter";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(16, 73);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(64, 15);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Place After";
            // 
            // boxPlaceAfter
            // 
            this.boxPlaceAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPlaceAfter.FormattingEnabled = true;
            this.boxPlaceAfter.Location = new System.Drawing.Point(108, 70);
            this.boxPlaceAfter.Name = "boxPlaceAfter";
            this.boxPlaceAfter.Size = new System.Drawing.Size(279, 23);
            this.boxPlaceAfter.TabIndex = 2;
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(16, 114);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(71, 15);
            this.labelBackground.TabIndex = 3;
            this.labelBackground.Text = "Background";
            // 
            // rbNoBg
            // 
            this.rbNoBg.AutoSize = true;
            this.rbNoBg.Checked = true;
            this.rbNoBg.Location = new System.Drawing.Point(108, 112);
            this.rbNoBg.Name = "rbNoBg";
            this.rbNoBg.Size = new System.Drawing.Size(108, 19);
            this.rbNoBg.TabIndex = 4;
            this.rbNoBg.TabStop = true;
            this.rbNoBg.Text = "No Background";
            this.rbNoBg.UseVisualStyleBackColor = true;
            // 
            // rbBgImg
            // 
            this.rbBgImg.AutoSize = true;
            this.rbBgImg.Location = new System.Drawing.Point(222, 112);
            this.rbBgImg.Name = "rbBgImg";
            this.rbBgImg.Size = new System.Drawing.Size(28, 19);
            this.rbBgImg.TabIndex = 5;
            this.rbBgImg.Text = " ";
            this.rbBgImg.UseVisualStyleBackColor = true;
            this.rbBgImg.CheckedChanged += new System.EventHandler(this.rbBgImg_CheckedChanged);
            // 
            // textBgImg
            // 
            this.textBgImg.Enabled = false;
            this.textBgImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBgImg.Location = new System.Drawing.Point(241, 111);
            this.textBgImg.Name = "textBgImg";
            this.textBgImg.Size = new System.Drawing.Size(146, 23);
            this.textBgImg.TabIndex = 6;
            this.textBgImg.Text = "(background image)";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightSalmon;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(228, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 34);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightGreen;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(317, 179);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 34);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NewChapterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 225);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.textBgImg);
            this.Controls.Add(this.rbBgImg);
            this.Controls.Add(this.rbNoBg);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.boxPlaceAfter);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewChapterDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creating a New Chapter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewChapterDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox boxPlaceAfter;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.RadioButton rbNoBg;
        private System.Windows.Forms.RadioButton rbBgImg;
        private System.Windows.Forms.TextBox textBgImg;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}