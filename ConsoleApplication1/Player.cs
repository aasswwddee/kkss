using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
 public  class Player:Person
    {
        private float m_c;
        public Player(string name,int hp,int atk,float c):base(name,hp,atk)
        {
            this.m_c = c;

        }

        public Player()
        {
            this.m_name = "玩家";
            this.m_hp = 100;
            this.m_atk = 13;
            this.m_c = 0.6f;
        }

        private bool IsC()
        {
            Random _ran = new Random();
            float _r = _ran.Next(0, 100);
            if(_r < m_c * 100)
            {
                return true;
            }
            return false;
        }

        public override void Attak(Person hit)
        {
            if (IsC())
            {
                Console.WriteLine(this.Name + "对" + hit.Name  + "进行了一次暴击");
               hit.HitDamage(this.ATK * 2);
                Console.ReadLine();
            }
            else
            {
                base.Attak(hit);
            }
            
        }

    }
}
