using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace 游戏点卡
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                ShowGrid();
            }
        }
        public void ShowGrid() {
            this.GridView1.DataSource = new CardinfoBLL().ShowGrid();
            this.GridView1.DataBind();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCard.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GameCard g = new GameCard();
            g.gamename = this.TextBox1.Text;
            g.company = this.TextBox2.Text;
            this.GridView1.DataSource = new CardinfoBLL().checkGrid(g);
            this.GridView1.DataBind();
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GameCard g = new GameCard();
            g.cardid = Convert.ToInt32(this.GridView1.DataKeys[e.RowIndex].Value);
            bool flag = new CardinfoBLL().delMsg(g);
            if (flag)
            {
                Response.Write("<script>alert('删除成功')</script>");
                ShowGrid();
            }
            else {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}