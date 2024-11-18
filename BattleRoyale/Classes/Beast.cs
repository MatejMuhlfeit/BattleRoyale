using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    internal class Beast : Knight
    {
        public new void Person()
        {
            MaxHP = 35;
            CurrentHP = MaxHP;
            Attack = 5;
            IsAlive = true;
        }
    }
}
