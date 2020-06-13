using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{
    
    class Student
    {

        private List<Exam> examList;
        private string name;
        private Exam exam;

        public  Student(string name)
        {
            examList = new List<Exam>();
            Name = name;
        }

        public void addExam(int examNumber, int grade)
        {
            exam = new Exam(examNumber, grade);
            examList.Add(exam);
        }

        public void removeExam(int examNumber)
        {
            int index = 0;
            foreach (Exam exam in examList)
            {
                if(exam.ExamNumber == examNumber)
                {
                    examList.RemoveAt(index);
                }
                index++;
            }
        }

        public string showGrades()
        {
            string grades = "Grade List:\n";
            foreach (Exam currentExam in examList)
            {
                grades += currentExam.Show() + "\n";
            }
            return grades;
        }

        public String Name
        {
            get{return this.name;}
            set{this.name = value.ToUpper();}
        }
    }
}
