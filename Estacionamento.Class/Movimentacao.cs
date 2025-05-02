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

        public Movimentacao()
        {

        }

        // Construtor que será utilizado na hora do Insert
        public Movimentacao(int idVeiculo)
        {
            IdVeiculo = idVeiculo;
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

        public static List<Object> ListaDoHistorico()
        {
            var cmd = Banco.Abrir();

            List<Object> listaHistorico = new();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select placa, modelo, situacao, data_entrada from  veiculos v  inner join  movimentacoes m on v.id = m.id_veiculo";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaHistorico.Add
                    (
                        (
                            dr.GetString(0),
                            dr.GetString(1),
                            dr.GetInt32(2),
                            dr.GetDateTime(3)
                        )
                    );
            }

            return listaHistorico;
        }
    }
}
