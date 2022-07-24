using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgPlayer
{
    class Program
    {
        static Player Seting()
        {
            Player player = new Player();
            player.nick_name = "Babken";
            player.health = 100;
            player.gender = "Male";

            return player;
        }


        static void Main(string[] args)
        {
            Player player = Seting();

            player.Print();

            Console.ReadKey();
        }
    }
}
