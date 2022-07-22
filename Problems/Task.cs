using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    static class Task
    {
        const int size = 3;
        static string[] Data = new string[size];

        public static void AddElments()
        {
            for (int i = 0; i < size; ++i)
            {
                Data[i] = Console.ReadLine();
            }
        }

        public static bool Check()
        {
            string temp = Data[0].Substring(0, 2);
            int check = 0;
            for (int j = 0; j < size - 1; ++j)
            {
                for (int i = 1; i < size; ++i)
                {
                    if (Data[i].Contains(temp))
                    {
                        ++check;
                    }
                }
                if (check == size-1)
                {
                    return true;
                }
                temp = Data[0].Substring(1, 2);
            }
            return false;

        }
    }
}
