using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CUEntidad;
using CULogica;
using CUDatos;

namespace Programa_de_Conversiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CBHertz.SelectedIndex = 0;
            CBSegs.SelectedIndex = 0;
        }

        public double CalcularResultadoSegs(double primerNum, int opcion)
        {
            double resultado = 0;
            switch (CBSegs.SelectedIndex)
            {
                case 0:
                    resultado = CDatos.ConversorDeSegundos(primerNum, opcion);
                    break;
                case 1:
                    resultado = CDatos.ConversorDeMilisegundos(primerNum, opcion);
                    break;
                case 2:
                    resultado = CDatos.ConversorDeMicrosegundos(primerNum, opcion);
                    break;
                case 3:
                    resultado = CDatos.ConversorDeNanosegundos(primerNum, opcion);
                    break;
                case 4:
                    resultado = CDatos.ConversorDePicosegundos(primerNum, opcion);
                    break;
            }
            return resultado;
        }
        public double CalcularResultadoHertz(double primerNum, int opcionH, int opcionS)
        {
            double resultado = 0;
            resultado = CDatos.ConversorDeFrecuencia(CDatos.ConversorDeHertz(primerNum, opcionH), opcionS);
            return resultado;        
        }

        private void txtSegs_TextChanged(object sender, EventArgs e)
        {
            if(txtSegs.Text != string.Empty)
            {
                if (txtSegs.Text != ".")
                    txtHertz.Text = CalcularResultadoSegs(double.Parse(txtSegs.Text), CBHertz.SelectedIndex + 1).ToString();
            }
            else
                txtSegs.Text = string.Empty;
        }

        private void txtHertz_TextChanged(object sender, EventArgs e)
        {
            if (txtHertz.Text != string.Empty)
            {
                if (txtHertz.Text != ".")
                    txtSegs.Text = CalcularResultadoHertz(double.Parse(txtHertz.Text), CBHertz.SelectedIndex + 1, CBSegs.SelectedIndex + 1).ToString();
            }
            else
                txtHertz.Text = string.Empty;
        }

        private void CBHertz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtHertz.Text != string.Empty)
            {
                if(txtHertz.Text != ".")
                    txtSegs.Text = CalcularResultadoHertz(double.Parse(txtHertz.Text), CBHertz.SelectedIndex + 1, CBSegs.SelectedIndex + 1).ToString();
            }
            else
                txtHertz.Text = string.Empty;
        }

        private void CBSegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (txtSegs.Text != string.Empty)
            {
                if (txtSegs.Text != ".")
                    txtHertz.Text = CalcularResultadoSegs(double.Parse(txtSegs.Text), CBHertz.SelectedIndex + 1).ToString();
            }
            else
                txtSegs.Text = string.Empty;
        }

        private void txtSegs_KeyPress(object sender, KeyPressEventArgs e)
        {
            CLogica.SoloNums(sender, e);
        }

        private void txtHertz_KeyPress(object sender, KeyPressEventArgs e)
        {
            CLogica.SoloNums(sender, e);
        }
    }
}
