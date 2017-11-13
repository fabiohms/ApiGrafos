using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGrafos.Model
{
    class Grafo
    {
        private List<string> vertices;

        public Grafo() {
            this.vertices = new List<Vertice>();
        }
        public Grafo(List<Vertice> v){
            this.vertices = v;
        }

        public void setVertice(List<Vertice> v)
        {
            this.vertices = v;
        }
        public List<Vertice> getVertice()
        {
            return this.vertices;
        }
        public void addVertice(string v)
        {

            vertices.Add(v);
        }
    }
}
