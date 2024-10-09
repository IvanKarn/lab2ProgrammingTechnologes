using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_L_2.game.interfaces;

namespace TP_L_2.game
{
    internal class Fort : Building, IAttacker
    {
        protected float damage;
        public Fort(int id, string name, int x, int y,float damage) : base(id, name, x, y)
        {
            this.damage = damage;
        }

        public void attack(Unit unit)
        {
            unit.receiveDamage(damage);
        }
    }
}
