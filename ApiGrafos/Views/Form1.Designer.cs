namespace ApiGrafos
{
    partial class Form1
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
            this.numVert = new System.Windows.Forms.TextBox();
            this.CriaGrafo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameGrafo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.verticeLabel = new System.Windows.Forms.Label();
            this.GroupMenu = new System.Windows.Forms.GroupBox();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.isAdj = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.GroupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // numVert
            // 
            this.numVert.Location = new System.Drawing.Point(124, 70);
            this.numVert.Name = "numVert";
            this.numVert.Size = new System.Drawing.Size(66, 20);
            this.numVert.TabIndex = 5;
            // 
            // CriaGrafo
            // 
            this.CriaGrafo.Location = new System.Drawing.Point(196, 70);
            this.CriaGrafo.Name = "CriaGrafo";
            this.CriaGrafo.Size = new System.Drawing.Size(33, 20);
            this.CriaGrafo.TabIndex = 7;
            this.CriaGrafo.Text = "ok";
            this.CriaGrafo.UseVisualStyleBackColor = true;
            this.CriaGrafo.Click += new System.EventHandler(this.CriaGrafo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NomeGrafo:";
            // 
            // nameGrafo
            // 
            this.nameGrafo.Location = new System.Drawing.Point(73, 3);
            this.nameGrafo.Name = "nameGrafo";
            this.nameGrafo.Size = new System.Drawing.Size(165, 20);
            this.nameGrafo.TabIndex = 9;
            this.nameGrafo.TextChanged += new System.EventHandler(this.nameGrafo_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.nameGrafo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 26);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // verticeLabel
            // 
            this.verticeLabel.AutoSize = true;
            this.verticeLabel.Location = new System.Drawing.Point(16, 102);
            this.verticeLabel.Name = "verticeLabel";
            this.verticeLabel.Size = new System.Drawing.Size(40, 13);
            this.verticeLabel.TabIndex = 17;
            this.verticeLabel.Text = "           ";
            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.linkLabel18);
            this.GroupMenu.Controls.Add(this.linkLabel16);
            this.GroupMenu.Controls.Add(this.linkLabel17);
            this.GroupMenu.Controls.Add(this.linkLabel15);
            this.GroupMenu.Controls.Add(this.linkLabel14);
            this.GroupMenu.Controls.Add(this.linkLabel13);
            this.GroupMenu.Controls.Add(this.linkLabel12);
            this.GroupMenu.Controls.Add(this.linkLabel11);
            this.GroupMenu.Controls.Add(this.linkLabel10);
            this.GroupMenu.Controls.Add(this.linkLabel9);
            this.GroupMenu.Controls.Add(this.linkLabel8);
            this.GroupMenu.Controls.Add(this.linkLabel7);
            this.GroupMenu.Controls.Add(this.linkLabel6);
            this.GroupMenu.Controls.Add(this.linkLabel5);
            this.GroupMenu.Controls.Add(this.linkLabel4);
            this.GroupMenu.Controls.Add(this.linkLabel3);
            this.GroupMenu.Controls.Add(this.linkLabel2);
            this.GroupMenu.Controls.Add(this.isAdj);
            this.GroupMenu.Enabled = false;
            this.GroupMenu.Location = new System.Drawing.Point(42, 146);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(610, 141);
            this.GroupMenu.TabIndex = 18;
            this.GroupMenu.TabStop = false;
            this.GroupMenu.Text = "Operações";
            // 
            // linkLabel18
            // 
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.Location = new System.Drawing.Point(524, 57);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(43, 13);
            this.linkLabel18.TabIndex = 20;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Conexo";
            // 
            // linkLabel16
            // 
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.Location = new System.Drawing.Point(414, 108);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(113, 13);
            this.linkLabel16.TabIndex = 15;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "OrdenaçãoTopológica";
            // 
            // linkLabel17
            // 
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.Location = new System.Drawing.Point(524, 29);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(60, 13);
            this.linkLabel17.TabIndex = 16;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Transposto";
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.Location = new System.Drawing.Point(414, 83);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(67, 13);
            this.linkLabel15.TabIndex = 14;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "GrauEntrada";
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Location = new System.Drawing.Point(414, 29);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(68, 13);
            this.linkLabel14.TabIndex = 13;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Hamiltoniano";
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Location = new System.Drawing.Point(289, 83);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(51, 13);
            this.linkLabel13.TabIndex = 12;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Euleriano";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(289, 108);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(51, 13);
            this.linkLabel12.TabIndex = 11;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Unicursal";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(164, 29);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(88, 13);
            this.linkLabel11.TabIndex = 10;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "VerificaPendente";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(166, 83);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(51, 13);
            this.linkLabel10.TabIndex = 9;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Completo";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(289, 29);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(48, 13);
            this.linkLabel9.TabIndex = 8;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Bipartido";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(414, 57);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(30, 13);
            this.linkLabel8.TabIndex = 7;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Ciclo";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(164, 108);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(43, 13);
            this.linkLabel7.TabIndex = 6;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Conexo";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(289, 57);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(74, 13);
            this.linkLabel6.TabIndex = 5;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Complementar";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(22, 108);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(76, 13);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "VerificaIsolado";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(164, 57);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(64, 13);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "VerificaNulo";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(22, 83);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(82, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = " VerificaRegular";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(22, 57);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "VerificaGrau";
            // 
            // isAdj
            // 
            this.isAdj.AutoSize = true;
            this.isAdj.Location = new System.Drawing.Point(22, 29);
            this.isAdj.Name = "isAdj";
            this.isAdj.Size = new System.Drawing.Size(95, 13);
            this.isAdj.TabIndex = 0;
            this.isAdj.TabStop = true;
            this.isAdj.Text = "VerificaAdjacência";
            this.isAdj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantidade vértices:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupMenu);
            this.Controls.Add(this.verticeLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CriaGrafo);
            this.Controls.Add(this.numVert);
            this.Name = "Form1";
            this.Text = "Grafo1.0";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.GroupMenu.ResumeLayout(false);
            this.GroupMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numVert;
        private System.Windows.Forms.Button CriaGrafo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameGrafo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label verticeLabel;
        private System.Windows.Forms.GroupBox GroupMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel18;
        private System.Windows.Forms.LinkLabel linkLabel16;
        private System.Windows.Forms.LinkLabel linkLabel17;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel isAdj;
    }
}

