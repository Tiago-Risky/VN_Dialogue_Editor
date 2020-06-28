namespace VNDialogueEditor {
    partial class MainMenu {
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
            this.ButtonLegacyToV1 = new System.Windows.Forms.Button();
            this.ButtonLoadStart = new System.Windows.Forms.Button();
            this.ButtonNewStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLegacyToV1
            // 
            this.ButtonLegacyToV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLegacyToV1.Location = new System.Drawing.Point(12, 12);
            this.ButtonLegacyToV1.Name = "ButtonLegacyToV1";
            this.ButtonLegacyToV1.Size = new System.Drawing.Size(420, 70);
            this.ButtonLegacyToV1.TabIndex = 0;
            this.ButtonLegacyToV1.Text = "Convert Legacy XML to V1 XML";
            this.ButtonLegacyToV1.UseVisualStyleBackColor = true;
            this.ButtonLegacyToV1.Click += new System.EventHandler(this.ButtonLegacyToV1_Click);
            // 
            // ButtonLoadStart
            // 
            this.ButtonLoadStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLoadStart.Location = new System.Drawing.Point(12, 112);
            this.ButtonLoadStart.Name = "ButtonLoadStart";
            this.ButtonLoadStart.Size = new System.Drawing.Size(420, 70);
            this.ButtonLoadStart.TabIndex = 1;
            this.ButtonLoadStart.Text = "Start from Existing";
            this.ButtonLoadStart.UseVisualStyleBackColor = true;
            // 
            // ButtonNewStart
            // 
            this.ButtonNewStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewStart.Location = new System.Drawing.Point(12, 188);
            this.ButtonNewStart.Name = "ButtonNewStart";
            this.ButtonNewStart.Size = new System.Drawing.Size(420, 70);
            this.ButtonNewStart.TabIndex = 2;
            this.ButtonNewStart.Text = "Start from Scratch";
            this.ButtonNewStart.UseVisualStyleBackColor = true;
            this.ButtonNewStart.Click += new System.EventHandler(this.ButtonNewStart_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 271);
            this.Controls.Add(this.ButtonNewStart);
            this.Controls.Add(this.ButtonLoadStart);
            this.Controls.Add(this.ButtonLegacyToV1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLegacyToV1;
        private System.Windows.Forms.Button ButtonLoadStart;
        private System.Windows.Forms.Button ButtonNewStart;
    }
}