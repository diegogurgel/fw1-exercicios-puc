using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Data.OleDb;
using Npgsql;


namespace Exercicios.M
{
    public class Fisica:Pessoa
    {


        private String cpf;

        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
        public void setInDb()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Diego\\documents\\visual studio 2012\\Projects\\Exercicios\\Exercicios\\App_Data\\app_exercicios.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO pessoaFisica (nome, cpf, rua, numero, tipo) values(@nome, @cpf, @rua, @numero,@tipo)",conn);
            cmd.Parameters.AddWithValue("@nome", this.Nome);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@rua", this.Rua);
            cmd.Parameters.AddWithValue("@numero", this.Numero);
            cmd.Parameters.AddWithValue("@tipo", this.Tipo);
            conn.Open();
            int query = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public HttpCookie setInCookie()
        {
            HttpCookie cookie = new HttpCookie("pessoaFisica");
            cookie.Values["nome"] = this.Nome;
            cookie.Values["rua"] = this.Rua;
            cookie.Values["numero"] = this.Numero.ToString();
            cookie.Values["cpf"] = this.cpf.ToString();
            cookie.Values["tipo"] = this.Tipo.ToString();
            cookie.Values["referencia"] = this.Referencia;
            return cookie;
        }
        public void setInSession(HttpSessionState sstate)
        {
            sstate["nome"] = this.Nome;
            sstate["rua"] = this.Rua;
            sstate["numero"] = this.Numero.ToString();
            sstate["cpf"] = this.cpf.ToString();
            sstate["tipo"] = this.Tipo.ToString();
            sstate["referencia"] = this.Referencia;
           

        }
        public void saveLocalStorage()
        {
           
        }

    }
}