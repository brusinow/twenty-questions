using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Question root;
        public static Question current;
        public static Question parent;
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            root = new Question();
            root.question = "is it hot?";
            root.yes = new Question();
            root.yes.question = "is it black coffee?";
            root.no = new Question();
            root.no.question = "Is it 2% milk?";
            current = root;
            QuestionLabel.Text = current.question;

        }

        public static void ReassignParent(string newQuestion, string newAnswer)
        {
           
            Question newCurrent = new Question();
            newCurrent.parentYes = current.parentYes;
            newCurrent.question = newQuestion;
            newCurrent.yes = new Question();
            newCurrent.yes.question = newAnswer;
            newCurrent.no = current;
            current = newCurrent;
            if (current.parentYes)
            {
                parent.yes = current;

            }
            else
            {
                parent.no = current;

            }






        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            // am I at a leaf?
            if (current.IsLeaf())
            {
                if (MessageBox.Show("You Got it! Do you want to play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    current = root;
                    QuestionLabel.Text = current.question;

                }
            }
            else
            {
                parent = current;
                current = current.yes;
                current.parentYes = true;
                QuestionLabel.Text = current.question;
             //ask next question
            }
            // Do you want to play again?


            
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            // am I at a leaf?
            if (current.IsLeaf())
            {
                AddNewItem addDialog = new AddNewItem();
                addDialog.ShowDialog();
                 if (addDialog.DialogResult == DialogResult.OK)
                {
                    addDialog.Close();
                }
             


                if (MessageBox.Show("Do you want to play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
 
                    current = root;
                    QuestionLabel.Text = current.question;
                }
            }
            else
            {
                parent = current;
                current = current.no;
                current.parentYes = false;
                QuestionLabel.Text = current.question;
            }
            // Do you want to play again?
           

        }
    }
}
