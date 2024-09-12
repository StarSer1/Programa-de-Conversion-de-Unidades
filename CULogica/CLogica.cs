using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CULogica
{
    public class CLogica
    {
        public static void SoloNums(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verificar si el carácter es un número, la tecla de retroceso o un punto
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' ||
                (e.KeyChar == '.' && !textBox.Text.Contains('.'))))
            {
                e.Handled = true;  // Bloquear cualquier otro carácter
            }
        }
    }
}
