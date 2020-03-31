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
    public partial class indexlzs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                ShowGrid();
                LoadDpd();
            }
        }

        private void LoadDpd()
        {
            DataTable dt = new UserInfoBLLlzs().LoadDpdlzs();
            this.DropDownList1.DataSource = dt;
            DataRow dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "-全部-";
            dt.Rows.InsertAt(dr, 0);
            this.DropDownList1.DataTextField = "ClassName";
            this.DropDownList1.DataValueField = "ClassId";
            this.DropDownList1.DataBind();
        }

        private void ShowGrid()
        {
            DataTable dt = new UserInfoBLLlzs().ShowGridlzs(null);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Userlzs u = new Userlzs();
            u.UserName = this.TextBox1.Text;
            u.sClassId = Convert.ToInt32(this.DropDownList1.SelectedValue);
            u.IfPass = this.RadioButton1.Checked ? 0 : this.RadioButton2.Checked ? 2 : this.RadioButton3.Checked ? 1 : 9;
            u.Rlevel = this.RadioButton4.Checked ? 0 : this.RadioButton5.Checked ? 4 : this.RadioButton6.Checked ? 3 : this.RadioButton7.Checked ? 2 : this.RadioButton8.Checked ? 1 : 9;
            DataTable dt = new UserInfoBLLlzs().ShowGridlzs(u);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMsglzs.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "del") {
                Userlzs u = new Userlzs();
                u.rid = Convert.ToInt32(e.CommandArgument.ToString());
                bool flag = new UserInfoBLLlzs().DelGridlzs(u);
                if (flag) {
                    Response.Write("<script>alert('删除成功')</script>");
                    ShowGrid();
                }
            }
            if (e.CommandName == "XiuGai") {
                Response.Redirect(string.Format("CJJSlzs.aspx?rid={0}" , Convert.ToInt32(e.CommandArgument.ToString())));
            }
            if (e.CommandName == "CJJS") {
                Userlzs u = new Userlzs();
                u.rid =Convert.ToInt32(e.CommandArgument.ToString());
                bool flag = new UserInfoBLLlzs().JieSuanBLL(u);
                if (flag) {
                    ShowGrid();
                }
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Button btn = e.Row.FindControl("BtnJS") as Button;
            string zf = e.Row.Cells[7].Text;
            bool flag = false;
            try
            {
                Convert.ToInt32(zf);
                flag = true;
            }
            catch {
                flag = false;
            }
            if (flag)
            {
                btn.Visible = false;
            }
        }
    }
}