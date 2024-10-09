using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_L_2.game
{
    internal class GameObject
    {
        protected int Id;
        protected string Name;
        protected int X;
        protected int Y;
        public GameObject(int id, string name, int x, int y)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
        }

        public int getId()
        {
            return Id;
        } 
        public string getName()
        {
            return Name;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
    }
}
