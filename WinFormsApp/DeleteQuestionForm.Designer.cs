namespace WinFormsApp
{
    partial class DeleteQuestionForm
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
            this.deleteQuestionInfoLabel = new System.Windows.Forms.Label();
            this.deleteQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deleteQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteQuestionInfoLabel
            // 
            this.deleteQuestionInfoLabel.AutoSize = true;
            this.deleteQuestionInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteQuestionInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteQuestionInfoLabel.Location = new System.Drawing.Point(89, 22);
            this.deleteQuestionInfoLabel.Name = "deleteQuestionInfoLabel";
            this.deleteQuestionInfoLabel.Size = new System.Drawing.Size(383, 15);
            this.deleteQuestionInfoLabel.TabIndex = 1;
            this.deleteQuestionInfoLabel.Text = "ЧТОБЫ УДАЛИТЬ ВОПРОС - НАЖМИТЕ 2 РАЗА ЛКМ НА ВОПРОС!";
            // 
            // deleteQuestionsDataGridView
            // 
            this.deleteQuestionsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteQuestionColumn,
            this.deleteAnswerColumn});
            this.deleteQuestionsDataGridView.Location = new System.Drawing.Point(12, 50);
            this.deleteQuestionsDataGridView.Name = "deleteQuestionsDataGridView";
            this.deleteQuestionsDataGridView.RowTemplate.Height = 25;
            this.deleteQuestionsDataGridView.Size = new System.Drawing.Size(542, 388);
            this.deleteQuestionsDataGridView.TabIndex = 2;
            this.deleteQuestionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteQuestionsDataGridView_CellContentClick);
            // 
            // deleteQuestionColumn
            // 
            this.deleteQuestionColumn.HeaderText = "Текст вопроса";
            this.deleteQuestionColumn.Name = "deleteQuestionColumn";
            this.deleteQuestionColumn.Width = 400;
            // 
            // deleteAnswerColumn
            // 
            this.deleteAnswerColumn.HeaderText = "Ответ";
            this.deleteAnswerColumn.Name = "deleteAnswerColumn";
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.deleteQuestionsDataGridView);
            this.Controls.Add(this.deleteQuestionInfoLabel);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn textColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerColumn;
        private System.Windows.Forms.Label deleteQuestionInfoLabel;
        private System.Windows.Forms.DataGridView deleteQuestionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteQuestionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteAnswerColumn;
    }
}