<%@ WebHandler Language="C#" Class="newTypeRedirect" %>

using System;
using System.Web;

public class newTypeRedirect : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");

        //防sql注入
        SqlChecker SqlChecker = new SqlChecker(context.Request, context.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        string reqTypeId = context.Request.QueryString["TypeId"];
        string reqToolTip = context.Request.QueryString["ToolTip"];

        DWGX.Model.NewsType _newType = new DWGX.BLL.NewsType().GetModel(int.Parse(reqTypeId));



        //如果类别表中有其它数据的parentid指向TypeId，则跳转到显示二级版面，否则跳转到该类别下的新闻列表页
        string _existsStr = "select 1 from tb_NewsType where parentid=" + reqTypeId;


        if (DWGX.Data.SqlHelper.Exists(_existsStr))
        {
            context.Response.Redirect("speciaTypelList.aspx?TypeId=" + reqTypeId + "&ToolTip=" + reqToolTip);
            return;
        }
        else
        {
            if (_newType != null && string.IsNullOrEmpty(_newType.linkUrl) == false)
            {
                 context.Response.Redirect(_newType.linkUrl);
                return;
            }
            else
            {
                context.Response.Redirect("class.aspx?TypeId=" + reqTypeId + "&ToolTip=" + reqToolTip);
                return;
            }

        }


    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}