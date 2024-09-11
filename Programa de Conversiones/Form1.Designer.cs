namespace Programa_de_Conversiones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBSegs = new System.Windows.Forms.ComboBox();
            this.CBHertz = new System.Windows.Forms.ComboBox();
            this.txtSegs = new System.Windows.Forms.TextBox();
            this.txtHertz = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBSegs
            // 
            this.CBSegs.FormattingEnabled = true;
            this.CBSegs.Items.AddRange(new object[] {
            "Segundos(s)",
            "Milisegundos(ms)",
            "Microsegundos(μ)",
            "Nanosegundos(ns)",
            "Picosegundos(ps)"});
            this.CBSegs.Location = new System.Drawing.Point(7, 29);
            this.CBSegs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBSegs.Name = "CBSegs";
            this.CBSegs.Size = new System.Drawing.Size(156, 32);
            this.CBSegs.TabIndex = 0;
            // 
            // CBHertz
            // 
            this.CBHertz.FormattingEnabled = true;
            this.CBHertz.Items.AddRange(new object[] {
            "Hercio(Hz)",
            "Kilohercio(kHz)",
            "Megahercio(MHz)",
            "Gigahercio(GHz)",
            "Terahercio(THz)"});
            this.CBHertz.Location = new System.Drawing.Point(7, 30);
            this.CBHertz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBHertz.Name = "CBHertz";
            this.CBHertz.Size = new System.Drawing.Size(156, 32);
            this.CBHertz.TabIndex = 1;
            // 
            // txtSegs
            // 
            this.txtSegs.Location = new System.Drawing.Point(223, 29);
            this.txtSegs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegs.Name = "txtSegs";
            this.txtSegs.Size = new System.Drawing.Size(272, 30);
            this.txtSegs.TabIndex = 2;
            this.txtSegs.TextChanged += new System.EventHandler(this.txtSegs_TextChanged);
            // 
            // txtHertz
            // 
            this.txtHertz.Location = new System.Drawing.Point(223, 30);
            this.txtHertz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHertz.Name = "txtHertz";
            this.txtHertz.Size = new System.Drawing.Size(272, 30);
            this.txtHertz.TabIndex = 3;
            this.txtHertz.TextChanged += new System.EventHandler(this.txtHertz_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSegs);
            this.groupBox1.Controls.Add(this.CBSegs);
            this.groupBox1.Location = new System.Drawing.Point(56, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segundos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHertz);
            this.groupBox2.Controls.Add(this.CBHertz);
            this.groupBox2.Location = new System.Drawing.Point(56, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hercios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hercios y Segundos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSegs;
        private System.Windows.Forms.ComboBox CBHertz;
        private System.Windows.Forms.TextBox txtSegs;
        private System.Windows.Forms.TextBox txtHertz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

