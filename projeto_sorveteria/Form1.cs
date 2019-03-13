using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sorveteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct pedido
        {
            public int quantidade;
            public double total;
            public double preco;
            
        }

        public static int quantidade;
        public static double total;
        public static double preco = 2.75;
        public static double bolas;
        
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = preco * quantidade;
            txtTotal.Text = total.ToString();
        }

        private void cbxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantidade = int.Parse(cbxQuantidade.Text);
            total = preco * quantidade;
            txtTotal.Text = total.ToString();
        }

        private void cbxCreme_SelectedIndexChanged(object sender, EventArgs e)//combobox de seleção de bolas
        {
            if (cbxBolas.Text == "Creme")
            {
                bolas = 0.50;
            }
            else if (cbxBolas.Text == "Emerc")
            {
                bolas = 0.75;
            }
            else if (cbxBolas.Text == "Caramellow")
            {
                bolas = 0.25;
            }
            else if (cbxBolas.Text == "Wollemarac")
            {
                bolas = 0.47;
            }

            total = preco * quantidade + bolas;
            txtTotal.Text = total.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void cbxFlocos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
