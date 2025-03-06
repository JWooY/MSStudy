using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest20250306
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();
            Player player = new Player();

            player.SelectJob();
        }
    }
}
