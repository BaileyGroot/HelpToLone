using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISegrea
{
    class Wizard : Character, MagicSpell, Magic
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

            public void Teleport(int x, int y)
            {
               
            }

            public void ThrowFrostNova()
            {
            }

            public void ThrowMagicMisile()
            {
            }
    }
}
