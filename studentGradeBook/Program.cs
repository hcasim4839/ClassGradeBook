using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace studentGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter username: ");
            String username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            String password = Console.ReadLine();

            while(username != "-1" && password != "-1")
            {
                bool authenticAccount = authenticate(username, password);

                if(authenticAccount)
                {
                    Console.WriteLine("Welcome, what operation would you like to do?\n-Student Management" +
                        " -Grade Management -END");
                    
                    String operation = Console.ReadLine().ToUpper().Trim();

                    StudentsList list = new StudentsList();
                    while (!operation.Equals("END"))
                    {
                        if (operation.Equals("STUDENT MANAGEMENT")){
                            //Print all students grades
                            studentManagement(list);
                            
                            
                        }else if(operation.Equals("GRADE MANAGEMENT"))
                        {
                            gradeManagement(list);

                        }
                        else
                        {
                            Console.WriteLine("Operation is not possible");
                        }

                        Console.WriteLine("Welcome, what operation would you like to do?\n-Student Management" +
                        " -Grade Management -END");

                        operation = Console.ReadLine().ToUpper().Trim();


                    }

                    

                    
                }
                Console.WriteLine("Enter username");
                username = Console.ReadLine();

                Console.WriteLine("Enter password");
                password = Console.ReadLine();

            }
            Console.WriteLine("Program has been terminated");


        }



        private static void gradeManagement(StudentsList list)
        {
            Console.WriteLine("Would you like to \"add\" or \"remove\" an exam or \"END\"?");
            String choice = Console.ReadLine().ToUpper();

            while(!choice.Equals("END"))
            {
                if (choice.Equals("ADD")){

                    list.showList();

                    Console.WriteLine("What student would you like to add an exam to?");
                    String name = Console.ReadLine();

                    String examPrompt = "What is the exam number?";

                    Console.WriteLine(examPrompt);
                    int examNum = Utility.intTester(examPrompt);

                    String gradePrompt = "What is the exam grade?";

                    Console.WriteLine(gradePrompt);
                    int grade = Utility.intTester(gradePrompt);
                   
                   
                    list.addExamToStudent(name, examNum, grade);

                    
                    
                    
                }else if (choice.Equals("REMOVE"))
                {
                    list.showList();

                    Console.WriteLine("Whose exam would you like to remove?");
                    String name = Console.ReadLine();

                    list.showGradesFrom(name);

                    int examNum = Utility.intTester("What exam would you like to remove?");

                    list.removeExamFromStudent(name, examNum);
                }
                else
                {
                    Console.WriteLine("That is not an available option");
                }
                Console.WriteLine("Would you like to \"add\" or \"remove\" an exam or \"END\"?\n");
                choice = Console.ReadLine().ToUpper();

            }

        }

        private static void studentManagement(StudentsList list)
        {
            Console.WriteLine("Would you like to \"add\" or \"remove\" a student or \"END\"?");
            String choice = Console.ReadLine().ToUpper();

            while(choice != "END")
            {
                if(choice.Equals("ADD"))
                {
                    Console.WriteLine("Enter the student's name:");
                    String name = Console.ReadLine().Trim();
                    list.addStudent(name);

                }else if (choice.Equals("REMOVE"))
                {
                    list.showList();
                    Console.WriteLine("\nWhat student would you like to remove?");
                    String name = Console.ReadLine().Trim();
                    list.removeStudent(name);

                }
                else
                {
                    Console.WriteLine("That action is unavailable");
                }
                Console.WriteLine("Would you like to \"add\" or \"remove\" a student or \"END\"?\n");
                choice = Console.ReadLine().ToUpper();

            }
        }

        private static bool authenticate(string username, string password)
        {
            String [] userNameDataBase = { "a" };
            String[] passwordDataBase = { "a" };

            for(int index = 0; index < userNameDataBase.Length; index++)
            {
                if(username.Equals(userNameDataBase[index]) && password.Equals(passwordDataBase[index]))
                {
                    return true;
                }
            }
            return false;


            
        }
    }
}
