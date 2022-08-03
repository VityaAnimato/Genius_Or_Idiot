using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        Game game;
        int remainingTime = 10;
        int remainingTimeRound;

        public MainForm()
        {
            InitializeComponent();
        }

        

        public void mainForm_Load(object sender, EventArgs e)
        {            

            var startForm = new StartForm();
            startForm.ShowDialog();

            while (!UserInput.ValidateUserName(startForm.userNameAnswerTextBox.Text))
            {
                MessageBox.Show("Введите имя! Оно не может быть пустым...");
                startForm.ShowDialog();
            }
            var user = new User(startForm.userNameAnswerTextBox.Text);
            game = new Game(user);

            ShowNextQuestion();

        }

        public void ShowNextQuestion()
        {
            if (game.End())
            {
                FinishGame();
            }
            else
            {
                var currentQuestion = game.GetNextQuestion();
                questionTextLabel.Text = currentQuestion.Text;

                questionNumberLabel.Text = game.GetQuestionNumberText();

                remainingTimeRound = remainingTime;
                questionTimer.Enabled = true;
            }
            
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            remainingTimeRound--;
            remainingTimeLabel.Text = (remainingTimeRound).ToString() + " секунд";

            if (remainingTimeRound <= 0)
            {
                game.RejectAnswer();
                questionTimer.Stop();
                ShowNextQuestion();
            }
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            remainingTimeLabel.Text = (remainingTime).ToString() + " секунд";

            while (!UserInput.TryParseNumber(answerTextBox.Text, out int number, out string errorMessage))
            {
                var errorForm = new ErrorForm(errorMessage);
                errorForm.ShowDialog();
                answerTextBox.Text = errorForm.userAnswerTextBox.Text;
            }
            
            var userAnswer = Convert.ToInt32(answerTextBox.Text);           
            game.AcceptAnswer(userAnswer);

            questionTimer.Stop();

            ShowNextQuestion();
        }

        public void FinishGame()
        {
            game.GetDiagnose();
            MessageBox.Show($"{game.User.Name}, ваш диагноз - {game.User.LastDiagnose}");

            UsersResultStorage.Append(game.User);

            DialogResult result = MessageBox.Show(
                                                    "Хотите ли вы добавить новый вопрос?",
                                                    "?",
                                                    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var addQuestionsForm = new AddQuestionForm();

                addQuestionsForm.ShowDialog();
            }

            result = MessageBox.Show(
                                                    "Хотите ли вы удалить вопрос?",
                                                    "?",
                                                    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var deleteQuestionsForm = new DeleteQuestionForm();

                deleteQuestionsForm.ShowDialog();
            }

            result = MessageBox.Show(
                "Хотите ли вы посмотреть результаты?",
                "?",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var resultsForm = new ResultsForm();
                resultsForm.ShowDialog();
            }

            MessageBox.Show("СПАСИБО ЗА ИГРУ!");
            Application.Exit();
            return;
        }

        private void ShowResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.ShowDialog();
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionsForm = new AddQuestionForm();
            addQuestionsForm.ShowDialog();
        }
    }
}
