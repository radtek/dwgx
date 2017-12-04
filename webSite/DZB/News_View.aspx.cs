using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class News_View : XQiang.Page.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string TID = "0";
        System.Data.DataSet ds = null;


        if (myChar.RequestQueryString("TID").Length > 0)
        {
            TID = myChar.RequestQueryString("TID");
        }
        mySql.RunProc("sp_Index_NewsView",
                new System.Data.SqlClient.SqlParameter[] { 
                    mySql.MakeInParam("@TID", SqlDbType.Int, 8, TID) ,
                    mySql.MakeInParam("@ID",SqlDbType.Int,8,myChar.RequestDataQueryString("ID"))
                }, out ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            this.myPic.Src = "/uploadfile/productclass/" + dr["cPic"].ToString();
        }
        this.myMap.DataSource = ds.Tables[1];
        this.myMap.DataBind();

       

        this.myNewsType.DataSource = ds.Tables[2];
        this.myNewsType.DataBind();
        /*
        if (ds.Tables[3].Rows.Count > 0)
            this.myCurrClass.Text = ds.Tables[3].Rows[0]["cClassName"].ToString();

        if (ds.Tables[4].Rows.Count > 0)
            this.myUpClass.NavigateUrl = "Default.aspx?TID=" + ds.Tables[4].Rows[0][0].ToString();
        if (ds.Tables[5].Rows.Count > 0)
            this.myDownClass.NavigateUrl = "Default.aspx?TID=" + ds.Tables[5].Rows[0][0].ToString();
        */
        if (ds.Tables[6].Rows.Count > 0)
            this.myUpType.NavigateUrl = "Default.aspx?TID=" + ds.Tables[6].Rows[0][0].ToString();
        if (ds.Tables[7].Rows.Count > 0)
            this.myDownType.NavigateUrl = "Default.aspx?TID=" + ds.Tables[7].Rows[0][0].ToString();

        if (ds.Tables[8].Rows.Count > 0)
            this.myUpNews.NavigateUrl = "Default.aspx?TID=" + ds.Tables[8].Rows[0][0].ToString();
        if (ds.Tables[9].Rows.Count > 0)
            this.myDownNews.NavigateUrl = "Default.aspx?TID=" + ds.Tables[9].Rows[0][0].ToString();

        if (ds.Tables[10].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[10].Rows[0];
            this.cTitle.Text = dr["cTitle"].ToString();
            this.cContent.Text = dr["cContent"].ToString();
            this.dCreateTime.Text = dr["dCreateTime"].ToString();

            this.Title = this.Title + " -- " + dr["cTitle"].ToString();
        }
    }
}