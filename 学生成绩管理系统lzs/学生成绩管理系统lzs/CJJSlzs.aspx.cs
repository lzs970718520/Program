using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Model;

namespace 学生成绩管理系统lzs
{
    public partial class CJJSlzs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadMsg();
            }
        }

        private void LoadMsg()
        {
            Userlzs u = new Userlzs();
            u.rid =Convert.ToInt32(Request.QueryString["rid"].ToString());
            DataTable dt = new UserInfoBLLlzs().ShowGridlzs(u);
            this.Label1.Text = dt.Rows[0]["UserName"].ToString();
            this.Label2.Text = dt.Rows[0]["ClassName"].ToString();
            this.TextBox1.Text = dt.Rows[0]["Chinese"].ToString();
            this.TextBox2.Text = dt.Rows[0]["Math"].ToString();
            this.TextBox3.Text = dt.Rows[0]["English"].ToString();
            this.TextBox4.Text = dt.Rows[0]["Computer"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexlzs.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Userlzs u = new Userlzs();
            u.rid = Convert.ToInt32(Request.QueryString["rid"].ToString());
            u.Chinese =Convert.ToInt32(this.TextBox1.Text);
            u.Math = Convert.ToInt32(this.TextBox2.Text);
            u.English = Convert.ToInt32(this.TextBox3.Text);
            u.Computer = Convert.ToInt32(this.TextBox4.Text);
            bool flag = new UserInfoBLLlzs().UpdateGridlzs(u);
            if (flag)
            {
                Response.Redirect("indexlzs.aspx");
            }
            else
            {
                Response.Write("<script>alert('修改失败')</script>");
            }
        }
    }
}