using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios
{
    public partial class fatorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            M.Fisica pf = new M.Fisica();
           


        }
        // aula1  fatorial
        public uint fat(uint num)
        {
            if (num > 1)
            {
                return fat(num - 1) * num;
            }
            else
            {
                return 1;
            }
           
        }
        
        protected void btnFatorial_Click(object sender, EventArgs e)
        {
            lblResult.Text = fat(UInt32.Parse(txtFat.Text)).ToString();
            
        }
    }
}