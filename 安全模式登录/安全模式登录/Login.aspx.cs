using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 安全模式登录
{
    public partial class Login : System.Web.UI.Page
    {
        private const string userName = "admin";
        private const string userPsw = "123456";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(this.TextBox1.Text == userName && this.TextBox2.Text == userPsw)
            {
                string[] userRoles = new string[] { "1", "1", "0" };
                string userData = userName + "," + string.Join(",",userRoles);

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddDays(30), true, userData);
                string authTicket = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, authTicket);

                cookie.Expires = ticket.Expiration;
                Response.Cookies.Add(cookie);
                Response.Redirect("index.aspx");
            }
        }
    }
}