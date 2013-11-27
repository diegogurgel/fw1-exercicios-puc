using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Exercicios
{
    public partial class CadastroPF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbxRef.Visible = false;
            lblRef.Visible = false;
            if (Request.Params["cad"] == "pj")
            {
                lblCad.InnerText = "Cadastro de Pessoa Jurídica";
                lblCPFCNPJ.InnerText = "CNPJ";
            }
           
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

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
                Response.Redirect("visualizar.aspx?cad=pj&show="+pj.CNPJ);
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

            Response.Redirect("visualizar.aspx?cad=pf&show="+pf.CPF);
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


    }
}