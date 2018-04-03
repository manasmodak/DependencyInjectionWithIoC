using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDIWithUnity
{
    public class Physics : ISubject
    {
        public string GetDescription()
        {
            return "Learning Physics";
        }

        public string GetReferenceBookName()
        {
            return "Physics by Prof. Physics Genius";
        }
        
    }
}
