using ApiGrafos.Model;
using ApiGrafos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace ApiGrafos
{
    class GrafoControl
    {
        private Grafo gAtual;
        List<int> VertAdj = new List<int>();



        public void LoadFormAdj(Grafo grafoAt)
        {
            FormAdj Form = new FormAdj(grafoAt);

            for (int i = 0; i < grafoAt.getVertice(); i++)
            {
                Form.nomeVert.Text = "0" + (i + 1);
                Form.ListaAdj.Text = "";
                Form.ShowDialog();

            }
        }

        public void LoadListaAdj(string lista, Grafo gAtual)
        {
            List<int> ListaAdjInt = lista.Split(',').Select(Int32.Parse).ToList();
            gAtual.setlistVertice(ListaAdjInt);
            Form1 form1 = new Form1();
            form1.setGrafo(gAtual);

        }

        public bool ValidaListaAdj(string lista, int numVert)
        {
            bool val = true;
            List<int> ListaAdjValida = lista.Split(',').Select(Int32.Parse).ToList();
            foreach (var adj in ListaAdjValida)
            {
                if (adj > numVert)
                    val = false;
            }
            return val;
        }

        public bool ValidaAdjVertices(Grafo gAtual)
        {
            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }


            return valida;
        }

        public bool getGrau(Vertice v1)
        {

            bool valida = false;
           
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;
        }

        public bool isRegular(Grafo G)
        {

            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;
        }

        public bool isIsolado(Vertice v1)
        {

            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;


        }

        public bool isPendente(Vertice v1)
        {


            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;

        }

        public bool isNulo(Grafo G)
        {

            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;

        }

        public bool isCompleto(Grafo G)
        {

            bool valida = false;
            List<List<int>> list = gAtual.getlistVertice();
            int[] inVertices = new int[2];
            // List<int> ListaAdjValida = list.Split(',').Select(Int32.Parse).ToList();
            for (int i = 0; i < 2; i++)
            {
                string sInput = Interaction.InputBox("Informe o vértice" + (i + 1), "Verifica adjacencia", "Apenas inteiros", 100, 200);
                inVertices[i] = Convert.ToInt32(sInput);
            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < list.Count; j++)
                {
                    if ((j + 1) == (inVertices[i]))
                    {

                        valida = true;
                        break;

                    }
                }
            }
            return valida;
        }

    }
}
