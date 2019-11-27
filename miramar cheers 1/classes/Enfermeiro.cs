using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using miramar_cheers_1.formularios;
using miramar_cheers_1.classes;

namespace miramar_cheers_1
{
    public class Enfermeiro
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

        Banco db = new Banco();

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



        public bool Efetuar_Login(string coren, string senha)
        {
            bool Result = false;
            var comm = db.Conectar();
            try
            {
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "select * from enfermeiro where coren =" + coren+" && senha="+senha;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    UserLoginCache.Nome_Tecnico= dr.GetString(1);
                    UserLoginCache.Email_Tecnico = dr.GetString(5);
                    UserLoginCache.Coren_Tecnico = dr.GetString(4);
                    UserLoginCache.Situacao_Tecnico = dr.GetBoolean(7);
                    Result = true;
                }
                

            }
            catch (Exception)
            {
            }
            finally
            {
                comm.Connection.Close();
            }
            {

                return Result;
            }

        }

        public void Buscar_enfermeiro()
        {


            var comm = db.Conectar();
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "select * from enfermeiro where coren =" + UserLoginCache.Coren_Tecnico;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.Nome = dr.GetString(1);
                this.Email = dr.GetString(5);
                this.Coren = dr.GetString(4);
                this.Situacao = dr.GetBoolean(7);
            }
            comm.Connection.Close();
        }




    }

}
