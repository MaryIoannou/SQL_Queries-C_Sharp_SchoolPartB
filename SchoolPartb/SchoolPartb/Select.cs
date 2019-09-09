using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartb
{
    class Select
    {
        public static void selectStudents()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //STUDENTS
            string sqlGetStudents = "SELECT * FROM STUDENT";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetStudents, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["IDSTUDENT"].ToString() + "   |  " + dr["FIRSTNAME"] + " |  " + dr["LASTNAME"] + " |  " + dr["DATEOFBIRTH"].ToString() + " |  " + dr["TUITIONFEES"].ToString());
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectTrainers()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //TRAINERS
            string sqlGetTrainers = "SELECT * FROM TRAINER  ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetTrainers, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["IDTRAINER"].ToString() + "   |  " + dr["FIRSTNAME"] + " |  " + dr["LASTNAME"] + " |  " + dr["SUBJECT"]);
                            Console.WriteLine("------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectAssignments()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //ASSIGNMENTS
            string sqlGetAssignments = "SELECT * FROM ASSIGNMENT";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetAssignments, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["IDASSIGNMENT"].ToString() + "   |  " + dr["DESCRIPTION"] + " |  " + dr["SUBDATETIME"].ToString() + " |  " + dr["ORALMARK"].ToString() + " |  " + dr["TOTALMARK"].ToString());
                            Console.WriteLine("-----------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectCourses()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //COURSES
            string sqlGetCourses = "SELECT * FROM COURSE";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetCourses, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["IDCOURSE"].ToString() + "   |  " + dr["TITLE"] + " |  " + dr["STREAM"] + " |  " + dr["TYPE"] + " |  " + dr["STARTDATE"].ToString() + " |  " + dr["ENDDATE"].ToString());
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectStudentsperCourse()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //STUDENTS PER COURSE
            string sqlGetStudentperCourse = "SELECT C.IDCOURSE,C.TITLE,C.STREAM,C.TYPE,S.FIRSTNAME,S.LASTNAME FROM COURSE_STUDENT CS INNER JOIN COURSE C ON CS.CID = C.IDCOURSE INNER JOIN STUDENT S ON CS.SID = S.IDSTUDENT; ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetStudentperCourse, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["FIRSTNAME"] + " |  " + dr["LASTNAME"] + " |  " + dr["TITLE"] + " |  " + dr["STREAM"] + " |  " + dr["TYPE"]);
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectTrainersperCourse()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //TRAINERS PER COURSE
            string sqlGetTrainersperCourses = "SELECT C.IDCOURSE,C.TITLE,C.STREAM,C.TYPE,T.FIRSTNAME,T.LASTNAME FROM TRAINER T INNER JOIN COURSE C ON T.COURSEID = C.IDCOURSE; ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetTrainersperCourses, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["FIRSTNAME"] + " |  " + dr["LASTNAME"] + " |  " + dr["TITLE"] + " |  " + dr["STREAM"] + " |  " + dr["TYPE"]);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectAssignmentsperCourse()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //ASSIGNMENTS PER COURSE
            string sqlGetAssignmentsperCourses = "SELECT C.IDCOURSE,C.TITLE,C.STREAM,C.TYPE,A.DESCRIPTION,A.SUBDATETIME FROM COURSE_ASSIGNMENT CA INNER JOIN COURSE C ON CA.IDC = C.IDCOURSE INNER JOIN ASSIGNMENT A ON CA.IDA = A.IDASSIGNMENT; ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetAssignmentsperCourses, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["DESCRIPTION"] + " |  " + dr["SUBDATETIME"].ToString() + " |  " + dr["TITLE"] + " |  " + dr["STREAM"] + " |  " + dr["TYPE"]);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void selectAssignmentsperCourseperStudent()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //ASSIGNMENTS PER COURSE PER STUDENT
            string sqlGetAssignmentsperCoursesperStudent = "SELECT S.FIRSTNAME AS STUDENT_NAME,S.LASTNAME AS STUDENT_LASTNAME,C.TITLE AS COURSE_TITLE,C.STREAM AS COURSE_STREAM,C.TYPE AS COURSE_TYPE,A.DESCRIPTION AS ASSIG_DESCR,A.SUBDATETIME AS ASSIG_SUBDATE FROM STUDENT S INNER JOIN COURSE_STUDENT CS ON S.IDSTUDENT = CS.SID INNER JOIN COURSE C ON CS.CID = C.IDCOURSE INNER JOIN COURSE_ASSIGNMENT CA ON C.IDCOURSE = CA.IDC INNER JOIN ASSIGNMENT A ON CA.IDA = A.IDASSIGNMENT; ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetAssignmentsperCoursesperStudent, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["ASSIG_DESCR"] + " |  " + dr["ASSIG_SUBDATE"].ToString() + " |  " + dr["COURSE_TITLE"] + " |  " + dr["STUDENT_NAME"] + " |  " + dr["STUDENT_LASTNAME"]);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectStudentsBelongsToMoreThanOneCourse()
        {
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //STUDENT THAT BELONG TO MORE THAN ONE COURSES
            string sqlGetStudentBellongToMoreThanOneCourses = "SELECT S.FIRSTNAME,S.LASTNAME, COUNT(*) AS COURSES FROM COURSE_STUDENT CS INNER JOIN COURSE C ON CS.CID = C.IDCOURSE INNER JOIN STUDENT S ON CS.SID = S.IDSTUDENT GROUP BY S.FIRSTNAME,S.LASTNAME HAVING COUNT(*) > 1; ";
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(sqlGetStudentBellongToMoreThanOneCourses, cn);
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["FIRSTNAME"] + " |  " + dr["LASTNAME"].ToString() + " |  " + dr["COURSES"].ToString());
                            Console.WriteLine("------------------------------------------------------------------------");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        

    }
}
