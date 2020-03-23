using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Model;

namespace 请假管理
{
    public partial class LeaveList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                ShowDpdMsg();
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            DataTable dt = new LoginBLL().LoadGridBLL();
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        private void ShowDpdMsg()
        {
            DataTable dt = new LoginBLL().DplMsgDAL();
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataTextField = "LoginName";
            this.DropDownList1.DataValueField = "UserID";
            this.DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Leave L = new Leave();
            L.UserID =Convert.ToInt32( this.DropDownList1.SelectedValue.ToString());
            L.Title = this.TextBox1.Text;
            L.ApproveState = this.RadioButton1.Checked ? 1 : this.RadioButton2.Checked ? 2 : 0;
            DataTable dt = new LoginBLL().ckagainGrid(L);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Leave L = new Leave();
            L.LeaveID = Convert.ToInt32( this.GridView1.DataKeys[e.RowIndex].Value);
            bool flag = new LoginBLL().DelGrid(L);
            if (flag)
            {
                Response.Write("<script>alert('删除成功')</script>");
                LoadGrid();
            }
            else {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}