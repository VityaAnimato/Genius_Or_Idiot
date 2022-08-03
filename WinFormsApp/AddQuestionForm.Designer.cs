namespace WinFormsApp
{
    partial class AddQuestionForm
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
            this.okayButton = new System.Windows.Forms.Button();
            this.addNewQuestionLabel = new System.Windows.Forms.Label();
            this.addNewAnswerLabel = new System.Windows.Forms.Label();
            this.userQuestionTextBox = new System.Windows.Forms.TextBox();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(101, 297);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 0;
            this.okayButton.Text = "Okay...";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.addNewQuestionLabel.AutoSize = true;
            this.addNewQuestionLabel.Location = new System.Drawing.Point(71, 19);
            this.addNewQuestionLabel.Name = "label1";
            this.addNewQuestionLabel.Size = new System.Drawing.Size(140, 15);
            this.addNewQuestionLabel.TabIndex = 1;
            this.addNewQuestionLabel.Text = "Добавьте новый вопрос";
            // 
            // label2
            // 
            this.addNewAnswerLabel.AutoSize = true;
            this.addNewAnswerLabel.Location = new System.Drawing.Point(71, 180);
            this.addNewAnswerLabel.Name = "label2";
            this.addNewAnswerLabel.Size = new System.Drawing.Size(129, 15);
            this.addNewAnswerLabel.TabIndex = 2;
            this.addNewAnswerLabel.Text = "Добавьте новый ответ";
            // 
            // userQuestionTextBox
            // 
            this.userQuestionTextBox.Location = new System.Drawing.Point(12, 47);
            this.userQuestionTextBox.Multiline = true;
            this.userQuestionTextBox.Name = "userQuestionTextBox";
            this.userQuestionTextBox.Size = new System.Drawing.Size(267, 93);
            this.userQuestionTextBox.TabIndex = 3;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(86, 212);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(100, 23);
            this.userAnswerTextBox.TabIndex = 4;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 332);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.userQuestionTextBox);
            this.Controls.Add(this.addNewAnswerLabel);
            this.Controls.Add(this.addNewQuestionLabel);
            this.Controls.Add(this.okayButton);
            this.Name = "AddQuestionForm";
            this.Text = "Добавление нового вопроса";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label addNewQuestionLabel;
        private System.Windows.Forms.Label addNewAnswerLabel;
        public System.Windows.Forms.TextBox userQuestionTextBox;
        public System.Windows.Forms.TextBox userAnswerTextBox;
    }
}