﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    public class Question
    {
        public bool parentYes;
        public string question;
        public Question yes;
        public Question no;

        public bool IsLeaf()
        {
            return yes == null || no == null;
        }
    }
}
