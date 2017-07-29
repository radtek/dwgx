<%@ WebHandler Language="C#" Class="ClassPageHandle" %>

using System;
using System.Web;
using System.Data;

public class ClassPageHandle : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        SqlChecker SqlChecker = new SqlChecker(context.Request, context.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        string mTypeId = context.Request.QueryString["TypeId"];

        int _pageIndex = 1;
        if (context.Request.QueryString["pageIndex"] != null)
            _pageIndex = int.Parse(context.Request.QueryString["pageIndex"]);

        string _sqlStr;
        string whereStr = "where 1=1 ";

        if (string.IsNullOrEmpty(mTypeId) == false)
            whereStr += string.Format(" and iTypeId = {0} ", mTypeId);

       
        _sqlStr = "select ID,cTitle,dCreateTime,cPutPicPath from tb_News " + whereStr + " order by dCreateTime desc";
        DataSet _dsNotice = DWGX.Data.SqlHelper.Query(_sqlStr);

        DataSet _ds = CommonClass.SplitDataSet(_dsNotice, _pageIndex, 10);       

        context.Response.Write(ConvertJson.ToJson(_ds));
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}