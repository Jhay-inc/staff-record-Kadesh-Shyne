using StaffProjectTask;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Web;
using static StaffProjectTask.Database;

namespace StaffProject
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Principal principal = new Principal();
            Teacher teacher = new Teacher();
            ExamOfficer examOfficer = new ExamOfficer();
            Admin admin  = new Admin();
            Console.WriteLine("Press 5 (If PRINCIPAL), Press 6 (TEACHER), Press 7 (EXAM OFFICER), Press 8 (ADMIN)");
            string UserInput1 = Console.ReadLine();
            int UserInput2 = Convert.ToInt32(UserInput1);
            if (UserInput2 == 5)
            {
                principal.LogInDetails();
            }else if (UserInput2 == 6)
            {
                teacher.LogIn();
            }
            else if (UserInput2 == 7 )
            {
                examOfficer.LogIn();
            }
            else if (UserInput2 == 8)~
            {
                admin.LogInDetails();
            }
            Database db = new Database();



            //Console.WriteLine("Enter Email Address");
            //Console.ReadLine();
            //Console.WriteLine("Password");
            //Console.ReadLine();
            //Console.WriteLine("Name");
            //Console.ReadLine();
            //Console.WriteLine("ID");
            //Console.ReadLine();
            //Console.WriteLine("Department");
            //Console.ReadLine();
            //Console.WriteLine("Role");
            //Console.ReadLine();
        }
    }
}
