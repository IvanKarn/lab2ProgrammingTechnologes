using TP_L_2.game;
using TP_L_2.game.interfaces;

namespace TP_L_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(new Archer(1, "archer", 0, 0, 30f, 10f));
            attackers.Add(new Fort(2, "fort", 10, 0, 20f));
            Archer archer = new Archer(3, "archer2", 0, 0, 30f, 10f);
            Console.WriteLine(Convert.ToString(archer.IsAlive()));
            foreach (var item in attackers)
            {
                item.attack(archer);
                Console.WriteLine(Convert.ToString(archer.GetHP()));
            }
            Console.WriteLine(Convert.ToString(archer.IsAlive()));
        }
    }
}
