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
        }
    }
}
