using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios
{
    public partial class editForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CadastroPF.aspx?cad=pj&edit=true&storage=cookie
            if (!IsPostBack)
            {
                if (Request.Params["storage"] == "cookie" & Request.Params["cad"] == "pf")
                {
                    listaPersistencia.SelectedIndex = 0;
                    tbxNome.Text = Request.Cookies["pessoaFisica"]["nome"].ToString();
                    tbxCPFCNPJ.Text = Request.Cookies["pessoaFisica"]["cpf"].ToString();
                    tbxRua.Text = Request.Cookies["pessoaFisica"]["rua"].ToString();
                    tbxNumero.Text = Request.Cookies["pessoaFisica"]["numero"].ToString();
                    ddwTipo.SelectedIndex = Int32.Parse(Request.Cookies["pessoaFisica"]["tipo"]);
                    tbxRef.Text = Request.Cookies["pessoaFisica"]["referencia"].ToString();
                }
                if (Request.Params["storage"] == "cookie" & Request.Params["cad"] == "pj")
                {
                    listaPersistencia.SelectedIndex = 0;
                    tbxNome.Text = Request.Cookies["pessoaJuridica"]["nome"].ToString();
                    tbxCPFCNPJ.Text = Request.Cookies["pessoaJuridica"]["cnpj"].ToString();
                    tbxRua.Text = Request.Cookies["pessoaJuridica"]["rua"].ToString();
                    tbxNumero.Text = Request.Cookies["pessoaJuridica"]["numero"].ToString();
                    ddwTipo.SelectedIndex = Int32.Parse(Request.Cookies["pessoaJuridica"]["tipo"]);
                    tbxRef.Text = Request.Cookies["pessoaJuridica"]["referencia"].ToString();
                }
                if (Request.Params["storage"] == "session" & Request.Params["cad"] == "pf")
                {
                    listaPersistencia.SelectedIndex = 1;
                    tbxNome.Text = Session["nome"].ToString();
                    tbxCPFCNPJ.Text = Session["cpf"].ToString();
                    tbxRua.Text = Session["rua"].ToString();
                    tbxNumero.Text = Session["numero"].ToString();
                    ddwTipo.SelectedIndex = Int32.Parse((string)Session["tipo"]);
                    tbxRef.Text = Session["referencia"].ToString();
                }
                if (Request.Params["storage"] == "session" & Request.Params["cad"] == "pj")
                {
                    listaPersistencia.SelectedIndex = 1;
                    tbxNome.Text = Session["PJnome"].ToString();
                    tbxCPFCNPJ.Text = Session["PJcnpj"].ToString();
                    tbxRua.Text = Session["PJrua"].ToString();
                    tbxNumero.Text = Session["PJnumero"].ToString();
                    ddwTipo.SelectedIndex = Int32.Parse((string)Session["PJtipo"]);
                    tbxRef.Text = Session["PJreferencia"].ToString();
                }
            }

        }
        protected void ddwTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddwTipo.SelectedIndex == 2)
            {
                tbxRef.Visible = true;
                lblRef.Visible = true;
            }
            else
            {
                tbxRef.Visible = false;
                lblRef.Visible = false;
                tbxRef.Text = "";

            }

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
                        int salvar = Int16.Parse(listaPersistencia.SelectedIndex.ToString());
            if (Request.Params["cad"] == "pj")
            {
                
                M.Juridica pj = new M.Juridica();
                pj.Nome = tbxNome.Text;
                pj.Numero = Int32.Parse(tbxNumero.Text);
                pj.Rua = tbxRua.Text;
                pj.CNPJ = tbxCPFCNPJ.Text;
                pj.Tipo = ddwTipo.SelectedIndex;
                pj.Referencia = tbxRef.Text;
                switch (salvar)
                {
                    case 0: Response.SetCookie(pj.setInCookie()); break;
                    case 1: pj.setInSession(Session); break;
                    case 2: pj.setInDb(); break;
                }
                Response.Redirect("visualizar.aspx?cad=pj");
            }
            else{
            
            M.Fisica pf = new M.Fisica();
            pf.Nome = tbxNome.Text;
            pf.Numero = Int32.Parse(tbxNumero.Text);
            pf.Rua = tbxRua.Text;
            pf.CPF = tbxCPFCNPJ.Text;
            pf.Tipo = ddwTipo.SelectedIndex;
            pf.Referencia = tbxRef.Text;
            switch (salvar)
            {
                case 0: Response.SetCookie(pf.setInCookie()); break;
                case 1: pf.setInSession(Session); break;
                case 2: pf.setInDb() ; break;
            }

            Response.Redirect("visualizar.aspx?cad=pf");
            }
            
            
            
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

        }
        }
    }
