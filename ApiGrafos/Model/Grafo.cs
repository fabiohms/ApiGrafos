using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGrafos.Model
{
    public class Grafo
    {
        private int numVertices;
        private string name;
        private List<int> vertices;
        private List<List<int>> VerticeAdj = new List<List<int>>();

        public Grafo() {
            
        }

        public void setName(string n){ this.name = n;}
        public void setlistVertice(List<int> listvert) { this.VerticeAdj.Add(listvert); }

        public List<List<int>> getlistVertice() { return this.VerticeAdj; }
        public void setVertice(int v){this.numVertices = v;}

        public int getVertice(){return this.numVertices;}


        public void addVertice(string v)
        {
        }
    }
}
