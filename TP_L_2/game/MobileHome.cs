using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_L_2.game.interfaces;

namespace TP_L_2.game
{
    internal class MobileHome : Building, IMoveable
    {
        public MobileHome(int id, string name, int x, int y) : base(id, name, x, y)
        {
        }

        public void Move(int x, int y)
        {
            X = x; 
            Y = y;
        }
    }
}
