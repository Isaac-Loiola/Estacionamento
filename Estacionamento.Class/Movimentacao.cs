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


    }
}
