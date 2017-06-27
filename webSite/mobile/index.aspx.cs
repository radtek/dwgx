using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class mobile_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.bindData();
        }
    }

    private void bindData()
    {
        string _sqlStr = "";

        //轮播图片
        _sqlStr = "select top 5 ID,cTitle,cPicPath from tb_News where cPicPath!='' order by dCreateTime desc";
        DataSet _dsScrollAd = DWGX.Data.SqlHelper.Query(_sqlStr);
        scrollAd.DataSource = _dsScrollAd;
        scrollAd.DataBind();

        //大旺新闻
        _sqlStr = "SELECT TOP 5 ID,cTitle,dCreateTime FROM(SELECT*, ROW_NUMBER () OVER(ORDER BY dCreateTime DESC) AS ROWNUM FROM tb_News where iTypeId=2 )TEMP WHERE ROWNUM >1";
        DataSet _dsDwNews = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptDwNews.DataSource = _dsDwNews;
        rptDwNews.DataBind();

        //通知
        _sqlStr = "select top 5 ID,cTitle,dCreateTime from tb_News where iTypeId=3 order by dCreateTime desc";
        DataSet _dsNotice = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptNotice.DataSource = _dsNotice;
        rptNotice.DataBind();

        //政策
        _sqlStr = "select top 5 ID,cTitle,dCreateTime from tb_News where iTypeId=30 order by dCreateTime desc";
        DataSet _dsPolicy = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptPolicy.DataSource = _dsPolicy;
        rptPolicy.DataBind();


        //专题
        _sqlStr = "select top 5 ID,cTypeName,dCreateTime from tb_NewsType where parentId=5 order by dCreateTime desc";
        DataSet _dsSpecial = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptSpecial.DataSource = _dsSpecial;
        rptSpecial.DataBind();

        //年报
        _sqlStr = "select top 5 ID,cTitle,dCreateTime from tb_News where iTypeId=28 order by dCreateTime desc";
        DataSet _dsAnualReport = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptAnualReport.DataSource = _dsAnualReport;
        rptAnualReport.DataBind();
        
    }
}