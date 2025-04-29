using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //Adicionamento métodos
        /// <summary>
        /// Método registra um veiculo ao banco de dados!
        /// </summary>
        public void Registrar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into veiculos(palaca, modelo, tipo_veiculo) " +
                              $"values('{Placa}', '{Modelo}', {TipoVeiculo})";
            cmd.ExecuteNonQuery();

            Id = Convert.ToInt32(cmd.CommandText = "select last_insert_id() from veiculos");
        }
    }
}
