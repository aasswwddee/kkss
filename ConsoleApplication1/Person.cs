using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Person
    {
        protected string m_name;
        protected int m_hp;
        protected int m_atk;
        public Person (string name, int hp,int atk)
        {
            this.m_name = name;
            this.m_hp = hp;
            this.m_atk = atk;
        }

        public Person()
        {


        }

        public string Name { get { return m_name; }set { m_name = value; } }
        public int HP { get { return m_hp; } set { m_hp = value; } }
        public int ATK { get { return m_atk; } set { m_atk = value; } }

        public virtual void Attak(Person hit)
        {
            
            Console.WriteLine(this.Name + "对" + hit.Name + "进行一次攻击");
            hit.HitDamage(this.ATK);
        }

        public virtual void HitDamage(int damage)
        {
            if(damage < 0)
            {
                return;
            }
           this.m_hp -= damage;
            Console.WriteLine(this.Name + "受到的伤害为:" + damage);
            if(m_hp < 0)
            {
                m_hp = 0;
                Console.WriteLine(this.Name + "死亡");
               
            }
        }

    }
}
