using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class VoteL : System.Web.UI.Page
{
    private int CurrentPage;
    public string reqTypeId;
    public string reqTypeName;
    public string reqSeekTitle;
    public int recordCount;

    private string toolTip = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        if (Request.QueryString["ToolTip"] != null)
            toolTip = Request.QueryString["ToolTip"];

        string whereStr = " where isOver=0";

        //大旺新闻
        string _sqlStr;
        _sqlStr = "select ID,cTitle,dCreateTime,cType from dbo.tb_Vote " + whereStr + " order by dCreateTime desc";
        DataSet _dsVote = DWGX.Data.SqlHelper.Query(_sqlStr);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = _dsVote.Tables[0].DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 20;
        recordCount = _dsVote.Tables[0].Rows.Count;

        if (Request.QueryString["Page"] != null)
        {

            CurrentPage = Convert.ToInt32(Request.QueryString["Page"]);
        }
        else
        {
            CurrentPage = 1;
        }


        if (_dsVote != null && _dsVote.Tables[0].Rows.Count > 20)
        {
            pds.CurrentPageIndex = CurrentPage - 1;       //     当前页所引为页码-1
                                                          //  dangqian.Text = CurrentPage.ToString();       //     当前页
            if (!pds.IsFirstPage)
            {
                //            Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage - 1) + "&ToolTip=" + toolTip;
            }
            //   如果不是最后一页，通过参数Page设置下一页为当前页+1，否则不显示连接
            if (!pds.IsLastPage)
            {
                //    Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage + 1) + "&ToolTip=" + toolTip;
            }
            //首页
            First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(1) + "&ToolTip=" + toolTip;
            //尾页
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + pds.PageCount.ToString() + "&ToolTip=" + toolTip;

            if (Convert.ToInt32(HttpContext.Current.Request["page"]) > pds.PageCount)
            {

                First.NavigateUrl = Request.CurrentExecutionFilePath + "?&Page=" + Convert.ToString(1) + "&ToolTip=" + toolTip;
            }


            PageCount.Text = pds.PageCount.ToString();
            lblCurrentPage.Text = (CurrentPage).ToString();
            myCount.Text = _dsVote.Tables[0].Rows.Count.ToString();



        }

        rptVote.DataSource = pds;
        rptVote.DataBind();
        noDataTip.Text = _dsVote.Tables[0].Rows.Count == 0 ? "暂无相关信息" : "";

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();

    }


}