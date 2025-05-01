using Estacionamento.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Win
{
    public partial class FrmEntradaSaida : Form
    {
        public FrmEntradaSaida()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new(txtPlaca.Text, txtModelo.Text, cmbTipoVeiculo.SelectedIndex + 1);
            veiculo.Registrar();

            Movimentacao movimentacao = new(veiculo.Id);
            movimentacao.RegistrarEntrada();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Veiculo veiculo = new();
                var retorno = veiculo.BuscarPorPlaca(txtBuscar.Text);

                txtPlacaSaida.Text = retorno.Placa;
                txtModeloSaida.Text = retorno.Modelo;

                txtDataEntrada.Text = Movimentacao.BuscarMovimentacaoIdVeiculo(retorno.Id);
            }
        }

        private void FrmEntradaSaida_Load(object sender, EventArgs e)
        {

        }
    }
}
