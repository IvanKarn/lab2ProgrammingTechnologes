using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_L_2.game
{
    internal class Building : GameObject
    {
        protected bool isBuild;
        public Building(int id, string name, int x, int y) : base(id, name, x, y)
        {
            isBuild = true;
        }
        public void destroy()
        {
            isBuild=false;
        }

    }
}
