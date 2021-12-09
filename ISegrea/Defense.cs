using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegrea
{
    interface Defense
    {
        void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }


    }
}
