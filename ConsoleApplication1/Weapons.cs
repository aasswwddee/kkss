using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Weapons : Stuff
    {
        protected string b_name;
        protected int b_count;
        protected int b_atk;

        public Weapons(string name,int count,int atk)
        {
            this.b_name = name;
            this.b_count = count;
            this.b_atk = atk;
        }

        public string WName { get { return b_name; } set { b_name = value; } }
        public int WCount { get { return b_count; } set { b_count = value; } }
        public int WAtk { get { return b_atk; } set { b_atk = value; } }


        public virtual void Equipe(Weapons hit)
        {
            
        }
        public override void Equipment()
        {
            throw new NotImplementedException();
        }

        public override void Usement()
        {
            throw new NotImplementedException();
        }
    }
}
