using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGrafos
{
    class GrafoControl
    {

        bool isadjacente(Vertice v1, Vertice v2) {



            return true;
        }

        int getGrau(Vertice v1) { }

        bool isRegular(Grafo G) { }

        bool isIsolado(Vertice v1) { }

        bool isPendente(Vertice v1) { }

        bool isNulo(Grafo G) { }

        bool isCompleto(Grafo G) { }

        bool isConexo(Grafo G) { }

        bool isBipartido(Grafo G) { }

        Grafo getComplementar(Grafo G) { }

        bool isEuleriano(Grafo G) { }

        bool isUnicursal(Grafo G) { }

        bool isHamiltoniano(Grafo G) { }

        bool hasCiclo(Grafo G) { }

        int getGrauEntrada(Vertice v1) { }

        void ordenacaoTopologica(Grafo G) { } //verifique se o grafo é acíclico antes

        Grafos getTransposto(Grafo G) { }

        bool isFConexo(Grafo G) { }
    }
}
