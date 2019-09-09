using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartb
{
    class Insert
    {
        public static void InsertStudent()
        {
            //INSERT STUDENT
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";
            string sqlqr = "INSERT INTO STUDENT (IDSTUDENT ,FIRSTNAME,LASTNAME,DATEOFBIRTH,TUITIONFEES) VALUES(@id,@fname,@lname,@dateofbirth,@tuitionfees)";
            string sqlqrtest = "SELECT COUNT(*) FROM Student WHERE IDSTUDENT= @id2";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    Console.WriteLine("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                    cmfinder.Parameters.Add(new SqlParameter("id2", id));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This id already exists.");
                    }

                    Console.WriteLine("Enter firstname: ");
                    string fname = Console.ReadLine();

                    Console.WriteLine("Enter lastname: ");
                    string lname = Console.ReadLine();

                    Console.WriteLine("Enter date of birth (E.g. 2019/7/13): ");
                    DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter Tuition fees: ");
                    float tuitionfees = (float)Convert.ToInt32(Console.ReadLine());

                    SqlCommand cm = new SqlCommand(sqlqr, cn);
                    cm.Parameters.Add(new SqlParameter("id", id));
                    cm.Parameters.Add(new SqlParameter("fname", fname));
                    cm.Parameters.Add(new SqlParameter("lname", lname));
                    cm.Parameters.Add(new SqlParameter("dateofbirth", dateofbirth));
                    cm.Parameters.Add(new SqlParameter("tuitionfees", tuitionfees));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InsertTrainer()
        {
            //INSERT TRAINER & INSERT TRAINERS PER COURSE
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";
            string sqlqr = "INSERT INTO TRAINER (IDTRAINER,FIRSTNAME,LASTNAME,SUBJECT,COURSEID) VALUES(@id,@fname,@lname,@subject,@idc)";
            string sqlqr1 = "INSERT INTO TRAINER (IDTRAINER,FIRSTNAME,LASTNAME,SUBJECT) VALUES(@id1,@fname1,@lname1,@subject1)";
            string sqlqrtest = "SELECT COUNT(*) FROM TRAINER WHERE IDTRAINER= @id2";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    Console.WriteLine("If you want to pair a trainer with a course press 1 else press 2:");
                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine("Enter Trainer ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                        cmfinder.Parameters.Add(new SqlParameter("id2", id));

                        int count = (int)cmfinder.ExecuteScalar();
                        if (count >= 1)
                        {
                            throw new Exception("This id already exists.");
                        }

                        Console.WriteLine("Enter firstname: ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("Enter lastname: ");
                        string lname = Console.ReadLine();

                        Console.WriteLine("Enter subject: ");
                        string subject = Console.ReadLine();

                        Select.selectCourses();
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Enter Course id: ");
                        int idC = Convert.ToInt32(Console.ReadLine());

                        SqlCommand cm = new SqlCommand(sqlqr, cn);
                        cm.Parameters.Add(new SqlParameter("@id", id));
                        cm.Parameters.Add(new SqlParameter("fname", fname));
                        cm.Parameters.Add(new SqlParameter("lname", lname));
                        cm.Parameters.Add(new SqlParameter("subject", subject));
                        cm.Parameters.Add(new SqlParameter("idc", idC));

                        cm.ExecuteNonQuery();

                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter Trainer ID: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                        cmfinder.Parameters.Add(new SqlParameter("id2", id1));

                        int count = (int)cmfinder.ExecuteScalar();
                        if (count >= 1)
                        {
                            throw new Exception("This id already exists.");
                        }

                        Console.WriteLine("Enter firstname: ");
                        string fname1 = Console.ReadLine();

                        Console.WriteLine("Enter lastname: ");
                        string lname1 = Console.ReadLine();

                        Console.WriteLine("Enter subject: ");
                        string subject1 = Console.ReadLine();

                        SqlCommand cm = new SqlCommand(sqlqr1, cn);
                        cm.Parameters.Add(new SqlParameter("id1", id1));
                        cm.Parameters.Add(new SqlParameter("fname1", fname1));
                        cm.Parameters.Add(new SqlParameter("lname1", lname1));
                        cm.Parameters.Add(new SqlParameter("subject1", subject1));

                        cm.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void InsertAssignment()
        {
            //INSERT ASSIGNMENT
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";
            string sqlqr = "INSERT INTO ASSIGNMENT (IDASSIGNMENT,DESCRIPTION,SUBDATETIME,ORALMARK,TOTALMARK) VALUES(@id,@description,@subdatetime,@oralmark,@totalmark)";
            string sqlqrtest = "SELECT COUNT(*) FROM ASSIGNMENT WHERE IDASSIGNMENT= @id2";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    Console.WriteLine("Enter Assignment ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                    cmfinder.Parameters.Add(new SqlParameter("id2", id));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This id already exists.");
                    }

                    Console.WriteLine("Enter description: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter subdate (E.g. 2019/7/13): ");
                    DateTime subdatetime = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter oral mark: ");
                    int oralmark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter total mark: ");
                    int totalmark = Convert.ToInt32(Console.ReadLine());

                    SqlCommand cm = new SqlCommand(sqlqr, cn);
                    cm.Parameters.Add(new SqlParameter("id", id));
                    cm.Parameters.Add(new SqlParameter("description", description));
                    cm.Parameters.Add(new SqlParameter("subdatetime", subdatetime));
                    cm.Parameters.Add(new SqlParameter("oralmark", oralmark));
                    cm.Parameters.Add(new SqlParameter("totalmark", totalmark));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InsertCourse()
        {
            //INSERT COURSE
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";
            string sqlqr = "INSERT INTO COURSE (IDCOURSE,TITLE,STREAM,TYPE,STARTDATE,ENDDATE) VALUES(@id,@title,@stream,@type,@startdate,@enddate)";
            string sqlqrtest = "SELECT COUNT(*) FROM COURSE WHERE IDCOURSE= @id2";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    Console.WriteLine("Enter Course ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                    cmfinder.Parameters.Add(new SqlParameter("id2", id));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This id already exists.");
                    }

                    Console.WriteLine("Enter title: ");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter stream: ");
                    string stream = Console.ReadLine();

                    Console.WriteLine("Enter type: ");
                    string type = Console.ReadLine();

                    Console.WriteLine("Enter start date (E.g. 2019/7/13): ");
                    DateTime startdate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter end date (E.g. 2019/7/13): ");
                    DateTime enddate = Convert.ToDateTime(Console.ReadLine());


                    SqlCommand cm = new SqlCommand(sqlqr, cn);
                    cm.Parameters.Add(new SqlParameter("id", id));
                    cm.Parameters.Add(new SqlParameter("title", title));
                    cm.Parameters.Add(new SqlParameter("stream", stream));
                    cm.Parameters.Add(new SqlParameter("type", type));
                    cm.Parameters.Add(new SqlParameter("startdate", startdate));
                    cm.Parameters.Add(new SqlParameter("enddate", enddate));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InsertStudentperCourse()
        {
            Select.selectCourses();
            Console.WriteLine("Choose one course id: ");
            int courseid = Convert.ToInt32(Console.ReadLine());

            Select.selectStudents();
            Console.WriteLine("Choose one student id: ");
            int studentid = Convert.ToInt32(Console.ReadLine());

            //INSERT STUDENT_COURSE
            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";
            string sqlqr = "INSERT INTO COURSE_STUDENT(CID,SID) VALUES(@cid,@sid)";
            string sqlqrtest = "SELECT COUNT(*) FROM COURSE_STUDENT WHERE CID=@idc AND SID=@ids";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                    cmfinder.Parameters.Add(new SqlParameter("idc", courseid));
                    cmfinder.Parameters.Add(new SqlParameter("ids", studentid));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This id already exists.");
                    }
                    SqlCommand cm = new SqlCommand(sqlqr, cn);
                    cm.Parameters.Add(new SqlParameter("cid", courseid));
                    cm.Parameters.Add(new SqlParameter("sid", studentid));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InsertAssignmentperStudentperCourse()
        {
            Select.selectAssignments();
            Console.WriteLine("Choose one assignment id: ");
            int assignmentid = Convert.ToInt32(Console.ReadLine());

            Select.selectCourses();
            Console.WriteLine("Choose one course id: ");
            int courseid = Convert.ToInt32(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-JBG6OHV\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True";

            //INSERT ASSIGNMENT_COURSE
            string sqlqrCA = "INSERT INTO COURSE_ASSIGNMENT (IDC,IDA) VALUES(@courid,@assid)";
            string sqlqrtest1 = "SELECT COUNT(*) FROM COURSE_ASSIGNMENT WHERE IDC=@idc1 AND IDA=@ida1";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    SqlCommand cmfinder = new SqlCommand(sqlqrtest1, cn);
                    cmfinder.Parameters.Add(new SqlParameter("idc1", courseid));
                    cmfinder.Parameters.Add(new SqlParameter("ida1", assignmentid));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This assignment per course already exists.");

                    }

                    SqlCommand cm = new SqlCommand(sqlqrCA, cn);
                    cm.Parameters.Add(new SqlParameter("courid", courseid));
                    cm.Parameters.Add(new SqlParameter("assid", assignmentid));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Select.selectStudents();
            Console.WriteLine("Choose one student id: ");
            int studentid = Convert.ToInt32(Console.ReadLine());

            //INSERT STUDENT_COURSE
            string sqlqr = "INSERT INTO COURSE_STUDENT(CID,SID) VALUES(@cid,@sid)";
            string sqlqrtest = "SELECT COUNT(*) FROM COURSE_STUDENT WHERE CID=@idc AND SID=@ids";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    SqlCommand cmfinder = new SqlCommand(sqlqrtest, cn);
                    cmfinder.Parameters.Add(new SqlParameter("idc", courseid));
                    cmfinder.Parameters.Add(new SqlParameter("ids", studentid));

                    int count = (int)cmfinder.ExecuteScalar();
                    if (count >= 1)
                    {
                        throw new Exception("This student per course already exists.");
                    }
                    SqlCommand cm = new SqlCommand(sqlqr, cn);
                    cm.Parameters.Add(new SqlParameter("cid", courseid));
                    cm.Parameters.Add(new SqlParameter("sid", studentid));

                    cm.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
