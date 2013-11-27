using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Exercicios
{
    public partial class visualizar : System.Web.UI.Page
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

                if (Session["PJnome"] != null)
                {
                    lblNomeSession.Text = Session["PJnome"].ToString();
                    lblCPFSession.Text = Session["PJcnpj"].ToString();
                    lblRuaSession.Text = Session["PJrua"].ToString();
                    lblNumeroSession.Text = Session["PJnumero"].ToString();
                    lblTipoSession.Text = Session["PJtipo"].ToString();
                }
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                if (Request.Params["show"] != "all" && Request.Params["show"] != null)
                {
                    cmd.CommandText = "SELECT * FROM pessoaJuridica where cnpj=@cnpj ORDER BY id desc";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@cnpj", Request.Params["show"]);

                }
                else
                {
                    cmd.CommandText = "SELECT * FROM pessoaJuridica ORDER BY id desc";
                    cmd.Connection = conn;

                }
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                a.Fill(ds);
                GridView2.DataSource = ds;
                GridView2.DataBind();
                conn.Close();

               

            

            }
            else
            {

                GridView1.Visible = true;
                GridView2.Visible = false;
                if (Request.Cookies["pessoaFisica"] != null)
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
                SqlCommand cmd = new SqlCommand();
                if (Request.Params["show"] != "all" && Request.Params["show"]!=null)
                {
                    cmd.CommandText="SELECT * FROM pessoaFisica where cpf=@cpf ORDER BY id desc";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@cpf", Request.Params["show"]);

                }
                else
                {
                    cmd.CommandText = "SELECT * FROM pessoaFisica ORDER BY id desc";
                    cmd.Connection = conn;

                }
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
 

            GridView1.DataBind();

        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)

        {
            GridView2.PageIndex = e.NewPageIndex;


            GridView2.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void btnEditarCookie_Click(object sender, EventArgs e)
        {
            string cad =  Request.Params["cad"];
            if (cad == "pj")
            {

                Response.Redirect("editForm.aspx?cad=pj&edit=true&storage=cookie");
            }
            else
            {
                Response.Redirect("editForm.aspx?cad=pf&edit=true&storage=cookie");
            }
        }

        protected void btnEditarSession_Click(object sender, EventArgs e)
        {
            string cad = Request.Params["cad"];
            if (cad == "pj")
            {

                Response.Redirect("editForm.aspx?cad=pj&edit=true&storage=session");
            }
            else
            {
                Response.Redirect("editForm.aspx?cad=pf&edit=true&storage=session");
            }
        }

        protected void btnEditarSession_Click1(object sender, EventArgs e)
        {
            string cad = Request.Params["cad"];
            if (cad == "pj")
            {

                Response.Redirect("editForm.aspx?cad=pj&edit=true&storage=session");
            }
            else
            {
                Response.Redirect("editForm.aspx?cad=pf&edit=true&storage=session");
            }

        }


        }
    }
