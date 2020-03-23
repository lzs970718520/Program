using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Model;

namespace 个人任务管理系统
{
    public partial class TaskList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadGrid();
                DpdMsg();
            }
        }

        private void DpdMsg()
        {
            DataTable dt = new GetMsgBLL().DpdMsgBLL();
            this.dplXiangmu.DataTextField = "ProjectName";
            this.dplXiangmu.DataValueField = "ProjectID";
            this.dplXiangmu.DataSource = dt;
            this.dplXiangmu.DataBind();
        }

        private void LoadGrid()
        {
            DataTable dt = new GetMsgBLL().GridMsgBLL();
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TaskInfo t = new TaskInfo();
            t.ProjectID = Convert.ToInt32(this.dplXiangmu.SelectedValue.ToString());
            t.Content = this.txtRenwu.Text;
            t.TaskState = this.RadioButton1.Checked ? 1 : this.RadioButton2.Checked ? 2 : 0;
            DataTable dt = new GetMsgBLL().CheckGrid(t);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            TaskInfo t = new TaskInfo();
            if (e.CommandName == "del") {
                t.TaskID = Convert.ToInt32(e.CommandArgument);
                bool flag = new GetMsgBLL().DelGridBLL(t);
                if (flag)
                {
                    Response.Write("<script>alert('删除成功')</script>");
                    LoadGrid();
                }
                else
                {
                    Response.Write("<script>alert('删除失败')</script>");
                }
            }
            if (e.CommandName == "fns") { 
                t.TaskID = Convert.ToInt32(e.CommandArgument);
                bool flag = new GetMsgBLL().finnish(t);
                if (flag)
                {
                    Response.Write("<script>alert('修改成功')</script>");
                    LoadGrid();
                }
                else {
                    Response.Write("<script>alert('修改失败')</script>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("AddTask.aspx");
        }
    }
}