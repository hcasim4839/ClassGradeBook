using System;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{

    class StudentsList 
    {
        private List<Student> listOfStudents;
        private Student student;

        public StudentsList()
        {
            listOfStudents = new List<Student>();
        }

        public void addStudent(string name)
        {
            this.student = new Student(name);
            listOfStudents.Add(this.student);
        }

        public void showList()
        {
            string students = "Student List:\n ";
            foreach (Student student in listOfStudents)
            {
                students += "\n"+ student.Name;
            }
            Console.WriteLine(students); 
        }

        public void showGradesFrom(String name)
        {
            //input a message if the student is not on the list
            int indexOfName = findStudentIndex(name);
            string grades = listOfStudents[indexOfName].showGrades();

            Console.WriteLine(grades);
        }

        public void removeStudent(string name)
        {
            int indexOfName = findStudentIndex(name);
            
            if(indexOfName >= 0)
                listOfStudents.RemoveAt(indexOfName);
            else
                Console.WriteLine("Student is not on the list!");

        }

        public void removeExamFromStudent(string name, int examNumber)
        {
            int indexOfName = findStudentIndex(name);

            if (indexOfName >= 0)
            {
                Student currentStudent = listOfStudents[indexOfName];
                currentStudent.removeExam(examNumber);
            }
            else
            {
                Console.WriteLine("Student is not on the list!");
            }
        }

        public void addExamToStudent(string name , int examNumber, int grade)
        {
            int stdntIndex = findStudentIndex(name);

            if (stdntIndex >= 0)
            {
                Student currentStudent = listOfStudents[stdntIndex];
                currentStudent.addExam(grade, examNumber);
            }
            else
                Console.WriteLine("Student is not on the list!");

        }
        
        private int findStudentIndex(string name)
        {
            int currentIndex = 0;
            int index = -1;

            name = name.ToUpper();

            foreach (Student student in listOfStudents)
            {
                if (student.Name.Equals(name))
                {
                    index = currentIndex;
                }
                currentIndex++;
            }

            return index;
        }
        
    }
}
