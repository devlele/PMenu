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
    public partial class FrmExercicio3 : Form
    {
        string textoUm;
        string textoDois;

        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnReverter_Click(object sender, EventArgs e)
        {
            textoUm = txtPalavra1.Text;
            textoDois = txtPalavra2.Text;

            char[] vetor = textoUm.ToCharArray(); //cria um vetor e transforma a string
            Array.Reverse(vetor); // inverte o vetor 

            string textoInvert = new string(vetor); //cria uma nova string invertida
            MessageBox.Show(textoInvert);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            textoUm = txtPalavra1.Text;
            textoDois = txtPalavra2.Text;

            string resultado = textoDois.Replace(textoUm, "");

            MessageBox.Show(resultado);
        }
    }
}
