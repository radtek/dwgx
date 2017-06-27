using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //注销用户
        HttpCookie _httpCookie = Request.Cookies["Login"];
        if (_httpCookie != null)
        {
            _httpCookie.Expires = DateTime.Now;
            Response.Cookies.Add(_httpCookie);           
        }

        Response.Redirect("Login.aspx");
    }
}