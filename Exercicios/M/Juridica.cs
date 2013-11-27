using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.SessionState;

namespace Exercicios.M
{
    public class Juridica:Pessoa
    {
        private String cnpj;

        public String CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public void setInDb()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Diego\\documents\\visual studio 2012\\Projects\\Exercicios\\Exercicios\\App_Data\\app_exercicios.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO pessoaJuridica (nome, cnpj, rua, numero, tipo, referencia) values(@nome, @cnpj, @rua, @numero,@tipo, @referencia)", conn);
            cmd.Parameters.AddWithValue("@nome", this.Nome);
            cmd.Parameters.AddWithValue("@cnpj", this.cnpj);
            cmd.Parameters.AddWithValue("@rua", this.Rua);
            cmd.Parameters.AddWithValue("@numero", this.Numero);
            cmd.Parameters.AddWithValue("@tipo", this.Tipo);
            cmd.Parameters.AddWithValue("@referencia", this.Referencia);
            conn.Open();
            int query = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public HttpCookie setInCookie()
        {
            HttpCookie cookie = new HttpCookie("pessoaJuridica");
            cookie.Values["nome"] = this.Nome;
            cookie.Values["rua"] = this.Rua;
            cookie.Values["numero"] = this.Numero.ToString();
            cookie.Values["cnpj"] = this.cnpj.ToString();
            cookie.Values["tipo"] = this.Tipo.ToString();
            cookie.Values["referencia"] = this.Referencia;
            return cookie;
        }
        public void setInSession(HttpSessionState sstate)
        {
            sstate["PJnome"] = this.Nome;
            sstate["PJrua"] = this.Rua;
            sstate["PJnumero"] = this.Numero.ToString();
            sstate["PJcnpj"] = this.cnpj.ToString();
            sstate["PJtipo"] = this.Tipo.ToString() ;
            sstate["PJreferencia"] = this.Referencia;


        }
        public void saveLocalStorage()
        {

        }
    }
    
}