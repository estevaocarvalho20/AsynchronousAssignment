namespace BookWordFrequency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookOne = new Label();
            lblBookTwo = new Label();
            txtBookOnePath = new TextBox();
            btnBrowseBookOne = new Button();
            txtBookTwoPath = new TextBox();
            btnBrowseBookTwo = new Button();
            btnSubmit = new Button();
            btnExit = new Button();
            lstBookOneWords = new ListBox();
            lstBookTwoWords = new ListBox();
            SuspendLayout();
            // 
            // lblBookOne
            // 
            lblBookOne.AutoSize = true;
            lblBookOne.Location = new Point(37, 89);
            lblBookOne.Name = "lblBookOne";
            lblBookOne.Size = new Size(55, 20);
            lblBookOne.TabIndex = 0;
            lblBookOne.Text = "Book 1";
            lblBookOne.Click += label1_Click;
            // 
            // lblBookTwo
            // 
            lblBookTwo.AutoSize = true;
            lblBookTwo.Location = new Point(561, 90);
            lblBookTwo.Name = "lblBookTwo";
            lblBookTwo.Size = new Size(55, 20);
            lblBookTwo.TabIndex = 1;
            lblBookTwo.Text = "Book 2";
            // 
            // txtBookOnePath
            // 
            txtBookOnePath.Location = new Point(98, 86);
            txtBookOnePath.Name = "txtBookOnePath";
            txtBookOnePath.Size = new Size(282, 27);
            txtBookOnePath.TabIndex = 2;
            // 
            // btnBrowseBookOne
            // 
            btnBrowseBookOne.Location = new Point(386, 86);
            btnBrowseBookOne.Name = "btnBrowseBookOne";
            btnBrowseBookOne.Size = new Size(126, 28);
            btnBrowseBookOne.TabIndex = 3;
            btnBrowseBookOne.Text = "Browse";
            btnBrowseBookOne.UseVisualStyleBackColor = true;
            btnBrowseBookOne.Click += btnBrowseBookOne_Click;
            // 
            // txtBookTwoPath
            // 
            txtBookTwoPath.Location = new Point(622, 87);
            txtBookTwoPath.Name = "txtBookTwoPath";
            txtBookTwoPath.Size = new Size(300, 27);
            txtBookTwoPath.TabIndex = 4;
            // 
            // btnBrowseBookTwo
            // 
            btnBrowseBookTwo.Location = new Point(933, 90);
            btnBrowseBookTwo.Name = "btnBrowseBookTwo";
            btnBrowseBookTwo.Size = new Size(94, 29);
            btnBrowseBookTwo.TabIndex = 5;
            btnBrowseBookTwo.Text = "Browse";
            btnBrowseBookTwo.UseVisualStyleBackColor = true;
            btnBrowseBookTwo.Click += btnBrowseBookTwo_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(386, 158);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(126, 31);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(561, 158);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstBookOneWords
            // 
            lstBookOneWords.FormattingEnabled = true;
            lstBookOneWords.Location = new Point(37, 215);
            lstBookOneWords.Name = "lstBookOneWords";
            lstBookOneWords.Size = new Size(475, 404);
            lstBookOneWords.TabIndex = 8;
            lstBookOneWords.SelectedIndexChanged += lstBookOneWords_SelectedIndexChanged;
            // 
            // lstBookTwoWords
            // 
            lstBookTwoWords.FormattingEnabled = true;
            lstBookTwoWords.Location = new Point(561, 215);
            lstBookTwoWords.Name = "lstBookTwoWords";
            lstBookTwoWords.Size = new Size(466, 404);
            lstBookTwoWords.TabIndex = 9;
            lstBookTwoWords.SelectedIndexChanged += lstBookTwoWords_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 706);
            Controls.Add(lstBookTwoWords);
            Controls.Add(lstBookOneWords);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowseBookTwo);
            Controls.Add(txtBookTwoPath);
            Controls.Add(btnBrowseBookOne);
            Controls.Add(txtBookOnePath);
            Controls.Add(lblBookTwo);
            Controls.Add(lblBookOne);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookOne;
        private Label lblBookTwo;
        private TextBox txtBookOnePath;
        private Button btnBrowseBookOne;
        private TextBox txtBookTwoPath;
        private Button btnBrowseBookTwo;
        private Button btnSubmit;
        private Button btnExit;
        private ListBox lstBookOneWords;
        private ListBox lstBookTwoWords;
    }
}
