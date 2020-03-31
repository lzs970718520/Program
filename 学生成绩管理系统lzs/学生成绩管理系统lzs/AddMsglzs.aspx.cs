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
    public partial class AddMsglzs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadDpd();
            }
        }

        private void LoadDpd()
        {
            DataTable dt = new UserInfoBLLlzs().LoadDpdlzs();
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataTextField = "ClassName";
            this.DropDownList1.DataValueField = "ClassId";
            this.DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("indexlzs.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Userlzs u = new Userlzs();
            u.UserName = this.TextBox1.Text;
            bool flag = new UserInfoBLLlzs().AddMsglzs(u);
            if (flag)
            {
                u.sClassId = Convert.ToInt32(this.DropDownList1.SelectedValue);
                u.Chinese = Convert.ToInt32(this.TextBox2.Text);
                u.Math = Convert.ToInt32(this.TextBox3.Text);
                u.English = Convert.ToInt32(this.TextBox4.Text);
                u.Computer = Convert.ToInt32(this.TextBox5.Text);
                bool flag2 = new UserInfoBLLlzs().AddMsglzs(u);
                if (flag2)
                {
                    Response.Redirect("indexlzs.aspx");
                }
                else {
                    Response.Write("<script>alert('添加失败')</script>");
                }
            }
            else {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
    }
}