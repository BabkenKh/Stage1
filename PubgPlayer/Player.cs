using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgPlayer
{
    class Player
    {
        public string nick_name;
        public string gender;
        public byte health;
        private byte armor;
        private byte headarmor;
        private bool[] guns = new bool[3];
        private bool[] nades = new bool[4];
        private bool[] male = new bool[5];

        bool jump;
        double vDirection;
        double hDirection;
        double mDirection;
        byte speed;

        public void Print()
        {
            Console.WriteLine("Gender:"+ gender);
            Console.WriteLine("nick:"+nick_name);
        }







    }
}
