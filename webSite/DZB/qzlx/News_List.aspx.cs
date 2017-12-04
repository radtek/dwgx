using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class qzlx_News_List : XQiang.Page.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
          System.Data.DataSet ds = null;
         string TID = "0";
        if (myChar.RequestQueryString("TID").Length > 0)
        {
            TID = myChar.RequestQueryString("TID");
        }
        mySql.RunProc("sp_Index_qzlx_News_List",
                new System.Data.SqlClient.SqlParameter[] { 
                    mySql.MakeInParam("@TID", SqlDbType.Int, 8, TID) 
                }, out ds);

        this.myDataList.DataSource = ds.Tables[1];
        this.myDataList.DataBind();

        this.cTypeName.Text = ds.Tables[0].Rows[0][0].ToString();
        this.Title = this.cTypeName.Text;

     

        PagedDataSource objPds = new PagedDataSource();
        objPds.DataSource = ds.Tables[1].DefaultView;


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
                this.First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=1&TID=" + TID;

            }
        }

        if (!objPds.IsFirstPage)
        {
            lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1) + "&TID=" + TID;
        }
        if (!objPds.IsLastPage)
        {
            lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1) + "&TID=" + TID;
        }

        if (objPds.PageCount > CurPage)
        {
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + objPds.PageCount.ToString() + "&TID=" + TID;
        }

 
    }
}