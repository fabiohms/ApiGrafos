namespace ApiGrafos.Views
{
    partial class FormAdj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nomeVert = new System.Windows.Forms.Label();
            this.ListaAdj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OkAdj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite as adjacencias do vertice";
            // 
            // nomeVert
            // 
            this.nomeVert.AutoSize = true;
            this.nomeVert.Location = new System.Drawing.Point(176, 35);
            this.nomeVert.Name = "nomeVert";
            this.nomeVert.Size = new System.Drawing.Size(0, 13);
            this.nomeVert.TabIndex = 1;
            // 
            // ListaAdj
            // 
            this.ListaAdj.Location = new System.Drawing.Point(223, 35);
            this.ListaAdj.Name = "ListaAdj";
            this.ListaAdj.Size = new System.Drawing.Size(242, 20);
            this.ListaAdj.TabIndex = 2;
            this.ListaAdj.TextChanged += new System.EventHandler(this.ListaAdj_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Separadas por virgula.";
            // 
            // OkAdj
            // 
            this.OkAdj.Location = new System.Drawing.Point(208, 102);
            this.OkAdj.Name = "OkAdj";
            this.OkAdj.Size = new System.Drawing.Size(51, 21);
            this.OkAdj.TabIndex = 4;
            this.OkAdj.Text = "OK";
            this.OkAdj.UseVisualStyleBackColor = true;
            this.OkAdj.Click += new System.EventHandler(this.OkAdj_Click);
            // 
            // FormAdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 139);
            this.Controls.Add(this.OkAdj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaAdj);
            this.Controls.Add(this.nomeVert);
            this.Controls.Add(this.label1);
            this.Name = "FormAdj";
            this.Text = "Adjacencias";
            this.Load += new System.EventHandler(this.FormAdj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label nomeVert;
        public System.Windows.Forms.TextBox ListaAdj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OkAdj;
    }
}