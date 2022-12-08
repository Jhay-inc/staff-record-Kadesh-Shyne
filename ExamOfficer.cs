using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffProjectTask
{
    public class ExamOfficer:Database
    {
        public void LogIn()
        {
            Dictionary<string, string> userDetails = new();

            userDetails.Add(" ", " ");
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
