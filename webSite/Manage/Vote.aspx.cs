﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;

public partial class Manage_Vote : System.Web.UI.Page
{

    private int CurrentPage;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }


        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void myDataList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }


    public void bind()
    {
        DataSet _dsVote = new DWGX.BLL.Vote().GetList("*", "1=1");
        if (_dsVote != null)
        {
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = _dsVote.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 20;

            if (Request.QueryString["Page"] != null)
            {

                CurrentPage = Convert.ToInt32(Request.QueryString["Page"]);
            }
            else
            {
                CurrentPage = 1;
            }

            pds.CurrentPageIndex = CurrentPage - 1;       //     当前页所引为页码-1
                                                          //  dangqian.Text = CurrentPage.ToString();       //     当前页
            if (!pds.IsFirstPage)
            {
                //            Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage - 1);
            }
            //   如果不是最后一页，通过参数Page设置下一页为当前页+1，否则不显示连接
            if (!pds.IsLastPage)
            {
                //    Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage + 1);
            }
            //首页
            First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(1);
            //尾页
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + pds.PageCount.ToString();

            if (Convert.ToInt32(HttpContext.Current.Request["page"]) > pds.PageCount)
            {

                First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(1);
            }


            PageCount.Text = pds.PageCount.ToString();
            lblCurrentPage.Text = (CurrentPage).ToString();
            myCount.Text = _dsVote.Tables[0].Rows.Count.ToString();

            myDataList.DataSource = pds;
            myDataList.DataBind();


        }

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }

    [WebMethod]
    public static string DeleteVote(string str)
    {
        string[] _arryUserId = str.Split(',');
        try
        {
            foreach (string _voteId in _arryUserId)
            {
                if (string.IsNullOrEmpty(_voteId))
                    continue;

               //删除主体               
               new DWGX.BLL.Vote().Delete(int.Parse(_voteId));

                //删除明细
                DWGX.Data.SqlHelper.ExecuteSql("delete from tb_VoteData where iVoteID=" + _voteId);
            }
            return "操作成功";
        }
        catch (Exception e)
        {
            return "操作失败:" + e.Message;
        }


    }
}