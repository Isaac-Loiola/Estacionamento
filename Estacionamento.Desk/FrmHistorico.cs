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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            int linha = 0;
            var listaDehistorico = Movimentacao.ListaDeHistorico();
            
            foreach(var historico in listaDehistorico)
            {
                dgvHistorico.Rows.Add();
                dgvHistorico.Rows[linha].Cells[0].Value = historico.IdVeiculo;
                dgvHistorico.Rows[linha].Cells[1].Value = historico.DataEntrada;
                dgvHistorico.Rows[linha].Cells[2].Value = historico.DataSaida;
                dgvHistorico.Rows[linha].Cells[3].Value = historico.Situacao == 0? "Finalizado" : "Estacionado";

                linha++;
            }
        }
    }
}
