using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ServerControl1__3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load event Fired <br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Cached event of TextBox");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Post back event of button fired <br/>");
        }
    }
}
//Page load event fired
//Cashed evt of text
//post back event of button