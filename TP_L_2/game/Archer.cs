using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_L_2.game.interfaces;

namespace TP_L_2.game
{
    internal class Archer : Unit, IMoveable, IAttacker
    {
        protected float damage;
        public Archer(int id, string name, int x, int y, float hp, float damage) : base(id, name, x, y,hp)
        {
            this.damage = damage;
        }

        public void attack(Unit unit)
        {
            unit.receiveDamage(damage);
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
