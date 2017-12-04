using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ReView :XQiang.Page.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSet ds = null;
        mySql.RunProc("sp_Index_ReView", out ds);

        PagedDataSource objPds = new PagedDataSource();
        objPds.DataSource = ds.Tables[0].DefaultView;


        objPds.AllowPaging = true;
        objPds.PageSize = 20;
        int CurPage = 1;
        if (myChar.RequestQueryString("Page").Length > 0)
        {
            CurPage = Convert.ToInt32(Request.QueryString["Page"]);
        }
        else
        {
            CurPage = 1;
        }

        objPds.CurrentPageIndex = CurPage - 1;

        this.myDataList.DataSource = objPds;
        this.myDataList.DataBind();

        lblCurrentPage.Text = " " + CurPage.ToString();

        myCount.Text = objPds.DataSourceCount.ToString();
        PageCount.Text = objPds.PageCount.ToString();

        if (objPds.PageCount > 1)
        {
            if (CurPage != 1)
            {
                this.First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=1";

            }
        }

        if (!objPds.IsFirstPage)
        {
            lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1) ;
        }
        if (!objPds.IsLastPage)
        {
            lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1) ;
        }

        if (objPds.PageCount > CurPage)
        {
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + objPds.PageCount ;
        }

    }
}