using Estacionamento.Class;
using Estacionamento.Desk;
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
            Veiculo veiculo = new(txtPlaca.Text, txtModelo.Text, this.cmbTipoVeiculo.SelectedIndex + 1);
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

                txtIdVeiculo.Text = Convert.ToString((retorno.Id));

                txtDataEntrada.Text = Convert.ToString(Movimentacao.BuscarMovimentacaoIdVeiculo(retorno.Id));
            }
        }

        private void FrmEntradaSaida_Load(object sender, EventArgs e)
        {
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            // Registrando a saída e guardando na variavel.
            DateTime horarioSaida = Movimentacao.RegistrarSaida(Convert.ToInt32(txtIdVeiculo.Text));

            // Exibindo horario de saída no TextBox
            txtDataSaida.Text = Convert.ToString(horarioSaida);

            // Busca a data que o veiculo estacionou
            DateTime diferencaEntradaSaida = Movimentacao.BuscarMovimentacaoIdVeiculo(Convert.ToInt32(txtIdVeiculo.Text));

            // Subtraindo horario de entrada e saida para obter diferença de horario.
            var horarioCobranca = (horarioSaida - diferencaEntradaSaida);

            // Utilizando essa verificação porque caso o veiculo fique menos de um dia, o formato do TimesPan é diferente.

            // ex: Veiculo que estacionou por dias: dias:horas:minutos:segundos
            // ex: Veiculo que estacionou por horas: horas:minutos:segundos
            if (Convert.ToString(horarioCobranca).Length < 10)
            {
                double horas = Convert.ToInt32(horarioCobranca.ToString().Substring(0, 2));

                if (horas == 0)
                {
                    txtValor.Text = $"R$: 5,00";
                    Movimentacao.RegistrarValor(Convert.ToInt32(txtIdVeiculo.Text), 5);
                }
                else
                {
                    MessageBox.Show($"O veiculo pernaneceu estacionado por {horas} horas.");
                    double valorEstacionado = horas * 5;

                    Movimentacao.RegistrarValor(Convert.ToInt32(txtIdVeiculo.Text), valorEstacionado);

                    txtValor.Text = $"R$: {valorEstacionado},00";

                }
            }
            else
            {
                // Código para veiculos que passaram dias estacionados:

                // Isolando o dia e hora do veiculo estacionado!
                int dia = Convert.ToInt32(horarioCobranca.ToString().Substring(0, 1));
                int hora = Convert.ToInt32(horarioCobranca.ToString().Substring(2, 2));

                // Variavel que multiplica horarios e entrega valor a ser pago. (R$: 5,00 / hora)
                double valorEstacionado = (dia * 24 * 5) + (hora * 5);

                if (dia > 0)
                {
                    MessageBox.Show($"O veiculo permaneceu no estacionamento por {dia} dia/s e {hora} horas.");
                }
                else
                {
                    MessageBox.Show($"O veiculo pernaceu no estacionamento por {hora} horas.");
                }

                txtValor.Text = $"R$: {valorEstacionado},00";

                Movimentacao.RegistrarValor(Convert.ToInt32(txtIdVeiculo.Text), valorEstacionado);
            }


        }

        private void trintaminuts_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            FrmVeiculo frmVeiculo = new();
            frmVeiculo.Show();
            this.Hide();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmHistorico frmHistorico = new();
            frmHistorico.Show();
            this.Hide();
        }
    }
}
