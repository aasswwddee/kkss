using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Enemy:Person
    {

        public Enemy(string name,int hp,int atk):base(name,hp,atk)
        {

        } 

        public Enemy()
        {
            this.m_name = "敌人";
            this.m_hp = 100;
            this.m_atk = 20;
        }

        public override void HitDamage(int damage)
        {
            base.HitDamage(damage);
        }
        public Action DodgeCallBack { get; set; }
    }
}
