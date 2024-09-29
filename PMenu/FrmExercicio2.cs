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
    public partial class FrmExercicio2 : Form
    {
        string primPalavra;
        string segPalavra;
        int meio;
        string resultado;
        int metade;
        
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            primPalavra = txtPalavra1.Text;
            segPalavra = txtPalavra2.Text;
            if (string.Compare(primPalavra, segPalavra, true) == 0)
            {
                MessageBox.Show("Palavras iguais");
            }
            else
            {
                MessageBox.Show("Palavras diferetes");
            }
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            primPalavra = txtPalavra1.Text;
            segPalavra = txtPalavra2.Text;

            meio = segPalavra.Length / 2;
            resultado = segPalavra.Substring(0, meio) + primPalavra + segPalavra.Substring(meio);
            txtPalavra2.Text = resultado;
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            primPalavra = txtPalavra1.Text;

            metade = primPalavra.Length / 2;
            primPalavra = primPalavra.Insert(metade, "**");
            txtPalavra2.Text = primPalavra;
        }
    }
}
