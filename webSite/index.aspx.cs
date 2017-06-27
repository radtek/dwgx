using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class index : System.Web.UI.Page
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
        //头条新闻
        string _sqlStr = "select top 14 ID,cTitle,cContent,dCreateTime from tb_News where iTypeId=2 order by dCreateTime desc";
        DataSet _dsNo1News = DWGX.Data.SqlHelper.Query(_sqlStr);
        if (_dsNo1News.Tables[0].Rows.Count > 0)
        {
            No1NewTitle.Text = _dsNo1News.Tables[0].Rows[0]["cTitle"].ToString();
            No1NewTitle.NavigateUrl = "NewDetail.aspx?id="+ _dsNo1News.Tables[0].Rows[0]["ID"].ToString();
            No1NewDetail.NavigateUrl = "NewDetail.aspx?id=" + _dsNo1News.Tables[0].Rows[0]["ID"].ToString();
            No1NewContent.Text = CommonClass.ReplaceHtmlTag(_dsNo1News.Tables[0].Rows[0]["cContent"].ToString(),100)+"...";
            No1NewDay.Text = (DateTime.Parse(_dsNo1News.Tables[0].Rows[0]["dCreateTime"].ToString())).Day.ToString();
            No1NewYearMonth.Text = (DateTime.Parse(_dsNo1News.Tables[0].Rows[0]["dCreateTime"].ToString())).Year.ToString() + "." + (DateTime.Parse(_dsNo1News.Tables[0].Rows[0]["dCreateTime"].ToString())).Month.ToString();
        }
        

        //大旺新闻
        _sqlStr = "SELECT TOP 6 ID,cTitle,dCreateTime FROM(SELECT*, ROW_NUMBER () OVER(ORDER BY dCreateTime DESC) AS ROWNUM FROM tb_News where iTypeId=2 )TEMP WHERE ROWNUM >1";
        DataSet _dsDwNews = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptDwNews.DataSource = _dsDwNews;
        rptDwNews.DataBind();

        //通知公告
        _sqlStr = "select top 14 ID,cTitle,dCreateTime from tb_News where iTypeId=3 order by dCreateTime desc";
        DataSet _dsNotice = DWGX.Data.SqlHelper.Query(_sqlStr);
        rptNotice.DataSource = _dsNotice;
        rptNotice.DataBind();


        //轮播图片
        _sqlStr = "select top 5 ID,cTitle,cPicPath from tb_News where cPicPath!='' order by dCreateTime desc";
        DataSet _dsScrollAd = DWGX.Data.SqlHelper.Query(_sqlStr);
        scrollAd.DataSource = _dsScrollAd;
        scrollAd.DataBind();

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();

    }


 }