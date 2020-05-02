using System;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{
    class Exam
    {
        private int grade = 0;
        private int examNumber = 0;


        public Exam(int grade, int examNumber)
        {
            Grade = grade;
            ExamNumber = examNumber;
        }





        public int Grade
        {

            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    grade = 0;
                }
            }

        }

        public int ExamNumber
        {
            get
            {
                return examNumber;
            }
            set
            {
                if (value > 0)
                {
                    examNumber = value;
                }
                else
                {
                    examNumber = 0;
                }
            }

        }


        public string Show()
        {
            return String.Format("Exam {0}: {1}\n", examNumber.ToString(), grade.ToString());
        }

    }
}
