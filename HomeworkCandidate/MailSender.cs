using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCandidate
{
    public class MailSender
    {
        public void SendMail(Candidate candidate) 
        {
            EmploeeDepartment department = new EmploeeDepartment();
            try
            {
                if (department.ApproveCandidate(candidate))
                {
                    if(candidate.Age < 18)
                    {
                        throw new TooYoungException("The candidate is too young", candidate.Age);
                    }
                    double salary = department.CalculateSalary(candidate);
                    Console.WriteLine($"Congratulations! You have been hired with a salary of {salary}");
                }
                else
                {
                    Console.WriteLine("Sorry, you have not been hired.");
                }
            }
            catch (TooYoungException ex)
            {
                Console.WriteLine($"{ex.Message} Number of years: {ex.Age}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
