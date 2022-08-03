using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace WinFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (!UserInput.ValidateUserName(userNameAnswerTextBox.Text))
            {
                MessageBox.Show("Введите имя! Оно не может быть пустым...");
            }
            else
            {
                Close();
            }

        }

        public void userNameAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
