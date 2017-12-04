using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class LDAdmin_News_List : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = null;
            string fn = "",classId="0",typeId="0";

            if (myChar.RequestQueryString("findText").Length > 0)
            {
                fn = myChar.RequestQueryString("findText");
                this.findText.Text = fn;
            }


            if (myChar.RequestQueryString("CID").Length > 0)
            {
                classId = System.Convert.ToInt32(myChar.RequestQueryString("CID")).ToString();
                
            }
            if (myChar.RequestQueryString("TID").Length > 0)
            {
                typeId = System.Convert.ToInt32(myChar.RequestQueryString("TID")).ToString();

            }
             

            mySql.RunProc("sp_Admin_News_List", new System.Data.SqlClient.SqlParameter[] { mySql.MakeInParam("@classId", SqlDbType.Int, 8, classId), mySql.MakeInParam("@typeId", SqlDbType.Int, 8, typeId),  mySql.MakeInParam("@findText", SqlDbType.VarChar, 100, fn), mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID), mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) }, out ds);

           

            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                this.myNewsClass.Items.Add(new ListItem(ds.Tables[1].Rows[i]["cClassName"].ToString(), ds.Tables[1].Rows[i]["id"].ToString()));
            }

            this.DropDownListFindValue(myNewsClass, classId);

            if (myChar.RequestQueryString("CID").Length > 0)
            {

                if (ds.Tables.Count > 3)
                {
                    for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
                    {
                        this.myNewsType.Items.Add(new ListItem(ds.Tables[3].Rows[i]["cTypeName"].ToString(), ds.Tables[3].Rows[i]["id"].ToString()));
                    }

                    this.DropDownListFindValue(myNewsType, typeId);
                }
                
            }




            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ds.Tables[2].DefaultView;


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

              if (objPds.PageCount > 1){
                   if( CurPage != 1){
                        this.First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=1&cId=" + classId + "&TId=" + typeId + "&findText=" + fn;

                   }
              }

                if( !objPds.IsFirstPage){
                    lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1) + "&cId=" + classId + "&TId=" + typeId + "&findText=" + fn;
                }
                if( !objPds.IsLastPage){
                    lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1) + "&cId=" + classId + "&TId=" + typeId + "&findText=" + fn;
                }

                if (objPds.PageCount > CurPage)
                {
                     Last.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + objPds.PageCount + "&cId=" + classId + "&TId=" + typeId + "&findText=" + fn;
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

                mySql.RunProc("sp_Admin_News_List_Delete", new System.Data.SqlClient.SqlParameter[] { mySql.MakeInParam("@ID", SqlDbType.Int, 8, checkboxArr[i]), mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID), mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) });
               
            } myJScript.Alert("删除新闻成功！", myPath.currPath());
        }
    }
}
