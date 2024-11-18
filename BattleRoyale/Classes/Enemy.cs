using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Classes
{
    public class Enemy
    {
        protected int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        protected int Attack { get; set; }
        protected int defense { get; set; }
        public bool IsAlive { get; set; }


        public void Person ()
        {
            MaxHP = 15;
            CurrentHP = MaxHP;
            Attack = 6;
            defense = 0;
            IsAlive = true;
        }


        


    }
    

}
