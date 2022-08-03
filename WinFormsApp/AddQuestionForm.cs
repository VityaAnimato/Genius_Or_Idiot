using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace WinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newQuestion = new Question();

            if (!UserInput.ValidateUserQuestion(userQuestionTextBox.Text))
            {
                var errorForm = new ErrorForm("Введите вопрос, не менее 10 символов");
                errorForm.ShowDialog();
                userQuestionTextBox.Text = errorForm.userAnswerTextBox.Text;
            }
            else
            {
                newQuestion.Text = userQuestionTextBox.Text;

                if (!UserInput.TryParseNumber(userAnswerTextBox.Text, out int number, out string errorMessage))
                {
                    var errorForm = new ErrorForm(errorMessage);
                    errorForm.ShowDialog();
                    userAnswerTextBox.Text = errorForm.userAnswerTextBox.Text;
                }
                else
                {
                    newQuestion.Answer = Convert.ToInt32(userAnswerTextBox.Text);
                    QuestionsStorage.Add(newQuestion);

                    MessageBox.Show("Вопрос успешно добавлен!");

                    Close();
                }
            }      
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
