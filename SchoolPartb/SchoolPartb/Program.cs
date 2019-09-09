using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartb
{
    class Program
    {
        static void Main(string[] args)
        {           
            int option = 0;
            while (option != 3)
            {
                Console.WriteLine();
                Console.WriteLine("-------SCHOOL MENU-------");
                Console.WriteLine("Choose 1-3 for: ");
                Console.WriteLine("1.View data");
                Console.WriteLine("2.Insert data");
                Console.WriteLine("3.Exit");
                Console.WriteLine();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        option = 0;
                        Console.WriteLine();
                        Console.WriteLine("------------view data-------------");
                        Console.WriteLine("Choose 1-9 for: ");
                        Console.WriteLine("1.Student");
                        Console.WriteLine("2.Trainer");
                        Console.WriteLine("3.Assigment");
                        Console.WriteLine("4.Course");
                        Console.WriteLine("5.Students per course");
                        Console.WriteLine("6.Trainers per course");
                        Console.WriteLine("7.Assigments per course");
                        Console.WriteLine("8.Assigments per student");
                        Console.WriteLine("9.Students that belongs to more than one course");
                        Console.WriteLine();
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case (1):
                                Select.selectStudents();
                                break;
                            case (2):
                                Select.selectTrainers();
                                break;
                            case (3):
                                option = 0;
                                Select.selectAssignments();
                                break;
                            case (4):
                                Select.selectCourses();
                                break;
                            case (5):
                                Select.selectStudentsperCourse();
                                break;
                            case (6):
                                Select.selectTrainersperCourse();
                                break;
                            case (7):
                                Select.selectAssignmentsperCourse();
                                break;
                            case (8):
                                Select.selectAssignmentsperCourseperStudent();
                                break;
                            case (9):
                                Select.selectStudentsBelongsToMoreThanOneCourse();
                                break;
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                        break;
                    case 2:
                        option = 0;
                        Console.WriteLine();
                        Console.WriteLine("------------insert data-------------");
                        Console.WriteLine("Choose 1-7 for: ");
                        Console.WriteLine("1.Student");
                        Console.WriteLine("2.Trainer");
                        Console.WriteLine("3.Assigment");
                        Console.WriteLine("4.Course");
                        Console.WriteLine("5.Students per course");
                        Console.WriteLine("6.Trainers per course");
                        Console.WriteLine("7.Assigments per student");
                        Console.WriteLine();
                        option = Convert.ToInt32(Console.ReadLine());                        
                        switch (option)
                        {
                            case (1):
                                Insert.InsertStudent();
                                break;
                            case (2):
                                Insert.InsertTrainer();
                                break;
                            case (3):
                                option = 0;
                                Insert.InsertAssignment();
                                break;
                            case (4):
                                Insert.InsertCourse();
                                break;
                            case (5):
                                Insert.InsertStudentperCourse();
                                break;
                            case (6):
                                Insert.InsertTrainer();
                                break;
                            case (7):
                                Insert.InsertAssignmentperStudentperCourse();
                                break;
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                        break;

                }                
            }
        }
    }
}
