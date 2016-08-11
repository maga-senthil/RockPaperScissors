using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
             player newplayer = new player();
             newplayer.runGame();
            Console.ReadLine();
        }
    }
}
