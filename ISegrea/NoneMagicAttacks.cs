using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegrea
{
    interface NoneMagicAttacks
    {
        void Cleave()
        {
           Console.WriteLine("I'm cleaving someone");
        }
        void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
        void Bash()
        {
          Console.WriteLine("I'm bashing someone");
        }

    }
}
