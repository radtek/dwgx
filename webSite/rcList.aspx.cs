using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class rcList : System.Web.UI.Page
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

        //大旺新闻
        string _sqlStr;
        _sqlStr = "select id,jobName,salary,jobAddr,rofs,major,amount,updateTime from tb_rcInfo  order by updateTime desc";
        DataSet _dsRc = DWGX.Data.SqlHelper.Query(_sqlStr);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = _dsRc.Tables[0].DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 20;
        recordCount = _dsRc.Tables[0].Rows.Count;

        if (Request.QueryString["Page"] != null)
        {

            CurrentPage = Convert.ToInt32(Request.QueryString["Page"]);
        }
        else
        {
            CurrentPage = 1;
        }


        if (_dsRc != null && _dsRc.Tables[0].Rows.Count > pds.PageSize)
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
            myCount.Text = _dsRc.Tables[0].Rows.Count.ToString();



        }

        rptRc.DataSource = pds;
        rptRc.DataBind();
        //noDataTip.Text = _dsRc.Tables[0].Rows.Count == 0 ? "暂无相关信息" : "";
    }
}