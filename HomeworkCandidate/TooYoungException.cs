using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCandidate
{
    internal class TooYoungException : Exception
    {
        public int Age;
        public TooYoungException(string massage, int age ) : base(massage)
        {
            Age = age;
        }
    }
}
