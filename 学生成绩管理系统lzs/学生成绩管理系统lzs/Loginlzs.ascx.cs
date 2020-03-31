using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace 学生成绩管理系统lzs
{
    public partial class Longinlzs : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Userlzs u = new Userlzs();
            u.UserName = this.TextBox1.Text;
            u.UserPsw = this.TextBox2.Text;
            DataTable dt = new UserInfoBLLlzs().LoginBLLlzs(u);
            if (dt.Rows.Count > 0 && dt != null)
            {
                Response.Redirect("indexlzs.aspx");
            }
            else {
                Response.Write("<script>alert('登陆失败')</script>");
            }
        }
    }
}