using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace 汽车信息管理系统
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetGrid();
                ShowDpd();
            }
        }

        private void ShowDpd()
        {
            DataTable dt = new CarInfoBLL().ShowDpdBLL();
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataTextField = "BrandName";
            this.DropDownList1.DataValueField = "BrandId";
            this.DropDownList1.DataBind();
        }

        private void GetGrid()
        {
            DataTable dt = new CarInfoBLL().GetGridBLL(null);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            CarDetailinfo c = new CarDetailinfo();
            if (e.CommandName == "del")
            {
                c.cid = Convert.ToInt32(e.CommandArgument.ToString());
                bool flag = new CarInfoBLL().DelGridBLL(c);
                if (flag)
                {
                    Response.Write("<script>alert('删除成功')</script>");
                    GetGrid();
                }
                else
                {
                    Response.Write("<script>alert('删除失败')</script>");
                }
            }
            //if (e.CommandName == "bj")
            //{
            //    c.cid = Convert.ToInt32(e.CommandArgument.ToString());

            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string price = this.TextBox2.Text;
            string price2 = this.TextBox3.Text;
            if (price != "" && price2 != "")
            {
                try
                {
                    Convert.ToInt32(price);
                    Convert.ToInt32(price2);
                }
                catch
                {
                    Response.Write("<script>alert('请输入整数')</script>");
                    return;
                }
            }
            CarDetailinfo c = new CarDetailinfo();
            c.cname = this.TextBox1.Text;
            if (price != "" && price2 != "")
            {
                if (Convert.ToInt32(price) < Convert.ToInt32(price2))
                {
                    c.Price = Convert.ToInt32(price);
                    c.Price2 = Convert.ToInt32(price2);
                }
                else
                {
                    Response.Write("<script>alert('请在方框左边输入范围起点')</script>");
                }
            }
            DataTable dt = new CarInfoBLL().GetGridBLL(c);
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCar.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetGrid();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetGrid();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CarDetailinfo c = new CarDetailinfo();
            c.cid = (int)GridView1.DataKeys[e.RowIndex].Value;
            c.Content =((TextBox)GridView1.Rows[e.RowIndex].FindControl("CarInfo")).Text;
            c.Price =Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("CarPrice")).Text);
            bool flag = new CarInfoBLL().UpdateGridBLL(c);
            if (flag)
            {
                GridView1.EditIndex = -1;
                GetGrid();
                Response.Write("<script>alert('修改成功')</script>");
            }
            else {
                GridView1.EditIndex = -1;
                Response.Write("<script>alert('修改失败')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}