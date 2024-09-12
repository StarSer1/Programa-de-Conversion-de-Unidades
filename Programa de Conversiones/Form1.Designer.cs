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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBSegs = new System.Windows.Forms.ComboBox();
            this.CBHertz = new System.Windows.Forms.ComboBox();
            this.txtSegs = new System.Windows.Forms.TextBox();
            this.txtHertz = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBSegs
            // 
            this.CBSegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.CBSegs.FormattingEnabled = true;
            this.CBSegs.Items.AddRange(new object[] {
            "Segundos(s)",
            "Milisegundos(ms)",
            "Microsegundos(μ)",
            "Nanosegundos(ns)",
            "Picosegundos(ps)"});
            this.CBSegs.Location = new System.Drawing.Point(7, 29);
            this.CBSegs.Margin = new System.Windows.Forms.Padding(4);
            this.CBSegs.Name = "CBSegs";
            this.CBSegs.Size = new System.Drawing.Size(156, 26);
            this.CBSegs.TabIndex = 0;
            this.CBSegs.SelectedIndexChanged += new System.EventHandler(this.CBSegs_SelectedIndexChanged);
            // 
            // CBHertz
            // 
            this.CBHertz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.CBHertz.FormattingEnabled = true;
            this.CBHertz.Items.AddRange(new object[] {
            "Hercio(Hz)",
            "Kilohercio(kHz)",
            "Megahercio(MHz)",
            "Gigahercio(GHz)",
            "Terahercio(THz)"});
            this.CBHertz.Location = new System.Drawing.Point(7, 30);
            this.CBHertz.Margin = new System.Windows.Forms.Padding(4);
            this.CBHertz.Name = "CBHertz";
            this.CBHertz.Size = new System.Drawing.Size(156, 26);
            this.CBHertz.TabIndex = 1;
            this.CBHertz.SelectedIndexChanged += new System.EventHandler(this.CBHertz_SelectedIndexChanged);
            // 
            // txtSegs
            // 
            this.txtSegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.txtSegs.Location = new System.Drawing.Point(223, 29);
            this.txtSegs.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegs.Name = "txtSegs";
            this.txtSegs.Size = new System.Drawing.Size(272, 26);
            this.txtSegs.TabIndex = 2;
            this.txtSegs.TextChanged += new System.EventHandler(this.txtSegs_TextChanged);
            this.txtSegs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegs_KeyPress);
            // 
            // txtHertz
            // 
            this.txtHertz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.txtHertz.Location = new System.Drawing.Point(223, 30);
            this.txtHertz.Margin = new System.Windows.Forms.Padding(4);
            this.txtHertz.Name = "txtHertz";
            this.txtHertz.Size = new System.Drawing.Size(272, 26);
            this.txtHertz.TabIndex = 3;
            this.txtHertz.TextChanged += new System.EventHandler(this.txtHertz_TextChanged);
            this.txtHertz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHertz_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSegs);
            this.groupBox1.Controls.Add(this.CBSegs);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(56, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segundos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtHertz);
            this.groupBox2.Controls.Add(this.CBHertz);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(56, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hercios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONVERSOR DE HERCIOS Y SEGUNDOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programa_de_Conversiones.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(615, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSegs;
        private System.Windows.Forms.ComboBox CBHertz;
        private System.Windows.Forms.TextBox txtSegs;
        private System.Windows.Forms.TextBox txtHertz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

