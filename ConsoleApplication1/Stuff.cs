using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public abstract  class Stuff
    {

        protected string n_name;
        protected int n_id;
public Stuff(string name, int id)
        {
            this.n_name = name;
            this.n_id = id;
        }

        public Stuff()
        {

        }

        public string Name { get { return n_name; } set { n_name = value; } }
        public int ID { get { return n_id; } set { n_id = value; } }

        public abstract void Equipment();


        public abstract void Usement();
        
    }
}
