using ApiGrafos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ApiGrafos
{
    public partial class Form1 : Form
    {

        
        private Grafo grafo;
        private GrafoControl Operacoes = new GrafoControl();
        TextBox Vertice = new TextBox();
        Label InfVert = new Label();
        Button BtOk = new Button();
        List<int> vetAdj = new List<int>();


        public Form1()
        {
            InitializeComponent();

           
        }

        public void setGrafo(Grafo g) { this.grafo = g; }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void NewVer_Click(object sender, EventArgs e)
        {
        }

      

        private void CriaGrafo_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                if (nameGrafo.Text != "" & nameGrafo.Text != null & numVert.Text !="")
                {
                    grafo = new Grafo();
                    grafo.setName(nameGrafo.Text);
                    grafo.setVertice(int.Parse(numVert.Text));
                    Operacoes.LoadFormAdj(grafo);
                    GroupMenu.Enabled = true;
                    CriaGrafo.Visible = false;
                    
                }
               else
                    MessageBox.Show("Entre com as informações corretas!");
               
                
            }

            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Numero de vertices inválido!");
            }
            

        
       }

        private void nameGrafo_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Operacoes.ValidaAdjVertices(grafo))
                MessageBox.Show("São adjacentes");
            else
                MessageBox.Show("Não são adjacentes!");
                

        }

        private void ButtonMenu_Click(object sender, EventArgs e )
        {
            
        }

        private void SetVerticesAdj(object sender, EventArgs e)
        {
            vetAdj.Add(int.Parse(Vertice.Text));
            Vertice.Text = "";
        }

       
    }
}
