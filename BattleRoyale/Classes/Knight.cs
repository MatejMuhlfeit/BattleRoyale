using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    internal class Knight : Fighter
    {
        public int defense { get; private set; }


        public new void Person()
        {
            MaxHP = 25;
            CurrentHP = MaxHP;
            Attack = 4;
            IsAlive = true;
            defense = 3;

        }
    }
}
