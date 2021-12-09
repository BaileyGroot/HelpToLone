using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegrea
{
    class Babarian : Character, NoneMagicAttacks
    {
        Character ch = new Character();
        public new void Die()
        {
            ch.Die();
        }

        public new void Fight()
        {
            ch.Fight();
        }

        public new void Heal()
        {
            ch.Heal();
        }

        public void Bash()
        {

        }
        public void Cleave()
        {

        }
        public void Slash()
        {

        }


    }
}
