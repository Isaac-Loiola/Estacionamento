using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Class
{
    public class Veiculo
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

        public Veiculo(int id, string placa, string modelo, int tipoVeiculo)
        {
            Id = id;
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

            cmd.CommandText = "select id from veiculos order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public Veiculo BuscarPorPlaca(string placa)
        {
            Veiculo veiculo = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from veiculos where placa = {placa}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                veiculo = new
                (
                    Id = dr.GetInt32(0),
                    Placa = dr.GetString(1),
                    Modelo = dr.GetString(2),
                    TipoVeiculo = dr.GetInt32(3) 
                );
            }

            return veiculo;
        }


    }
}
