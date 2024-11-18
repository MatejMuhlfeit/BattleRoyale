using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    internal class Enemy
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Attack { get; set; }
        public bool IsAlive { get; set; }


        public void Person ()
        {
            MaxHP = 15;
            CurrentHP = MaxHP;
            Attack = 6;
            IsAlive = true;
        } 
    }
    

}
