using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    internal class Sorcerer : Fighter
    {
        public int SpellAttack { get; private set; }
        public int Mana {  get; private set; }

        public new void Person()
        {
            MaxHP = 15;
            CurrentHP = MaxHP;
            Attack = 2;
            defense = 0;
            IsAlive = true;
            SpellAttack = 12;
            Mana = 10;
            
        }
    }
}
