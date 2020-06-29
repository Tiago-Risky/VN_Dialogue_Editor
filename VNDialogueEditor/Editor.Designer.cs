namespace VNDialogueEditor {
    partial class Editor {
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPointsMenu = new System.Windows.Forms.Button();
            this.btnCharsMenu = new System.Windows.Forms.Button();
            this.btnNewDialogue = new System.Windows.Forms.Button();
            this.btnNewChapter = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.dialogueTreeview = new System.Windows.Forms.TreeView();
            this.labelDialogueList = new System.Windows.Forms.Label();
            this.chapterList = new System.Windows.Forms.ListBox();
            this.labelChapterList = new System.Windows.Forms.Label();
            this.mainTopPanel = new System.Windows.Forms.Panel();
            this.gbChapter = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gbDialogue = new System.Windows.Forms.GroupBox();
            this.btnFixChapterNumbers = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.mainTopPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.MistyRose;
            this.rightPanel.Controls.Add(this.btnFixChapterNumbers);
            this.rightPanel.Controls.Add(this.btnExport);
            this.rightPanel.Controls.Add(this.btnPointsMenu);
            this.rightPanel.Controls.Add(this.btnCharsMenu);
            this.rightPanel.Controls.Add(this.btnNewDialogue);
            this.rightPanel.Controls.Add(this.btnNewChapter);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(852, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(132, 461);
            this.rightPanel.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(3, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnPointsMenu
            // 
            this.btnPointsMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPointsMenu.Location = new System.Drawing.Point(3, 115);
            this.btnPointsMenu.Name = "btnPointsMenu";
            this.btnPointsMenu.Size = new System.Drawing.Size(127, 31);
            this.btnPointsMenu.TabIndex = 3;
            this.btnPointsMenu.Text = "Manage Points";
            this.btnPointsMenu.UseVisualStyleBackColor = false;
            // 
            // btnCharsMenu
            // 
            this.btnCharsMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCharsMenu.Enabled = false;
            this.btnCharsMenu.Location = new System.Drawing.Point(3, 79);
            this.btnCharsMenu.Name = "btnCharsMenu";
            this.btnCharsMenu.Size = new System.Drawing.Size(127, 31);
            this.btnCharsMenu.TabIndex = 2;
            this.btnCharsMenu.Text = "Manage Characters";
            this.btnCharsMenu.UseVisualStyleBackColor = false;
            // 
            // btnNewDialogue
            // 
            this.btnNewDialogue.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewDialogue.Location = new System.Drawing.Point(3, 44);
            this.btnNewDialogue.Name = "btnNewDialogue";
            this.btnNewDialogue.Size = new System.Drawing.Size(127, 31);
            this.btnNewDialogue.TabIndex = 1;
            this.btnNewDialogue.Text = "New Dialogue";
            this.btnNewDialogue.UseVisualStyleBackColor = false;
            // 
            // btnNewChapter
            // 
            this.btnNewChapter.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewChapter.Location = new System.Drawing.Point(3, 9);
            this.btnNewChapter.Name = "btnNewChapter";
            this.btnNewChapter.Size = new System.Drawing.Size(127, 31);
            this.btnNewChapter.TabIndex = 0;
            this.btnNewChapter.Text = "New Chapter";
            this.btnNewChapter.UseVisualStyleBackColor = false;
            this.btnNewChapter.Click += new System.EventHandler(this.btnNewChapter_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.MistyRose;
            this.leftPanel.Controls.Add(this.dialogueTreeview);
            this.leftPanel.Controls.Add(this.labelDialogueList);
            this.leftPanel.Controls.Add(this.chapterList);
            this.leftPanel.Controls.Add(this.labelChapterList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(2, 0, 4, 4);
            this.leftPanel.Size = new System.Drawing.Size(234, 461);
            this.leftPanel.TabIndex = 1;
            // 
            // dialogueTreeview
            // 
            this.dialogueTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogueTreeview.Location = new System.Drawing.Point(2, 147);
            this.dialogueTreeview.Name = "dialogueTreeview";
            this.dialogueTreeview.Size = new System.Drawing.Size(228, 310);
            this.dialogueTreeview.TabIndex = 1;
            // 
            // labelDialogueList
            // 
            this.labelDialogueList.AutoSize = true;
            this.labelDialogueList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDialogueList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogueList.Location = new System.Drawing.Point(2, 128);
            this.labelDialogueList.Name = "labelDialogueList";
            this.labelDialogueList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelDialogueList.Size = new System.Drawing.Size(60, 19);
            this.labelDialogueList.TabIndex = 3;
            this.labelDialogueList.Text = "Dialogues";
            // 
            // chapterList
            // 
            this.chapterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.chapterList.FormattingEnabled = true;
            this.chapterList.ItemHeight = 15;
            this.chapterList.Location = new System.Drawing.Point(2, 19);
            this.chapterList.Name = "chapterList";
            this.chapterList.Size = new System.Drawing.Size(228, 109);
            this.chapterList.TabIndex = 0;
            // 
            // labelChapterList
            // 
            this.labelChapterList.AutoSize = true;
            this.labelChapterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChapterList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChapterList.Location = new System.Drawing.Point(2, 0);
            this.labelChapterList.Name = "labelChapterList";
            this.labelChapterList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelChapterList.Size = new System.Drawing.Size(53, 19);
            this.labelChapterList.TabIndex = 2;
            this.labelChapterList.Text = "Chapters";
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.Controls.Add(this.gbChapter);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(234, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.mainTopPanel.Size = new System.Drawing.Size(618, 129);
            this.mainTopPanel.TabIndex = 2;
            // 
            // gbChapter
            // 
            this.gbChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChapter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChapter.Location = new System.Drawing.Point(4, 4);
            this.gbChapter.Name = "gbChapter";
            this.gbChapter.Size = new System.Drawing.Size(610, 125);
            this.gbChapter.TabIndex = 0;
            this.gbChapter.TabStop = false;
            this.gbChapter.Text = "Selected Chapter";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gbDialogue);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(234, 129);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 3);
            this.mainPanel.Size = new System.Drawing.Size(618, 332);
            this.mainPanel.TabIndex = 3;
            // 
            // gbDialogue
            // 
            this.gbDialogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDialogue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDialogue.Location = new System.Drawing.Point(4, 4);
            this.gbDialogue.Name = "gbDialogue";
            this.gbDialogue.Size = new System.Drawing.Size(610, 325);
            this.gbDialogue.TabIndex = 1;
            this.gbDialogue.TabStop = false;
            this.gbDialogue.Text = "Selected Dialogue";
            // 
            // btnFixChapterNumbers
            // 
            this.btnFixChapterNumbers.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFixChapterNumbers.Location = new System.Drawing.Point(3, 152);
            this.btnFixChapterNumbers.Name = "btnFixChapterNumbers";
            this.btnFixChapterNumbers.Size = new System.Drawing.Size(127, 31);
            this.btnFixChapterNumbers.TabIndex = 5;
            this.btnFixChapterNumbers.Text = "Fix Chapter Nrs";
            this.btnFixChapterNumbers.UseVisualStyleBackColor = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainTopPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(880, 430);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.mainTopPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPointsMenu;
        private System.Windows.Forms.Button btnCharsMenu;
        private System.Windows.Forms.Button btnNewDialogue;
        private System.Windows.Forms.Button btnNewChapter;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TreeView dialogueTreeview;
        private System.Windows.Forms.ListBox chapterList;
        private System.Windows.Forms.Label labelDialogueList;
        private System.Windows.Forms.Label labelChapterList;
        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.GroupBox gbChapter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox gbDialogue;
        private System.Windows.Forms.Button btnFixChapterNumbers;
    }
}