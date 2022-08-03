using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace WinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetQuestions();
            foreach (var question in questions)
            {
                deleteQuestionsDataGridView.Rows.Add(question.Text, question.Answer);
            }

        }

        private void deleteQuestionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (QuestionsStorage.GetQuestions().Count == 1)
            {
                MessageBox.Show("Вы пытаесь удалить последний вопрос. Так нельзя. Сначала добавьте еще вопросов - потом удаляйте...");
            }
            else
            {
                int deleteIndexDataGridView = deleteQuestionsDataGridView.SelectedCells[0].RowIndex;
                var textDeleteQuestion = (string)deleteQuestionsDataGridView.SelectedCells[0].Value;
                deleteQuestionsDataGridView.Rows.RemoveAt(deleteIndexDataGridView);

                var deleteIndexInStorage = QuestionsStorage.FindByText(textDeleteQuestion);
                QuestionsStorage.Delete(deleteIndexInStorage);
            }
        }
    }
}
