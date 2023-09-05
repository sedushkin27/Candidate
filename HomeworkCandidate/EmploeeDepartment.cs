using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCandidate
{
    public class EmploeeDepartment
    {
        public bool ApproveCandidate(Candidate candidate)
        {
            return (candidate.Expiriance >= 4);
        }

        public double CalculateSalary(Candidate candidate)
        {
            return 1000.0 / candidate.Expiriance;
        }
    }
}
