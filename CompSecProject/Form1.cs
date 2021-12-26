using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSecProject
{
    public partial class PWordStoreForm : Form
    {
        PWordStrenTest passwordTester = new PWordStrenTest();
        private readonly string encTestKey = "abcdefghijklmnopqrstuvwxyz123456";

        public PWordStoreForm()
        {
            InitializeComponent();
            PWordStrengthScoreBox.Enabled = false;
            PWordStrengthScoreBox.Visible = false;
            PWordTipsBox.Enabled = false;
            PWordTipsBox.Visible = false;
            GoBackButton.Enabled = false;
            GoBackButton.Visible = false;
            PWordTestTxtBox.Enabled = false;
            PWordTestTxtBox.Visible = false;
            PWordTestButton.Visible = false;
            PWordTestButton.Enabled = false;
            PWordIncorrectBox.Visible = false;
            PWordIncorrectBox.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void PWordTestButton_Click(object sender, EventArgs e)
        {
            PWordTestTxtBox.Enabled = false;
            PWordTestTxtBox.Visible = false;
            PWordTestButton.Visible = false;
            PWordTestButton.Enabled = false;
            ViewPWordButton.Enabled = false;
            ViewPWordButton.Visible = false;

            PWordStrengthScoreBox.Enabled = true;
            PWordStrengthScoreBox.Visible = true;
            PWordTipsBox.Enabled = true;
            PWordTipsBox.Visible = true;
            GoBackButton.Enabled = true;
            GoBackButton.Visible = true;
           
            (double, string) scoreAndImproveTips = passwordTester.PasswordStrengthTest(PWordTestTxtBox.Text);

            string curPWord = PWordTestTxtBox.Text;

            PWordStrengthScoreBox.Text = "Password: " + curPWord + Environment.NewLine + "Score: " + scoreAndImproveTips.Item1.ToString() + " out of 9." + Environment.NewLine;
            PWordTipsBox.Text = scoreAndImproveTips.Item2;

            Size scoreSize = TextRenderer.MeasureText(PWordStrengthScoreBox.Text, PWordStrengthScoreBox.Font);
            PWordStrengthScoreBox.Width = scoreSize.Width;
            PWordStrengthScoreBox.Height = scoreSize.Height;

            Size tipsSize = TextRenderer.MeasureText(PWordTipsBox.Text, PWordTipsBox.Font);
            PWordTipsBox.Width = tipsSize.Width;
            PWordTipsBox.Height = tipsSize.Height;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            PWordStrengthScoreBox.Enabled = false;
            PWordStrengthScoreBox.Visible = false;
            PWordTipsBox.Enabled = false;
            PWordTipsBox.Visible = false;
            GoBackButton.Enabled = false;
            GoBackButton.Visible = false;

            PWordTestTxtBox.Enabled = true;
            PWordTestTxtBox.Visible = true;
            PWordTestButton.Visible = true;
            PWordTestButton.Enabled = true;
            ViewPWordButton.Enabled = true;
            ViewPWordButton.Visible = true;
            PWordTestTxtBox.Text = string.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "password") // password: only 'password' for testing purposes
            {
                PWordTestTxtBox.Enabled = true;
                PWordTestTxtBox.Visible = true;
                PWordTestButton.Visible = true;
                PWordTestButton.Enabled = true;
                PWordTestTxtBox.Text = string.Empty;
                ViewPWordButton.Enabled = true;
                ViewPWordButton.Visible = true;

                passwordLabelBox.Visible = false;
                passwordLabelBox.Enabled = false;
                loginButton.Enabled = false;
                loginButton.Visible = false;
                passwordBox.Enabled = false;
                passwordBox.Visible = false;
                PWordIncorrectBox.Visible = false;
                PWordIncorrectBox.Enabled = false;
            }
            else
            {
                PWordIncorrectBox.Visible = true;
                PWordIncorrectBox.Enabled = true;
            }
        }

        private void ViewPWordButton_Click(object sender, EventArgs e)
        {
            GoToTestPWords.Enabled = true;
            GoToTestPWords.Visible = true;
            PWordDisplayBox.Enabled = true;
            PWordDisplayBox.Visible = true;

            PWordTestTxtBox.Visible = false;
            PWordTestTxtBox.Enabled = false;
            PWordTestButton.Visible = false;
            PWordTestButton.Enabled = false;
            ViewPWordButton.Enabled = false;
            ViewPWordButton.Visible = false;

            string pWordList = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "passwords.txt"));

            PWordDisplayBox.Text = passwordTester.DecryptString(encTestKey, pWordList);

            Size pWordDisplayBoxSize = TextRenderer.MeasureText(PWordDisplayBox.Text, PWordDisplayBox.Font);
            if (pWordDisplayBoxSize.Width > 10 && pWordDisplayBoxSize.Height > 15)
            {
                PWordDisplayBox.Width = pWordDisplayBoxSize.Width + 100;
                PWordDisplayBox.Height = pWordDisplayBoxSize.Height + 10;
            }
        }

        private void GoToTestPWords_Click(object sender, EventArgs e)
        {
            ViewPWordButton.Enabled = true;
            ViewPWordButton.Visible = true;
            PWordTestTxtBox.Visible = true;
            PWordTestTxtBox.Enabled = true;
            PWordTestButton.Visible = true;
            PWordTestButton.Enabled = true;

            GoToTestPWords.Enabled = false;
            GoToTestPWords.Visible = false;
            PWordDisplayBox.Enabled = false;
            PWordDisplayBox.Visible = false;

            string pWordList = passwordTester.EncryptString(encTestKey, PWordDisplayBox.Text);

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "passwords.txt"), pWordList);
        }

        private void PWordDisplayBox_TextChanged(object sender, EventArgs e)
        {
            Size pWordDisplayBoxSize = TextRenderer.MeasureText(PWordDisplayBox.Text, PWordDisplayBox.Font);
            PWordDisplayBox.Width = pWordDisplayBoxSize.Width + 100;
            PWordDisplayBox.Height = pWordDisplayBoxSize.Height + 10;
            
        }
    }
}
