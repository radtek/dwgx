<%@ WebHandler Language="C#" Class="SpeciaPageHandle" %>

using System;
using System.Web;
using System.Data;

public class SpeciaPageHandle : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        SqlChecker SqlChecker = new SqlChecker(context.Request, context.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        string mTypeId = context.Request.QueryString["TypeId"];

        int _pageIndex = 1;
        if (context.Request.QueryString["pageIndex"] != null)
            _pageIndex = int.Parse(context.Request.QueryString["pageIndex"]);

        string _sqlStr;
        string whereStr = " where parentId=" + mTypeId;


        _sqlStr = "select * from tb_NewsType " + whereStr + " order by dCreateTime desc";
        DataSet _dsSplcia = DWGX.Data.SqlHelper.Query(_sqlStr);

        DataSet _ds = CommonClass.SplitDataSet(_dsSplcia, _pageIndex, 10);

        context.Response.Write(ConvertJson.ToJson(_ds));
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}