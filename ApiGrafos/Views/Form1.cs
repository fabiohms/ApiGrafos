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

namespace ApiGrafos
{
    public partial class Form1 : Form
    {
        
        private Grafo g;

        public Form1()
        {
            InitializeComponent();
        }

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
            try
            {
              
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void NewVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameVert.Text != null)
                    g.addVertice(nameVert.Text);
             

            }
        }

        private void newAdj_Click(object sender, EventArgs e)
        {

            TextBox tt = new TextBox();
 
        }
    }
}
