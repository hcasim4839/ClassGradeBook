using System;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{
    class Exam
    {
        private int grade;
        private int examNumber;
        private int upperGradeLimit = 100;
        private int lowerGradeLimit = 0;

        public Exam(int examNumber, int grade)
        {
            Grade = grade;
            ExamNumber = examNumber;
        }

        public int Grade
        {
            set{
                grade = (value >= lowerGradeLimit && value <= upperGradeLimit) ? grade = value : grade = 0;
            }
        }

        public int ExamNumber
        {
            get{return examNumber;}
            set
            {
                examNumber = (value >= 0) ? examNumber = value : examNumber = 0;
            }

        }

        public string Show()
        {
            return String.Format("Exam {0}: {1}\n", examNumber.ToString(), grade.ToString());
        }

    }
}
