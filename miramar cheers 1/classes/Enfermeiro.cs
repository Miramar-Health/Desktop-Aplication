using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miramar_cheers_1
{
    class Enfermeiro
    {


        public int Id { get; set;}
        public string Nome { get; set;}

        public string Cpf { get; set;}

        public string Categoria { get; set;}

        public string Coren { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public bool Situacao { get; set; }

        public string Instituicao { get; set;}



        public Enfermeiro()
        {

        }
        public Enfermeiro(int _id, string _nome, string _cpf, string _categoria, string _coren, string _email, string _senha, bool _situacao, string _instituicao  )
        {
            this.Id = _id;
            this.Nome = _nome;
            this.Cpf = _cpf;
            this.Categoria = _categoria;
            this.Coren = _coren;
            this.Email = _email;
            this.Senha = _senha;
            this.Situacao = _situacao;
            this.Instituicao = _instituicao;
           
        }


        public Enfermeiro(string _nome)
        {
            this.Nome = _nome;
        }



        public bool Efetuar_Login(string _core,string _senha)
        {
            var comm = Banco.Abrir();
            try
            {
                comm.CommandText = "select * from enfermeiro where coren = '" + _core + "' && senha = '" + _senha + "'";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Coren = dr.GetString(0);
                    this.Senha = dr.GetString(1);                   
                }
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }            
            finally
            {
                comm.Connection.Close();
            }
        }



    }

}
