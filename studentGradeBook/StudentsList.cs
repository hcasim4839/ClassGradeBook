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

        public void addStudent(String name)
        {
            student = new Student(name);
            listOfStudents.Add(student);
        }

        public void showList()
        {
            
            String students = "Student List:\n ";
            foreach (Student student in listOfStudents)
            {
                students = students +"\n"+ student.Name;
            }
            Console.WriteLine(students);
               
        }

        public void showGradesFrom(String name)
        {
            int indexOfName = findStudentIndex(name);
            string grades = listOfStudents[indexOfName].showGrades();

            Console.WriteLine(grades);
        }

        public void removeStudent(String name)
        {

            int indexOfName = findStudentIndex(name);
            
            

            if(indexOfName >= 0)
            {
                listOfStudents.RemoveAt(indexOfName);
            }
            else
            {
                Console.WriteLine("Student is not on the list!");
            }

        }

        public void removeExamFromStudent(String name, int examNumber)
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

        public void addExamToStudent(String name , int examNumber, int grade)
        {
            int indexOfName = findStudentIndex(name);

            if (indexOfName >= 0)
            {
                Student currentStudent = listOfStudents[indexOfName];
                currentStudent.addExam(grade, examNumber);
            }
            else
            {
                Console.WriteLine("Student is not on the list!");
            }

        }
        

        private int findStudentIndex(String name)
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
