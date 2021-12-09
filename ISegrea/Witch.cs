using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegrea
{
    class Witch : Character, Defense, Magic
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

        public void RaiseShield()
        {

        }

        public void ShieldGlare()
        {

        }

        public void Teleport(int x, int y)
        {

        }
    }
}
