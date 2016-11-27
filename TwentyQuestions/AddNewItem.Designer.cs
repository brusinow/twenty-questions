namespace TwentyQuestions
{
    partial class AddNewItem
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
            this.AddInstructions = new System.Windows.Forms.Label();
            this.NewItemInput = new System.Windows.Forms.TextBox();
            this.NewQuestionInput = new System.Windows.Forms.TextBox();
            this.QuestionInstruction = new System.Windows.Forms.Label();
            this.SubmitNewQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddInstructions
            // 
            this.AddInstructions.AutoSize = true;
            this.AddInstructions.Location = new System.Drawing.Point(160, 33);
            this.AddInstructions.Name = "AddInstructions";
            this.AddInstructions.Size = new System.Drawing.Size(267, 20);
            this.AddInstructions.TabIndex = 0;
            this.AddInstructions.Text = "I give up. What were you thinking of?";
            // 
            // NewItemInput
            // 
            this.NewItemInput.Location = new System.Drawing.Point(146, 65);
            this.NewItemInput.Name = "NewItemInput";
            this.NewItemInput.Size = new System.Drawing.Size(292, 26);
            this.NewItemInput.TabIndex = 1;
            // 
            // NewQuestionInput
            // 
            this.NewQuestionInput.Location = new System.Drawing.Point(145, 144);
            this.NewQuestionInput.Multiline = true;
            this.NewQuestionInput.Name = "NewQuestionInput";
            this.NewQuestionInput.Size = new System.Drawing.Size(292, 81);
            this.NewQuestionInput.TabIndex = 2;
            // 
            // QuestionInstruction
            // 
            this.QuestionInstruction.AutoSize = true;
            this.QuestionInstruction.Location = new System.Drawing.Point(141, 112);
            this.QuestionInstruction.Name = "QuestionInstruction";
            this.QuestionInstruction.Size = new System.Drawing.Size(297, 20);
            this.QuestionInstruction.TabIndex = 3;
            this.QuestionInstruction.Text = "Question where your thing would be YES";
            // 
            // SubmitNewQuestion
            // 
            this.SubmitNewQuestion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitNewQuestion.Location = new System.Drawing.Point(226, 231);
            this.SubmitNewQuestion.Name = "SubmitNewQuestion";
            this.SubmitNewQuestion.Size = new System.Drawing.Size(126, 47);
            this.SubmitNewQuestion.TabIndex = 4;
            this.SubmitNewQuestion.Text = "Submit";
            this.SubmitNewQuestion.UseVisualStyleBackColor = true;
            this.SubmitNewQuestion.Click += new System.EventHandler(this.SubmitNewQuestion_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 321);
            this.Controls.Add(this.SubmitNewQuestion);
            this.Controls.Add(this.QuestionInstruction);
            this.Controls.Add(this.NewQuestionInput);
            this.Controls.Add(this.NewItemInput);
            this.Controls.Add(this.AddInstructions);
            this.Name = "AddNewItem";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddInstructions;
        private System.Windows.Forms.TextBox NewItemInput;
        private System.Windows.Forms.TextBox NewQuestionInput;
        private System.Windows.Forms.Label QuestionInstruction;
        private System.Windows.Forms.Button SubmitNewQuestion;
    }
}