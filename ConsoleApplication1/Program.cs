using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

}

 class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            Enemy enemy = new Enemy();


            while (player.HP > 0 && enemy.HP > 0)
            {
                player.Attak(enemy);
                enemy.Attak(player);
                Console.ReadLine();
            }


        }
        public static void DebutLog(Person atk,Person hit)
        {
            Console.WriteLine(atk.Name + "攻击了" + hit.Name + "剩余血量" + hit.HP);
        }
    
    }
    


   
   

