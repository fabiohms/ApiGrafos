using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGrafos
{
    class Vertice
    {
      
        private List<Adjacencia> adj;


        public Vertice() {
            this.adj = new List<Adjacencia>();
        }
        public Vertice(List<Adjacencia> Adj){
            this.adj = Adj;
        }

        public void setAdj(List<Adjacencia> Adj)
        {
            this.adj = Adj;
        }
        public List<Adjacencia> getAdjacencia()
        {
            return this.adj;
        }

        public void addAdjacencia(Adjacencia a)
        {

            this.adj.Add(a);
        }
        
      //  List<Adjacencia> Adjacencias = new List<Adjacencia>();

    }
}
