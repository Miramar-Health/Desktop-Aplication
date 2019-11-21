using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miramar_cheers_1.classes
{
     public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Local_Ferida { get; set; }

        public string Descricao_Inicial_Ferida { get; set; }

        public DateTime Data_Cadastro { get; set; }

        public int Id_End { get; set; }
       



        public Paciente()
        {

        }
        public Paciente(int _id, string _nome, string _local_ferida, string _descricao_inicial_ferida,DateTime _data_cadastro, int _id_end)
        {
            this.Id = _id;
            this.Nome = _nome;
            this.Local_Ferida = _local_ferida;
            this.Descricao_Inicial_Ferida = _descricao_inicial_ferida;
            this.Data_Cadastro = _data_cadastro;
            this.Id_End = _id_end;
         

        }


        public Paciente(string _nome)
        {
            this.Nome = _nome;
        }





        public void Buscar_Paciente(int id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_pacientes";
            comm.Parameters.Add("spid_pacientes", MySqlDbType.Int32).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.Id = dr.GetInt32(0);
                this.Nome = dr.GetString(1);
                this.Local_Ferida = dr.GetString(2);
                this.Descricao_Inicial_Ferida = dr.GetString(3);
                this.Data_Cadastro = dr.GetDateTime(4);
                this.Id_End = dr.GetInt32(5);
            }
            comm.Connection.Close();
        }



        public MySqlDataReader Listar_Pacientes()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from Pacientes";
            var dr = comm.ExecuteReader();
            return dr;
        }






    }
}
