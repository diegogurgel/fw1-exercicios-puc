using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Exercicios
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cad"] == "pj")
            {
                GridView1.Visible = false;
                GridView2.Visible = true;

                if (Request.Cookies["pessoaJuridica"] != null)
                {
                    lblNome.Text = Request.Cookies["pessoaJuridica"]["nome"].ToString();
                    lblCPFCNPJ.Text = Request.Cookies["pessoaJuridica"]["cnpj"].ToString();
                    lblRua.Text = Request.Cookies["pessoaJuridica"]["rua"].ToString();
                    lblNumero.Text = Request.Cookies["pessoaJuridica"]["numero"].ToString();
                    lblTipo.Text = Request.Cookies["pessoaJuridica"]["tipo"].ToString();
                }

                if (Session["nome"] != null)
                {
                    lblNomeSession.Text = Session["PJnome"].ToString();
                    lblCPFSession.Text = Session["PJcpf"].ToString();
                    lblRuaSession.Text = Session["PJrua"].ToString();
                    lblNumeroSession.Text = Session["PJnumero"].ToString();
                    lblTipoSession.Text = Session["PJtipo"].ToString();
                }
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM pessoaJuridica",conn);
                conn.Open();
                GridView2.DataSource  = cmd.ExecuteReader();
                GridView2.DataBind();
                conn.Close();

               

            

            }
            else
            {

                GridView1.Visible = true;
                GridView2.Visible = false;
                if (Request.Cookies["pessoaFisica"]["cpf"] != null)
                {
                    lblNome.Text = Request.Cookies["pessoaFisica"]["nome"].ToString();
                    lblCPFCNPJ.Text = Request.Cookies["pessoaFisica"]["cpf"].ToString();
                    lblRua.Text = Request.Cookies["pessoaFisica"]["rua"].ToString();
                    lblNumero.Text = Request.Cookies["pessoaFisica"]["numero"].ToString();
                    lblTipo.Text = Request.Cookies["pessoaFisica"]["tipo"].ToString();
                }

                if (Session["nome"] != null)
                {
                    lblNomeSession.Text = Session["nome"].ToString();
                    lblCPFSession.Text = Session["cpf"].ToString();
                    lblRuaSession.Text = Session["rua"].ToString();
                    lblNumeroSession.Text = Session["numero"].ToString();
                    lblTipoSession.Text = Session["tipo"].ToString();
                }
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

                SqlCommand cmd = new SqlCommand("SELECT * FROM pessoaFisica", conn);
                conn.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                conn.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}