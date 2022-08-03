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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UsersResultStorage.GetUserResults();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.LastQtyRightAnswers, result.LastDiagnose);
            }
        }
    }
}
