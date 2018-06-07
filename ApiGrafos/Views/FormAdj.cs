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

namespace ApiGrafos.Views
{
    public partial class FormAdj : Form
    {
        private GrafoControl control = new GrafoControl();
        private Grafo gAtual;

        public FormAdj( Grafo gAtual)
        {
            setgAtual( gAtual);
            InitializeComponent();
        }

        public void setgAtual(Grafo g) { this.gAtual = g; }



        public void FormAdj_Load(object sender, EventArgs e)
        {

        }

        private void OkAdj_Click(object sender, EventArgs e)
        {
               
                
                if (ListaAdj.Text != "" & ListaAdj.Text != null)
                {
                    if (control.ValidaListaAdj(ListaAdj.Text, gAtual.getVertice()))
                    {
                        control.LoadListaAdj(ListaAdj.Text, gAtual);
                        this.Hide();
                    }
                    else
                    {
                        ListaAdj.Text = "";
                        MessageBox.Show("Lista incorreta! Digite novamente!");
                    }
                }
                else
                    MessageBox.Show("Lista incorreta!");
               
                
              
            }

        private void ListaAdj_TextChanged(object sender, EventArgs e)
        {

        }

        }
    
}
