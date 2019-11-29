using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ServerControl_1__1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.IsPostBack+"<br/>");
            //PostBack:A webpage sending request back to it self is called postback 
            //Response.Write("Value of TextBox:"+TextBox1.Text);
            if(this.IsPostBack==true)
            Response.Write("Value of TextBox:" + TextBox1.Text);
            //PostBack Sub:In postback all data that is associated with the form and it's controls will
            //be submitted to the page on server.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    //By default button control is designed for submitting a page to server
    //TextBox,Checkbox,Radiobuttoon,DropDownList-Submitting page to server
    //their AutoPostBack property is set="True",default=false.





























}