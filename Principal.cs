using StaffProjectTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffProjectTask

{
    public class Principal: Database
    {
        public void PrincipalLogIn()
        {
            Principal principal = new Principal();
       
            string UserInput1 = Console.ReadLine();
            int UserInput2 = Convert.ToInt32(UserInput1);
            if (UserInput2 == 1)
            {
                principal.AddStaffRole();
            }
            else if (UserInput2 == 2)
            {
                principal.RemoveStaffRole();
            }
            else if (UserInput2 == 3)
            {
                principal.TransferAdminRole();
            }
        }
        public void AddStaffRole()
        {
            Console.ReadLine();
            Console.WriteLine("Teacher Added");
            Console.ReadLine();
            Console.WriteLine("Admin Added");
            Console.ReadLine();
            Console.WriteLine("Exam Officer Added");
            Console.ReadLine();
            Console.WriteLine("Academic Officer Added");
        }
        public void RemoveStaffRole()
        {
            Console.ReadLine();
            Console.WriteLine("Teacher Removed");
            Console.ReadLine();
            Console.WriteLine("Admin Removed");
            Console.ReadLine();
            Console.WriteLine("Exam Officer Removed");
            Console.ReadLine();
            Console.WriteLine("Academic Officer Removed");
        }
        public void TransferAdminRole()
        {

        }
        public void DeactivateStaffAccount()
        {
            List<string> userDetails = new();
            {
                userDetails.Remove("email");
                userDetails.Remove("password");
                userDetails.Remove("Name");
                userDetails.Remove("ID");
                userDetails.Remove("Department");
                userDetails.Remove("Role");
            }
            foreach (string user in userDetails)
            {
                Console.WriteLine("Account Deactivated");
            }
           
        }
        public void LogIn()
        {
             base.LogInDetails();
        }
        
    }
}
