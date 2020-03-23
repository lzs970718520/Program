using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLlzs;
using Modellzs;
using System.Data;

namespace 新闻发布管理系统
{
    public partial class Loginlzs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfolzs u = new UserInfolzs();
            u.UserName = this.TextBox1.Text;
            u.Psswd = this.TextBox2.Text;
            DataTable dt = new UserInfoBLLlzs().LonginBLLlzs(u);
            if (dt.Rows.Count > 0 && dt != null)
            {
                Response.Redirect("Newslzs.aspx?user=" + u.UserName);
            }
            else {
                Response.Write("<script>alert('登陆失败')</script>");
            }
        }
    }
}