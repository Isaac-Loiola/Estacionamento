using Estacionamento.Class;

namespace Estacionamento.Desk
{
    public partial class FrmVeiculo : Form
    {
        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void CarsFast_Load(object sender, EventArgs e)
        {
            int linha = 0;

            var veiculos = Veiculo.ListarVeiculosEstacionados();

            foreach (var lista in veiculos)
            {
                dgvVeiculos.Rows.Add();
                dgvVeiculos.Rows[linha].Cells[0].Value = lista.Placa;
                dgvVeiculos.Rows[linha].Cells[1].Value = lista.Modelo;
                dgvVeiculos.Rows[linha].Cells[2].Value = lista.TipoVeiculo == 1 ? "Carro" : "Moto";

                linha++;
            }
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Veiculo veiculo = new();
                var veiculoDeBusca = veiculo.BuscarPorPlaca(txtBuscar.Text);
                dgvVeiculos.Rows.Clear();

                dgvVeiculos.Rows.Add();
                dgvVeiculos.Rows[0].Cells[0].Value = veiculoDeBusca.Placa;
                dgvVeiculos.Rows[0].Cells[1].Value = veiculoDeBusca.Modelo;
                dgvVeiculos.Rows[0].Cells[2].Value = veiculoDeBusca.TipoVeiculo == 1? "Carro" : "Moto";
            }
        }
    }
}
