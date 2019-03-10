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

        public static double dinheiro;
        public static double quantidade;
        
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "Morango")
            {
                double.Parse(txtTotal.Text += 1.50);
            }
            else if (cbxTipo.Text == "Chocolate")
            {
                double.Parse(txtTotal.Text += 1.50);
            }
            else if (cbxTipo.Text == "Maçã")
            {
                double.Parse(txtTotal.Text += 2.00);
            }
            else if (cbxTipo.Text == "Cenoura")
            {
                double.Parse(txtTotal.Text += 3.50);
            }
            else if (cbxTipo.Text == "Sabão")
            {
                double.Parse(txtTotal.Text += 5.00);
            }
            else if (cbxTipo.Text == "Pneu usado")
            {
                double.Parse(txtTotal.Text += 7.50);
            }
            else if (cbxTipo.Text == "Maracujá")
            {
                double.Parse(txtTotal.Text += 2.50);
            }
            else if (cbxTipo.Text == "Flocos")
            {
                double.Parse(txtTotal.Text += 2.50);
            }
            else if (cbxTipo.Text == "Aquele bagui azul lá")
            {
                double.Parse(txtTotal.Text += 3.50);
            }
        }

        private void cbxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotal.Text);//variável que armazena o valor do textbox Total

            if (cbxQuantidade.Text == "1")
            {
                quantidade = double.Parse(cbxQuantidade.Text);
                double.Parse(txtTotal.Text) *= double.Parse(txtTotal.Text);
            }

        }
    }
}
