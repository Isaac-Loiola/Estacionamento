using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Class
{
    class Veiculo
    {
        int Id { get; set; }
        string Placa { get; set; }
        string Modelo { get; set; }
        int TipoVeiculo { get; set; }

        //Adicionando construtores que serão necessarios na hora do insert.
        public Veiculo()
        {

        }

        public Veiculo(string placa, string modelo, int tipoVeiculo)
        {
            Placa = placa;
            Modelo = modelo;
            TipoVeiculo = tipoVeiculo;
        }


    }
}
