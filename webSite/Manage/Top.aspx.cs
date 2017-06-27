using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Manger_Top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        string _user = Request.Cookies["Login"]["userName"];
        
        DWGX.Model.User _currUser = new DWGX.BLL.User().GetUser(_user);
        if (_currUser != null)
        {
            cAccount.Text = _user;
            iLoginCount.Text = _currUser.loginCount.ToString();
            dLastTime.Text = _currUser.lastLoginTime.ToString();
        }


    }
}
