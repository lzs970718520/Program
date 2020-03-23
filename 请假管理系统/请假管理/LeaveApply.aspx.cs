using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 请假管理
{
    public partial class LeaveApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Leave L = new Leave();
            L.Title = this.txtTitle.Text;
            L.BeginDate = Convert.ToDateTime( this.txtBegin.Text.ToString());
            L.EndDate = Convert.ToDateTime( this.txtOver.Text.ToString());
            L.LeaveReason = TextBox1.Text;
            L.UserID =Convert.ToInt32( Request.QueryString["UserID"]);
            bool flag = new LoginBLL().QingjiaBLL(L);
            if (flag) {
                Response.Write("<script>alert('请假成功')</script>");
            }
        }
    }
}