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
using System.Web.Services;

public partial class Manage_MemberEdit : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    private string userName;
    public string aaa;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        userName = Request.Cookies["Login"]["userName"];


        if (!IsPostBack)
        {
            bind();            
        }


    }

    [WebMethod]
    public static string Delete(string str)
    {
        string[] _arryUserId = str.Split(',');
        try
        { 
            foreach (string _userId in _arryUserId)
            {
                if (string.IsNullOrEmpty(_userId))
                    continue;
                DWGX.Model.User _user = new DWGX.BLL.User().GetUser(int.Parse(_userId));
                if (_user != null && _user.name == "admin")
                    return "不能删除系统预留[admin]管理员";

            }

            foreach (string _userId in _arryUserId)
            {
                if (string.IsNullOrEmpty(_userId))
                    continue;
                new DWGX.BLL.User().Delete(int.Parse(_userId));
            }

            return "成功删除选定帐号";
        }
        catch (Exception e)
        {
            return "操作失败:" + e.Message;
        }
    }

    /// <summary>
    /// 重设选定帐号密码为1234
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    [WebMethod]
    public static string ResetPwd(string str)
    {
        string[] _arryUserId = str.Split(',');
        foreach (string _userId in _arryUserId)
        {
            if (string.IsNullOrEmpty(_userId))
                continue;
            DWGX.Model.User _user = new DWGX.BLL.User().GetUser(int.Parse(_userId));
            if (_user != null)
            {
                _user.passWord = BCW.Common.Utils.MD5("1234");
                new DWGX.BLL.User().Update(_user);
            }            
        }

        return "成功将选定帐号密码重置为：1234";
    }


    public void bind()
    {
        DataSet _ds = new DWGX.BLL.User().GetList("*", "");
        myDataList.DataSource = _ds;
        myDataList.DataBind();
    }
    protected void gvEditMember_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void gvEditMember_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void gvEditMember_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void gvEditMember_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvEditMember_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    //protected void gvEditMember_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        ((LinkButton)(e.Row.Cells[3].Controls[0])).Attributes.Add("onclick","return confirm('确定要删除吗？')");

    //    }
    //}

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        DWGX.Model.User _currUser = new DWGX.BLL.User().GetUser(this.userName);
        if (_currUser != null)
        {
            _currUser.passWord = BCW.Common.Utils.MD5("1234");
            new DWGX.BLL.User().Update(_currUser);
            Response.Write(new CommonClass().MessageBox("成功将账号初始化密码为：1234 ！"));
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
}


