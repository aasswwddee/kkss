using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public class Potion:Stuff
    {
        protected string h_name;
        protected int h_count;
        protected int h_heal;
        public Potion(string name,int count,int heal)
        {
            this.h_name = name;
            this.h_count = count;
            this.h_heal = heal;

        }
        public string PName { get { return h_name; } set { h_name = value; } }
        public int PCount { get { return h_count; } set { h_count = value; } }
        public int PHeal { get { return h_heal; } set { h_heal = value; } }


        

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
