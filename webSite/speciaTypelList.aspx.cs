﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class speciaTypelList : System.Web.UI.Page
{
    private int CurrentPage;
    public string reqTypeId;
    public string reqTypeName;
    public string reqSeekTitle;
    public int recordCount;

    private string toolTip = "";

     public string toolTipUrl;

    protected void Page_Load(object sender, EventArgs e)
    {

        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        if (!IsPostBack)
        {

            reqTypeId = Request.QueryString["TypeId"];
            reqSeekTitle = Request.QueryString["seekStr"];
            if (Request.QueryString["ToolTip"] != null)
                toolTipUrl = Request.QueryString["ToolTip"];

            if (!string.IsNullOrEmpty(reqTypeId))
                GetToolTipUrl(int.Parse(reqTypeId));

            string whereStr = " where parentId=" + reqTypeId;

            if (string.IsNullOrEmpty(reqSeekTitle) == false)
                whereStr += string.Format(" and cTypeName like '%{0}%' ", reqSeekTitle);

            //大旺新闻
            string _sqlStr;
            _sqlStr = "select * from tb_NewsType " + whereStr + " order by id";
            DataSet _dsNews = DWGX.Data.SqlHelper.Query(_sqlStr);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = _dsNews.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 20;
            recordCount = _dsNews.Tables[0].Rows.Count;

            if (Request.QueryString["Page"] != null)
            {

                CurrentPage = Convert.ToInt32(Request.QueryString["Page"]);
            }
            else
            {
                CurrentPage = 1;
            }


            if (_dsNews != null && _dsNews.Tables[0].Rows.Count > 20)
            {
                pds.CurrentPageIndex = CurrentPage - 1;       //     当前页所引为页码-1
                                                              //  dangqian.Text = CurrentPage.ToString();       //     当前页
                if (!pds.IsFirstPage)
                {
                    //            Request.CurrentExecutionFilePath为当前请求虚拟路径
                    lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(CurrentPage - 1) + "&ToolTip=" + toolTip;
                }
                //   如果不是最后一页，通过参数Page设置下一页为当前页+1，否则不显示连接
                if (!pds.IsLastPage)
                {
                    //    Request.CurrentExecutionFilePath为当前请求虚拟路径
                    lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(CurrentPage + 1) + "&ToolTip=" + toolTip;
                }
                //首页
                First.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(1) + "&ToolTip=" + toolTip;
                //尾页
                Last.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&page=" + pds.PageCount.ToString() + "&ToolTip=" + toolTip;

                if (Convert.ToInt32(HttpContext.Current.Request["page"]) > pds.PageCount)
                {

                    First.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(1) + "&ToolTip=" + toolTip;
                }


                PageCount.Text = pds.PageCount.ToString();
                lblCurrentPage.Text = (CurrentPage).ToString();
                myCount.Text = _dsNews.Tables[0].Rows.Count.ToString();


            }

            rptNews.DataSource = pds;
            rptNews.DataBind();

            noDataTip.Text = _dsNews.Tables[0].Rows.Count == 0 ? "暂无相关信息" : "";
        }

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();
    }

    public void GetToolTipUrl(int typeId)
    {
        //创建ToolTip
        bool loop = true;
        int _reqTypeId = typeId;
        toolTipUrl = "";
        List<string> arryToolTip = new List<string>();
        do
        {
            string sqlStr = "select id,cTypeName,parentid from tb_NewsType where id=" + _reqTypeId;
            DataSet ds = DWGX.Data.SqlHelper.Query(sqlStr);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                if (int.Parse(ds.Tables[0].Rows[0]["parentid"].ToString()) >= 0)
                {
                    if (_reqTypeId == typeId)
                        toolTipUrl = ds.Tables[0].Rows[0]["cTypeName"].ToString();
                    else
                        toolTipUrl = "<a href=\"newTypeRedirect.ashx?TypeId=" + ds.Tables[0].Rows[0]["id"].ToString() + "\">" + ds.Tables[0].Rows[0]["cTypeName"].ToString() + "</a>" + ">" + toolTipUrl;
                    _reqTypeId = int.Parse(ds.Tables[0].Rows[0]["parentid"].ToString());
                }
                else
                    loop = false;
            }
            else
                loop = false;
        }
        while (loop == true);
    }
}