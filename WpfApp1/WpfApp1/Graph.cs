using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
  public  class Graph 
    {
        private Vertex ob;

        public Graph()
        {
            ob = new Vertex();
        }

        public void AddVertex(double i)
        {
            ob.add(i);
            
        }
    }
}
