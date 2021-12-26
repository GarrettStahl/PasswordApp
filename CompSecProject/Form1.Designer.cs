
namespace CompSecProject
{
    partial class PWordStoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PWordTestTxtBox = new System.Windows.Forms.TextBox();
            this.PWordTestButton = new System.Windows.Forms.Button();
            this.PWordStrengthScoreBox = new System.Windows.Forms.TextBox();
            this.PWordTipsBox = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.passwordLabelBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.PWordIncorrectBox = new System.Windows.Forms.TextBox();
            this.ViewPWordButton = new System.Windows.Forms.Button();
            this.GoToTestPWords = new System.Windows.Forms.Button();
            this.PWordDisplayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PWordTestTxtBox
            // 
            this.PWordTestTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWordTestTxtBox.Location = new System.Drawing.Point(325, 200);
            this.PWordTestTxtBox.Name = "PWordTestTxtBox";
            this.PWordTestTxtBox.Size = new System.Drawing.Size(154, 20);
            this.PWordTestTxtBox.TabIndex = 0;
            this.PWordTestTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PWordTestButton
            // 
            this.PWordTestButton.Location = new System.Drawing.Point(347, 225);
            this.PWordTestButton.Name = "PWordTestButton";
            this.PWordTestButton.Size = new System.Drawing.Size(114, 23);
            this.PWordTestButton.TabIndex = 1;
            this.PWordTestButton.Text = "Test my password";
            this.PWordTestButton.UseVisualStyleBackColor = true;
            this.PWordTestButton.Click += new System.EventHandler(this.PWordTestButton_Click);
            // 
            // PWordStrengthScoreBox
            // 
            this.PWordStrengthScoreBox.AcceptsReturn = true;
            this.PWordStrengthScoreBox.Location = new System.Drawing.Point(350, 119);
            this.PWordStrengthScoreBox.Multiline = true;
            this.PWordStrengthScoreBox.Name = "PWordStrengthScoreBox";
            this.PWordStrengthScoreBox.ReadOnly = true;
            this.PWordStrengthScoreBox.Size = new System.Drawing.Size(111, 23);
            this.PWordStrengthScoreBox.TabIndex = 2;
            this.PWordStrengthScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PWordTipsBox
            // 
            this.PWordTipsBox.AcceptsTab = true;
            this.PWordTipsBox.Location = new System.Drawing.Point(241, 174);
            this.PWordTipsBox.Multiline = true;
            this.PWordTipsBox.Name = "PWordTipsBox";
            this.PWordTipsBox.ReadOnly = true;
            this.PWordTipsBox.Size = new System.Drawing.Size(111, 20);
            this.PWordTipsBox.TabIndex = 3;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(366, 275);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 4;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // passwordLabelBox
            // 
            this.passwordLabelBox.Location = new System.Drawing.Point(12, 12);
            this.passwordLabelBox.Name = "passwordLabelBox";
            this.passwordLabelBox.ReadOnly = true;
            this.passwordLabelBox.Size = new System.Drawing.Size(59, 20);
            this.passwordLabelBox.TabIndex = 5;
            this.passwordLabelBox.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(77, 12);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(36, 38);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // PWordIncorrectBox
            // 
            this.PWordIncorrectBox.Enabled = false;
            this.PWordIncorrectBox.Location = new System.Drawing.Point(11, 67);
            this.PWordIncorrectBox.Name = "PWordIncorrectBox";
            this.PWordIncorrectBox.ReadOnly = true;
            this.PWordIncorrectBox.Size = new System.Drawing.Size(151, 20);
            this.PWordIncorrectBox.TabIndex = 8;
            this.PWordIncorrectBox.Text = "Password incorrect. Try again.";
            // 
            // ViewPWordButton
            // 
            this.ViewPWordButton.Enabled = false;
            this.ViewPWordButton.Location = new System.Drawing.Point(347, 388);
            this.ViewPWordButton.Name = "ViewPWordButton";
            this.ViewPWordButton.Size = new System.Drawing.Size(113, 23);
            this.ViewPWordButton.TabIndex = 9;
            this.ViewPWordButton.Text = "View my passwords";
            this.ViewPWordButton.UseVisualStyleBackColor = true;
            this.ViewPWordButton.Visible = false;
            this.ViewPWordButton.Click += new System.EventHandler(this.ViewPWordButton_Click);
            // 
            // GoToTestPWords
            // 
            this.GoToTestPWords.Enabled = false;
            this.GoToTestPWords.Location = new System.Drawing.Point(347, 417);
            this.GoToTestPWords.Name = "GoToTestPWords";
            this.GoToTestPWords.Size = new System.Drawing.Size(113, 23);
            this.GoToTestPWords.TabIndex = 10;
            this.GoToTestPWords.Text = "Test my passwords";
            this.GoToTestPWords.UseVisualStyleBackColor = true;
            this.GoToTestPWords.Visible = false;
            this.GoToTestPWords.Click += new System.EventHandler(this.GoToTestPWords_Click);
            // 
            // PWordDisplayBox
            // 
            this.PWordDisplayBox.AcceptsReturn = true;
            this.PWordDisplayBox.AcceptsTab = true;
            this.PWordDisplayBox.Enabled = false;
            this.PWordDisplayBox.Location = new System.Drawing.Point(252, 12);
            this.PWordDisplayBox.Multiline = true;
            this.PWordDisplayBox.Name = "PWordDisplayBox";
            this.PWordDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PWordDisplayBox.Size = new System.Drawing.Size(324, 20);
            this.PWordDisplayBox.TabIndex = 12;
            this.PWordDisplayBox.Visible = false;
            this.PWordDisplayBox.WordWrap = false;
            this.PWordDisplayBox.TextChanged += new System.EventHandler(this.PWordDisplayBox_TextChanged);
            // 
            // PWordStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PWordDisplayBox);
            this.Controls.Add(this.GoToTestPWords);
            this.Controls.Add(this.ViewPWordButton);
            this.Controls.Add(this.PWordIncorrectBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabelBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PWordTipsBox);
            this.Controls.Add(this.PWordStrengthScoreBox);
            this.Controls.Add(this.PWordTestButton);
            this.Controls.Add(this.PWordTestTxtBox);
            this.Name = "PWordStoreForm";
            this.Text = "Password Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PWordTestTxtBox;
        private System.Windows.Forms.Button PWordTestButton;
        private System.Windows.Forms.TextBox PWordStrengthScoreBox;
        private System.Windows.Forms.TextBox PWordTipsBox;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox passwordLabelBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox PWordIncorrectBox;
        private System.Windows.Forms.Button ViewPWordButton;
        private System.Windows.Forms.Button GoToTestPWords;
        private System.Windows.Forms.TextBox PWordDisplayBox;
    }
}

