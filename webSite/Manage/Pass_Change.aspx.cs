using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Pass_Change : System.Web.UI.Page
{
    private int userId;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        string userName = Request.Cookies["Login"]["userName"];

        DWGX.Model.User _user = new DWGX.BLL.User().GetUser(userName);
        if (_user != null)
        {
            cAccount.Text = _user.name;
            userId = _user.id;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        DWGX.Model.User _user = new DWGX.BLL.User().GetUser(userId);
        if (_user != null)
        {           
            if (BCW.Common.Utils.MD5(cOldPass.Text) != _user.passWord)
            {
                Response.Write(new CommonClass().MessageBox("原密码不正确", "Pass_Change.aspx"));
                return;
            }

            //修改密码
            _user.passWord = BCW.Common.Utils.MD5(cNewPass.Text);
            new DWGX.BLL.User().Update(_user);
            Response.Write(new CommonClass().MessageBox("密码修改成功", "Pass_Change.aspx"));
        }
    }

}