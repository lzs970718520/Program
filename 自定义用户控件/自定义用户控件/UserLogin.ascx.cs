using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 自定义用户控件
{
    public partial class UserLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.TextBox1.Text == "admin" && this.TextBox2.Text == "123")
            {
                Response.Write("<script>alert('登陆成功')</script>");
            }
            else { 
                Response.Write("<script>alert('登陆失败')</script>");
            }
        }
    }
}