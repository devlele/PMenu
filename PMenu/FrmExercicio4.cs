using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class FrmExercicio4 : Form
    {
        string texto;

        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContNum_Click(object sender, EventArgs e)
        {
            texto = richTxtTexto.Text;

            texto = texto.Trim();
            int comprimento = texto.Length;
            int contNum = 0;
            int cont = 0;
            char[] vetor = texto.ToCharArray();

            while (cont < comprimento)
            {
                if (Char.IsNumber(vetor[cont]))
                {
                    contNum++;
                }
                cont++;
            }

            MessageBox.Show("O texto possui " + contNum + " números");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            texto = richTxtTexto.Text;

            texto = texto.Trim();
            char[] vetor = texto.ToCharArray();
            int comprimento = texto.Length;

            for (int i = 0; i < comprimento; i++)
            {
                if (char.IsWhiteSpace(vetor[i]))
                {
                    i += 1;
                    MessageBox.Show("O primeiro caracter em branco está na posição " + i);
                    break;
                }
            }
        }

        private void btnContLetra_Click(object sender, EventArgs e)
        {
            texto = richTxtTexto.Text;

            char[] vetor = texto.ToCharArray();
            int contLetra = 0;

            foreach(char c in texto)
            {
                if (char.IsLetter(c))
                {
                    contLetra++;
                }
            }

            MessageBox.Show("O número de letras é " + contLetra);
        }
    }
}
