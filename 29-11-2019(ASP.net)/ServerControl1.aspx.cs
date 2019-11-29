using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ServerControl1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void btmClick_Click(object sender, EventArgs e)
        {
            string str = "Hello" + TextBox1.Text;
            Response.Write(str);
        }
    }
}