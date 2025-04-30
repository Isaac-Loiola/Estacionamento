using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Class
{
    public class Movimentacao
    {

        int Id { get;set; }
        int IdVeiculo { get; set; }
        DateTime DataEntrada { get; set; }
        DateTime DataSaida { get; set; }
        int Situacao { get; set; }

        // Construtor que será utilizado na hora do Insert
        public Movimentacao(int idVeiculo, DateTime dataEntrada, DateTime dataSaida, int situacao)
        {
            IdVeiculo = idVeiculo;
            DataSaida = dataSaida;
            Situacao = situacao;
        }

        public void RegistrarEntrada()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into movimentacoes(id_veiculo, data_saida, situacao) " +
                              $"values({IdVeiculo}, '{DataSaida}', 1)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select id from movimentacoes order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "select data_entrada from movimentacoes order by id desc limit 1";
            DataEntrada = Convert.ToDateTime(cmd.ExecuteScalar());
        }

        public void RegistrarSaida(int idVeiculo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update movimentacoes set data_saida = current_timestamp() and situacao = 0 where placa =  {idVeiculo}";
        }
    }
}
