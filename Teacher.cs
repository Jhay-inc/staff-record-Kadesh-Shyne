using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffProjectTask
{
    public class Teacher: Database
    {
        public void LogIn()
        {
            Validation validate = new();
            Dictionary<string, string> userDetails = new();

            userDetails.Add("Email", "emmanuel@yahoo.com");
            userDetails.Add("Password", "holyfather");
            userDetails.Add("Name", "Chris Money");
            userDetails.Add("ID", "321T45");
            userDetails.Add("Department", "Finance");
            userDetails.Add("Role", "Manager");
            foreach (var key in userDetails)
            {
                Console.WriteLine($"{key.ToString()}");
            }
            base.LogInDetails();
        }
    }
}
