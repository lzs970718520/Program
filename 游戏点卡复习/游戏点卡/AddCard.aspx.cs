using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 游戏点卡
{
    public partial class AddCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            GameCard g = new GameCard();
            g.gamename = this.TextBox1.Text;
            g.company = this.TextBox2.Text;
            g.lastDay = Convert.ToDateTime(this.TextBox3.Text);
            g.price = Convert.ToInt32(this.TextBox4.Text);
            bool flag = new CardinfoBLL().AddCardBLL(g);
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