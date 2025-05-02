using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Class
{
    public class Movimentacao
    {

        public int Id { get;set; }
        public int IdVeiculo { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int Situacao { get; set; }

        public Movimentacao()
        {

        }

        // Construtor que será utilizado na hora do Insert
        public Movimentacao(int idVeiculo)
        {
            IdVeiculo = idVeiculo;
        }

        public Movimentacao(int idVeiculo, DateTime dataEntrada, DateTime dataSaida, int situacao)
        {
            IdVeiculo = idVeiculo;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Situacao = situacao;
           
        }


        public void RegistrarEntrada()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into movimentacoes(id_veiculo,  situacao) " +
                              $"values({IdVeiculo}, 1)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select id from movimentacoes order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "select data_entrada from movimentacoes order by id desc limit 1";
            DataEntrada = Convert.ToDateTime(cmd.ExecuteScalar());
        }

        public static DateTime RegistrarSaida(int idVeiculo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update movimentacoes set data_saida = current_timestamp(), situacao = 0 where id_veiculo = 1";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"select data_saida from movimentacoes where id_veiculo = {idVeiculo}";
            return Convert.ToDateTime(cmd.ExecuteScalar());
        }

        public static DateTime BuscarMovimentacaoIdVeiculo(int idVeiculo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select data_entrada from movimentacoes where id_veiculo = {idVeiculo}";
            DateTime dataEntrada = Convert.ToDateTime(cmd.ExecuteScalar());

            return dataEntrada;
        }

        public static List<Movimentacao> ListaDeHistorico()
        {
            var cmd = Banco.Abrir();

            List<Movimentacao> listaHistorico = new();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id_veiculo, data_entrada, data_saida, situacao from movimentacoes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaHistorico.Add
                    (
                        new(
                            dr.GetInt32(0),
                            dr.GetDateTime(1),
                            dr.GetDateTime(2),
                            dr.GetInt32(3)
                        )
                    );
            }

            return listaHistorico;
        }
    }
}
