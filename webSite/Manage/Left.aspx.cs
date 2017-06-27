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
using System.Collections.Generic;

public partial class Manger_Left : System.Web.UI.Page
{
    //权限处理

    private List<string> lstLimit;
    string _userName;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        _userName = Request.Cookies["Login"]["userName"];

        if (!IsPostBack)
        {
            this.bindData();

            DWGX.Model.User _user = new DWGX.BLL.User().GetUser(_userName);
            if (_user != null)
            {
                string[] _arryLimit = _user.Limit.Split(',');
                lstLimit =  new List<string>(_arryLimit);
            }

            //根据设定权限显示相应版块内容
            foreach (RepeaterItem _item in myVideoList.Items)
            {                
                if (GetNewsTypeLimit("News_All"))
                    break;                   
                               
                HtmlTableRow tr = _item.FindControl("myNewTypeTr") as HtmlTableRow;
                string _attr = tr.Attributes["dataID"];
                tr.Visible = GetNewsTypeLimit("News_T" + _attr);
            }

            //根据设定权限显示相应版块内容
            foreach (RepeaterItem _item in myAboutType.Items)
            {
                if (GetNewsTypeLimit("Info_All"))
                    break;

                HtmlTableRow tr = _item.FindControl("myInfoTr") as HtmlTableRow;
                string _attr = tr.Attributes["dataID"];
                tr.Visible = GetNewsTypeLimit("Info_T" + _attr);
            }
        }


    }

    private void bindData()
    {
        //信息管理列表DataSet
        DataSet _dsNewsType = new DWGX.BLL.NewsType().GetList("iShow=1 and parentId=0");
        if (_dsNewsType != null)
        {
            myVideoList.DataSource = _dsNewsType;
            myVideoList.DataBind();
        }

        //内容管理列表
        DataSet _dsInfo = new DWGX.BLL.Info().GetList("*", "isShow=1","sort");
        if (_dsInfo != null)
        {
            myAboutType.DataSource = _dsInfo;
            myAboutType.DataBind();
        }

    }

    public bool GetNewsTypeLimit(string limitName)
    {
        if (_userName.ToLower() == "admin")
            return true;
        if (lstLimit != null)
            return lstLimit.IndexOf(limitName) > -1;
        return false;
    }

    public bool GetBigTypeLimit(string limitName)
    {
        if (_userName.ToLower() == "admin")
            return true;

        DWGX.Model.User _user = new DWGX.BLL.User().GetUser(_userName);
        if (_user != null)
        {
            string _sqlStr = string.Format("select 1 from tb_User where Limit like '%{0}%' and id={1}",limitName,_user.id);
            DataSet _ds = DWGX.Data.SqlHelper.Query(_sqlStr);
            return _ds.Tables[0].Rows.Count > 0;
        }
        return false;

    }
}
