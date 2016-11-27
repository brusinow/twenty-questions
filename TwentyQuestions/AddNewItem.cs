﻿using System;
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
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void SubmitNewQuestion_Click(object sender, EventArgs e)
        {
        
            string newAnswer = NewItemInput.Text;
            string newQuestion = NewQuestionInput.Text;
            MainForm.ReassignParent(newQuestion, newAnswer);
            
        }
    }
}
