namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbforma = new System.Windows.Forms.ComboBox();
            this.cmbtriangulo = new System.Windows.Forms.ComboBox();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblraio = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.txtraio);
            this.groupBox1.Controls.Add(this.txtaltura);
            this.groupBox1.Controls.Add(this.txtbase);
            this.groupBox1.Controls.Add(this.lblraio);
            this.groupBox1.Controls.Add(this.lblaltura);
            this.groupBox1.Controls.Add(this.lblbase);
            this.groupBox1.Controls.Add(this.cmbtriangulo);
            this.groupBox1.Controls.Add(this.cmbforma);
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FormasGeometricas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbforma
            // 
            this.cmbforma.FormattingEnabled = true;
            this.cmbforma.Items.AddRange(new object[] {
            "Circunferencia",
            "Quadrado",
            "Retangulo",
            "Triangulo"});
            this.cmbforma.Location = new System.Drawing.Point(33, 49);
            this.cmbforma.Name = "cmbforma";
            this.cmbforma.Size = new System.Drawing.Size(121, 21);
            this.cmbforma.TabIndex = 0;
            this.cmbforma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbtriangulo
            // 
            this.cmbtriangulo.FormattingEnabled = true;
            this.cmbtriangulo.Location = new System.Drawing.Point(160, 49);
            this.cmbtriangulo.Name = "cmbtriangulo";
            this.cmbtriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbtriangulo.TabIndex = 1;
            this.cmbtriangulo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(30, 86);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(31, 13);
            this.lblbase.TabIndex = 2;
            this.lblbase.Text = "Base";
            this.lblbase.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(30, 123);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "Altura";
            // 
            // lblraio
            // 
            this.lblraio.AutoSize = true;
            this.lblraio.Location = new System.Drawing.Point(30, 158);
            this.lblraio.Name = "lblraio";
            this.lblraio.Size = new System.Drawing.Size(29, 13);
            this.lblraio.TabIndex = 4;
            this.lblraio.Text = "Raio";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(65, 83);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(65, 120);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 6;
            // 
            // txtraio
            // 
            this.txtraio.Location = new System.Drawing.Point(65, 158);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(100, 20);
            this.txtraio.TabIndex = 7;
            this.txtraio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(305, 90);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(29, 13);
            this.lb.TabIndex = 1;
            this.lb.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perimetro";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(362, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(340, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbforma;
        private System.Windows.Forms.ComboBox cmbtriangulo;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblraio;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox textBox2;
    }
}

