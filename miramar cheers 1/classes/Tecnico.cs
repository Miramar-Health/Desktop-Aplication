using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miramar_cheers_1.classes
{
    public class Tecnico
    {
        public int Id_Enfermeiro { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Categoria { get; set; }

        public string Coren { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public bool Situacao { get; set; }

        public string Instituicao { get; set; }

        public string Celular { get; set; }



        public Tecnico()
        {

        }
        public Tecnico(int _id_enfermeiro, int _id, string _nome, string _cpf, string _categoria, string _coren, string _email, string _senha, bool _situacao, string _instituicao, string _celular)
        {
            this.Id_Enfermeiro = _id_enfermeiro;
            this.Id = _id;
            this.Nome = _nome;
            this.Cpf = _cpf;
            this.Categoria = _categoria;
            this.Coren = _coren;
            this.Email = _email;
            this.Senha = _senha;
            this.Situacao = _situacao;
            this.Instituicao = _instituicao;
            this.Celular = _celular;

        }



        public Tecnico(string _nome)
        {
            this.Nome = _nome;
        }




        public bool Validar_Tecnico()
        {
            bool alterado = false;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_vend_update";
                comm.Parameters.Add("spsituacao", MySqlDbType.VarChar).Value = Situacao;
                comm.ExecuteNonQuery();
                comm.Connection.Close();
                alterado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return alterado;
        }



        public MySqlDataReader Listar_Tecnicos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from Tecnicos";
            var dr = comm.ExecuteReader();
            return dr;
        }



    }
}
