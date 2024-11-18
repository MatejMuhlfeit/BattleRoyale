using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    internal class Fighter : Enemy
    {
        public int Name { get; private set; }

        public new void Person()
        {
            MaxHP = 15;
            CurrentHP = MaxHP;
            Attack = 6;
            defense = 0;
            IsAlive = true;
        }
    }
}
