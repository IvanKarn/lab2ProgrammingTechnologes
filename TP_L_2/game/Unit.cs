using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_L_2.game
{
    internal class Unit : GameObject
    {
        protected bool isAlive;
        protected float hp;
        public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
        {
            this.hp = hp;
            isAlive = true;
        }
        public bool IsAlive() {
            return isAlive;
        }
        public float GetHP()
        {
            return hp;
        }
        public void receiveDamage(float damage)
        {
            hp -= damage;
            isAlive = hp > 0;
        }
    }
}
