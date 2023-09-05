using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCandidate
{
    public struct Candidate
    {
        public readonly string Name { get; }
        public readonly int Expiriance { get; }
        public readonly DateTime DateOfBirth { get; }
        public readonly int Age { get; }

        public Candidate(string name, int  expiriance, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Expiriance = expiriance;
            this.DateOfBirth = dateOfBirth;
            this.Age = DateTime.Now.Year - dateOfBirth.Year;
        }
    }
}
