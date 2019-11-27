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

        public int Id_tecnico { get; set; }

        public string Nome { get; set; }

        public string Local_Ferida { get; set; }

        public string Descricao_Inicial_Ferida { get; set; }

        public DateTime Data_Cadastro { get; set; }

        Banco db = new Banco();

        public Paciente()
        {

        }
       
        public Paciente(int _id_tec,int _id, string _nome, string _local_ferida, string _descricao_inicial_ferida,DateTime _data_cadastro)
        {
            this.Id = _id;
            this.Id_tecnico = _id_tec;
            this.Nome = _nome;
            this.Local_Ferida = _local_ferida;
            this.Descricao_Inicial_Ferida = _descricao_inicial_ferida;
            this.Data_Cadastro = _data_cadastro;
           

         

        }


        public Paciente(string _nome)
        {
            this.Nome = _nome;
        }





        public void Buscar_Paciente(int id)
        {

            var comm = db.Conectar();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "select * from paciente where id_paciente =" + id;
            comm.Parameters.Add("id", MySqlDbType.Int32).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.Id = dr.GetInt32(0);
                this.Nome = dr.GetString(1);
                this.Local_Ferida = dr.GetString(2);
                this.Descricao_Inicial_Ferida = dr.GetString(3);
                this.Data_Cadastro = dr.GetDateTime(4);
                this.Id_tecnico = dr.GetInt32(5);
            }
            comm.Connection.Close();
        }





        public MySqlDataReader Listar_Pacientes()
        {
           var comm = db.Conectar();
            comm.CommandText = "select * from paciente";
            var dr = comm.ExecuteReader();
            return dr;
        }






    }
}
