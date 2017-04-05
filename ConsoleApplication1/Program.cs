using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

   
    public class Person
    {
        public Person(string name,int hp,int atk)
        {
            this.m_name = name;
            this.m_hp = hp;
            this.m_atk = atk;

        }
        public Person()
        {

        }
        public string Name { get { return m_name; }}
        public int HP { get { return m_hp;}}
        public int ATK { get { return m_atk; }}

        protected string m_name;
        protected int m_hp;
        protected int m_atk;
        public virtual void Attak(Person hit)
        {
            Console.WriteLine(this.Name + "对" + hit.Name + "进行一次攻击");
            hit.HitDamage(this.ATK);
        }
        public virtual void HitDamage(int damage)
        {
            if (damage < 0)
                return;
            
            this.m_hp -= damage;
            Console.WriteLine(this.Name + "受到的伤害为:" + damage);
            if (m_hp < 0)
            { 
                m_hp = 0;
                Console.WriteLine(this.Name + "受伤死亡");
            }
        }
        
    }
    public class Stuff
    {
        protected string b_name;
        protected int b_count;
        public Stuff(string name, int count)
        {
            this.b_name = name;
            this.b_count = count;


        }
        public Stuff()
        {
            this.b_name = "";
        }


        public virtual void potionuse()
        {
            Console.WriteLine("是否用药 [1]是 [2]不是");

        }
        public string Name { get { return b_name; } set { b_name = value; } }
        public int Count { get { return b_count; } set { b_count = value; } }

       /* private bool IsY()
        {

        }*/

    }
    public class Player :Person
    {

        private float m_c;
        public Player(string name, int hp, int atk,float c):
            base(name,hp,atk)
        {
            this.m_c = c;
        }
        public Player ()
        {
            this.m_name = "玩家";
            this.m_hp = 10;
            this.m_atk = 3;
            this.m_c = 0.3f;
        }

        private bool IsC()
        {
            Random _ran = new Random();
            float _r = _ran.Next(0,100);
            if (_r <= m_c * 100)
            {
                return true;
            }
            return false;
        }
        public override void Attak(Person hit)
        {
            if (IsC())
            {
                Console.WriteLine(this.Name + "对" + hit.Name +"造成了暴击！");
                hit.HitDamage(this.ATK * 2);
            }
            else {
                base.Attak(hit);
            }
        }


        public void BcakPack(Stuff potion )
        {
            
            Console.WriteLine("asdww");
        }
    }

    public class Enemy:Person
      {

        private float m_s;
        public Enemy(string name, int hp, int atk,float s):
            base(name,hp,atk)
        {
            this.m_s = s;
        }
        public Enemy ()
        {
            this.m_name = "怪物";
            this.m_hp = 5;
            this.m_atk = 2;
            this.m_s = 0.2f;
        }
        public bool IsS()
        {
            Random r1 = new Random();
            int i = r1.Next(2, 9);
            for( i = 0; i < 100; i++)
            {
             Random _ran = new Random(3);
            float _r = _ran.Next(0, 100); 
             }
            if (i <= m_s * 100)
            {
                return true;
            }
            return false;

            }

            
          
        public override void HitDamage(int damage)
        {
            if (IsS())
            {
                Console.WriteLine(this.Name + "闪避了这次攻击");
                return;
            }
                base.HitDamage(damage);
        }

        public Action DodgeCallBack { get; set; }
    }





    /* public class Sword : Stuff
     {
         public Sword(string name,int count) : base(name, count)
         {

         }

         public Sword()
         {
             this.b_name = "大剑";
             this.b_count = 3;
             Console.WriteLine(this.Name + "的数量为" + this.b_count);
         }


     }*/

    public class Potion : Stuff
    {
        public int b_use;

        public Potion(string name, int count) : base(name, count
            )
        {
        }

        public Potion()
        {

            this.b_name = "药水";

            this.b_count = 10;
            this.b_use = 1;
            int s = b_count;

            b_count -= b_use;




        }
        private bool IsU()
        {
            if (b_use < 1)
            {
                return true;
            }
            return false;
        }

        public override void potionuse()
        {
            if (IsU())
            {
                Console.WriteLine(this.b_name + "有" + this.b_count + 1 + "瓶" + "用了" + this.b_use + "瓶还剩" + this.b_count);
            }
            b_count -= b_use;


        }
    
        //public
        public virtual void use(int usecount)
        {
            if (usecount < 0)
                return;
            b_count -= b_use;
            //Console.WriteLine(this.b_name + "有" + this.b_count + "瓶" + "用了" + this.b_use + "瓶还剩" + this.b_count);
            //Console.ReadLine();
            
        }
    }

   
    class Program
    {
        private static bool dd;
        static void Main(string[] args)
        {

            Player player = new Player();
            Enemy enemy = new Enemy();

            Potion potion = new Potion();
            Stuff stuff = new Stuff();



            
            player = new Player("Player", 300, 23,0.3f);
            enemy = new Enemy("Enemy", 100, 13,0.3f);
            while (player.HP > 0 && enemy.HP > 0)
            {
                 player.Attak(enemy);
                enemy.Attak(player);
                stuff.potionuse();
                if (dd = true)
                {
                    player = new Player("player", 310, 23, 0.3f);
                    Console.WriteLine("如果是，玩家加10点血");
                }
                   
                Console.ReadLine();
            }



         



            /*int hpplayer = 10; //玩家血量
            int attakplayer = example.Next(2,5);  //玩家攻击力
            float exple = 0.3f;  //玩家暴击几率
            int explehurt = 4;   //玩家暴击伤害
            
            int hpenemy = 8; // 敌人血量
            int attakenemy = example.Next(2,4); // 敌人攻击力
            int exp = 100; //升级需要的经验值
            int level = 1; // 玩家的等级
            

            while (hpplayer > 0 && hpenemy > 0)
            {
                Console.WriteLine("玩家血量为：{0} \n 怪物血量为：{1}", hpplayer, hpenemy);
                hpplayer -= attakenemy;
                Console.WriteLine("玩家受到{0}伤害,血量：{1}", attakenemy,hpplayer);
                hpenemy -= attakplayer;
                Console.WriteLine("怪物受到{0}伤害,血量：{1}", attakplayer, hpenemy);
                
                Console.ReadLine();
            }
            if(hpplayer <=0 )
            Console.WriteLine("玩家死了，游戏结束");
            if(hpenemy <=0)
            Console.WriteLine("敌人死了，游戏结束");
            //int es1 = hpplayer - attakenemy; // 玩家被攻击
            //int es2 = hpenemy - attakplayer; // 敌人被攻击*/


        }
        public static void DebutLog(Person atk,Person hit)
        {
            Console.WriteLine(atk.Name + "攻击了" + hit.Name + "剩余血量" + hit.HP);
        }
    }
    
}
