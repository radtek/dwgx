using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DZBAdmin_NewsType_List : XQiang.Page.AdminPage
{
    string iClassId = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = null;

            if (myChar.RequestQueryString("CId").Length > 0)
            {
                iClassId = myChar.RequestDataQueryString("CID");
            }
            


            mySql.RunProc("sp_Admin_NewsType_List", new System.Data.SqlClient.SqlParameter[] {
                mySql.MakeInParam("@iClassID", SqlDbType.Int, 8,iClassId),
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) }, out ds);

            myDTC.DropDownListDataBind(this.myNewsClassList, ds.Tables[0]);
            this.DropDownListFindValue(myNewsClassList, iClassId);

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
                    this.First.NavigateUrl = "?Page=1"+"&CID="+iClassId;

                }
            }

            if (!objPds.IsFirstPage)
            {
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1)+"&CID="+iClassId;
            }
            if (!objPds.IsLastPage)
            {
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1) + "&CID=" + iClassId;
            }

            if (objPds.PageCount > CurPage)
            {
                Last.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + objPds.PageCount + "&CID=" + iClassId;
            }

        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string checkbox = myChar.RequestForm("checkbox");
        if (checkbox.Trim().Length == 0)
        {
            myJScript.AlertGoBack("请选择项！");
        }
        else
        {
            string[] checkboxArr = checkbox.Split(',');
            for (int i = 0; i < checkboxArr.Length; i++)
            {
                /*
                mySql.RunProc("sp_Admin_NewsType_Delete", new System.Data.SqlClient.SqlParameter[] {
                    mySql.MakeInParam("@ID", SqlDbType.Int, 8, checkboxArr[i]),
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) });
                */
                mySql.ExecSql(" delete from     N_NewsType WHERE     ID ="+checkboxArr[i]);

                mySql.ExecSql(" delete from     N_News  WHERE     iTypeID =" + checkboxArr[i]);

            }
        }
        //  myJScript.Alert("删除期刊成功！", myPath.currPath());
        myPath.Redirect(myPath.currPath());
    }
}