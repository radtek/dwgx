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

public partial class AdminManage_Login : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            this.labCode.Text =CC.RandomNum(4);//产生验证码
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtAdminName.Text.Trim() == "" || txtAdminPwd.Text.Trim() == "")
        {
            Response.Write(CC.MessageBox("登录名和密码不能为空！", "Login.aspx"));
            //Response.Write("<script>alert('登录名和密码不能为空！');location='javascript:history.go(-1)';</script>");
        }
        else
        {
            //判断用户输入的验证码是否正确
            if ( txtAdminCode.Text.Trim().ToLower() == labCode.Text.Trim().ToLower())
            {
                //调用CommonClass类中的checkLogin方法，判断用户是否为合法用户
                int IntUserIn = CC.checkLogin(txtAdminName.Text.Trim(), txtAdminPwd.Text.Trim());
                if (IntUserIn > 0)
                {

                    //更新登录数据
                    DWGX.Model.User _user = new DWGX.BLL.User().GetUser(txtAdminName.Text.Trim());
                    if (_user != null)
                    {
                        _user.lastLoginIP = BCW.Common.Utils.GetUsIP();
                        _user.lastLoginTime = DateTime.Now;
                        _user.loginCount += 1;
                        new DWGX.BLL.User().Update(_user);                             
                    }


                    //写入Cookie
                    HttpCookie _cookie = new HttpCookie("Login");
                    _cookie.Values.Add("userName", txtAdminName.Text.Trim());
                    _cookie.Expires = DateTime.Now.AddMinutes(30);
                    Response.Cookies.Add(_cookie);

                    
                    //该用户为合法用户，跳转到后台首页（AdminIndex.aspx）中
                    Response.Write("<script language=javascript>window.open('AdminIndex.aspx','_self');</script>");
                }
                else
                {
                    //该用户不是合法用户，调用CommonClass类中的MassageBox方法，弹出提示框
                    Response.Write(CC.MessageBox("您输入的用户名或密码错误，请重新输入！", "Login.aspx"));
                    
                }
            }
            else
            {
                Response.Write(CC.MessageBox("验证码输入有误，请重新输入！", "Login.aspx"));
              
            }
        }
    }
       
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();location='javascript:history.go(-1)';</script>");
    }
}
