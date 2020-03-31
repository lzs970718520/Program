using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace 汽车信息管理系统
{
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack) {
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(this.TextBox4.Text);
            }
            catch {
                Response.Redirect("<script>alert('价格只能为正数')</script>");
            }
            CarDetailinfo c = new CarDetailinfo();
            c.cname = this.TextBox2.Text;
            c.Content = this.TextBox3.Text;
            c.Price =Convert.ToInt32(this.TextBox4.Text);
            c.ImageUrl = this.FileUpload1.FileName;
            c.BrandId =Convert.ToInt32(this.DropDownList1.SelectedValue.ToString());
            bool flag = new CarInfoBLL().AddCarBLL(c);
            if (flag)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else {
                Response.Redirect("<script>alert('添加失败')</script>");
            }
        }
    }
}