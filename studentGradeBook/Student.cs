using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{
    
    class Student
    {

        private List<Exam> examList;
        private String name;
        private Exam exam;

        public  Student(String name)
        {
            examList = new List<Exam>();
            Name = name;

        }

        public void addExam(int grade, int examNumber)
        {
            exam = new Exam(grade, examNumber);
            examList.Add(exam);
            
            
        }

        public void removeExam(int examNumber)
        {

            int index = 0;
            int indexOfExam = -1;

            foreach (Exam exam in examList)
            {
                if(exam.ExamNumber == examNumber)
                {
                    indexOfExam = index;
                    examList.RemoveAt(indexOfExam);
                }
                index++;
            }
        }
        public string showGrades()
        {
            String grades = "Grade List:\n";

            foreach (Exam grade in examList)
            {

                grades = grades + grade.Show() + "\n";
            
            }
            return grades;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                String newNameCase = value.ToUpper();
                this.name = newNameCase;

            }
        }

         

    }
}
