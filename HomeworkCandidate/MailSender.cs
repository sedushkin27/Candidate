using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCandidate
{
    public class MailSender
    {
        public void Mail(Candidate candidate) 
        {
            EmploeeDepartment department = new EmploeeDepartment();
            try
            {
                if (department.ApproveCandidate(candidate))
                {
                    if((DateTime.Now.Year - candidate.DateOfBirth.Year) < 18)
                    {
                        throw new Exception("The candidate is too young");
                    }
                    double salary = department.CalculateSalary(candidate);
                    Console.WriteLine($"Congratulations! You have been hired with a salary of {salary}");
                }
                else
                {
                    Console.WriteLine("Sorry, you have not been hired.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
