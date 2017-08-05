using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class mobile_class : System.Web.UI.Page
{
    private int mTypeId;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        mTypeId = int.Parse(Request.QueryString["TypeId"]);

        string _sqlStr;

        string whereStr = " where 1=1";

        if (string.IsNullOrEmpty(mTypeId.ToString()) == false)
            whereStr += string.Format(" and iTypeId = {0} ", mTypeId);


        //大旺新闻
        _sqlStr = "select top 10 ID,cTitle,dCreateTime,cPutPicPath from tb_News " + whereStr + " order by dCreateTime desc";
        DataSet _dsNotice = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptNews.DataSource = _dsNotice;
        rptNews.DataBind();

        noDataTip.Text = _dsNotice.Tables[0].Rows.Count == 0 ? "<br />暂无相关信息" : "";
    }

    public int typeId
    {
        get { return mTypeId; }
    }
}