using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDIWithUnity
{
    public class Math : ISubject
    {
        public string GetDescription()
        {
            return "Learning Math";
        }

        public string GetReferenceBookName()
        {
            return "Math by Prof. Math Genius";
        }        
    }
}
