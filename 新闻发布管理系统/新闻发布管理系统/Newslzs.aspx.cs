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

        }
    }
}