using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Modellzs;
using BLLlzs;

namespace 新闻发布管理系统
{
    public partial class Newslzs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.Label1.Text = Request.QueryString["user"];
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            DataTable dt = new UserInfoBLLlzs().LoadGrid();
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NewsInfolzs n = new NewsInfolzs();
            n.N_type =Convert.ToInt32( DropDownList1.SelectedIndex.ToString());
            n.n_title = this.TextBox1.Text;
            n.n_content = this.TextBox2.Text;
            DataTable dt = new UserInfoBLLlzs().CheckGridlzs(n);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NewsInfolzs n = new NewsInfolzs();
            n.n_name = Request.QueryString["user"];
            n.n_title = this.TextBox1.Text;
            n.n_content = this.TextBox2.Text;
            bool flag = new UserInfoBLLlzs().AddNewslzs(n);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}