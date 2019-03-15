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

        public struct pedido//Estrutura da comanda
        {
            public int quantidade;
            public double total;
            public double preco;
            public double bolas;
            public double flocos;
            
        }

        //variaveis de configuração de comanda
        public static int quantidade;
        public static double total;
        public static double precoSorvete = 2.75;
        public static double precoBolas;
        public static double precoFlocos;
        public static double precoCobertura;
        public static double dinheiro;

        
        //caixa de seleção do tipo
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = precoSorvete * quantidade;
            txtTotal.Text = total.ToString();
        }

        //quantidade de sorvetes a serem feitos
        private void cbxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantidade = int.Parse(cbxQuantidade.Text);
            total = precoSorvete * quantidade;
            txtTotal.Text = total.ToString();
        }

        //configuração de bolas de sorvetes
        private void cbxCreme_SelectedIndexChanged(object sender, EventArgs e)//combobox de seleção de bolas
        {
            if (cbxBolas.Text == "Creme")
            {
                precoBolas = 0.50;
            }
            else if (cbxBolas.Text == "Emerc")
            {
                precoBolas = 0.75;
            }
            else if (cbxBolas.Text == "Caramellow")
            {
                precoBolas = 0.25;
            }
            else if (cbxBolas.Text == "Wollemarac")
            {
                precoBolas = 0.47;
            }
            else
            {
                precoBolas = 0;
            }

            total = precoSorvete * quantidade + precoBolas;
            txtTotal.Text = total.ToString();//exibe o total
        }

        //Janela de notificação de pagamento
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if ((dinheiro < total) || (dinheiro <= 0))
            {
                MessageBox.Show("Dinheiro insuficiente!");
            }
            else
            {
                if (MessageBox.Show("Confirmar Pagamento?\nR$ " + total, "Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    double troco = dinheiro - total;//variável de cálculo de troco

                    this.Close();

                    MessageBox.Show("Pago com sucesso!\nTroco: " + troco, "Pagamento");
                }

            }

        }

        //Seleção de Flocos
        private void cbxFlocos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFlocos.Text == null)
            {
                precoFlocos = 0;//Se a caixa de seleção não estiver vazia, a variavel armazenará o valor contido na mesma
            }
            else
            {
                precoFlocos = 0.20;
            }

            total = precoSorvete * quantidade + precoBolas + precoFlocos;
            txtTotal.Text = total.ToString();
        }

        //seleção de cobertura
        private void cbxCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFlocos.Text == null)
            {
                precoCobertura = 0;//Se a caixa de seleção não estiver vazia, a variavel armazenará o valor contido na mesma
            }
            else
            {
                precoCobertura = 0.20;
            }

            total = precoSorvete * quantidade + precoBolas + precoFlocos + precoCobertura;
            txtTotal.Text = total.ToString();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            dinheiro = double.Parse(txtDinheiro.Text);                  
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
