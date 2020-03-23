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
    public partial class AddTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadDpd();
            }
        }

        private void LoadDpd()
        {
            DataTable dt = new GetMsgBLL().DpdMsgBLL();
            this.DropDownList1.DataTextField = "ProjectName";
            this.DropDownList1.DataValueField = "ProjectID";
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TaskList.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TaskInfo t = new TaskInfo();
            t.TaskID =Convert.ToInt32(this.DropDownList1.SelectedValue.ToString())+1;
            t.TaskPriority = this.RadioButton1.Checked ? 1 : this.RadioButton2.Checked ? 2 : 3;
            t.Content = this.TextBox1.Text;
            bool flag = new GetMsgBLL().AddMsg(t);
            if (flag)
            {
                Response.Write("<script>alert('添加成功')</script>");
            }
            else {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
    }
}