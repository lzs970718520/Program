using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace 请假管理
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Denglu_Click(object sender, EventArgs e)
        {
            UserInfo u = new UserInfo();
            u.LoginName = TextBox1.Text;
            u.Password = TextBox2.Text;
            DataTable dt = new LoginBLL().LonginBLL(u);
            if (dt.Rows.Count > 0 && dt != null)
            {
                if (dt.Rows[0]["UserRole"].ToString() == "1")
                {
                    Response.Redirect("LeaveList.aspx");
                }
                else if (dt.Rows[0]["UserRole"].ToString() == "2")
                {
                    Response.Redirect(string.Format("LeaveApply.aspx?UserID={0}",dt.Rows[0]["UserID"].ToString()));
                }

            }
            else {
                Response.Write("<script>alert('登陆失败')</script>");
            }
        }
    }
}