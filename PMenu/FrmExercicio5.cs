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
    public partial class FrmExercicio5 : Form
    {
        int primNum;
        int segNum;


        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void txtPrimeiroNum_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtPrimeiroNum.Text, out primNum))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
        }

        private void txtSegundoNum_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSegundoNum.Text, out segNum))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double sorteio;
            if (primNum <= segNum)
            {
              
            sorteio = random.Next(primNum, segNum); // JAMAIS declarar variavel dentro de if
            }
            else
            {
            
            sorteio = random.Next(segNum, primNum);
            }
            if(primNum > segNum)
            {
                MessageBox.Show("O número sorteado é " + sorteio + "\nO primeiro número não é menor que o segundo");
            }
            else if(primNum < segNum)
            {
                MessageBox.Show("O número sorteado é " + sorteio + "\nO primeiro número é menor que o segundo");
            }
            else
            {
                MessageBox.Show("O número sorteado é " + sorteio + "\nO primeiro número é igual ao segundo");
            }
        }
    }
}
