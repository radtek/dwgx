using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : XQiang.Page.BasePage
{ 
  public   static string TID = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataSet ds = null;
	TID=myChar.RequestQueryString("TID");

        if ((TID.Length > 0) && (TID!="0"))
        {
            TID = myChar.RequestQueryString("TID");
        }
        else
        {
            TID = "0";
        }
        mySql.RunProc("sp_Index_Default",
                new System.Data.SqlClient.SqlParameter[] { 
                    mySql.MakeInParam("@TID", SqlDbType.Int, 8, TID) 
                }, out ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            this.myPic.Src = "/uploadfile/productclass/" + dr["cPic"].ToString();
this.myTT.Text =  dr["cTypeName"].ToString();
        }
        if (TID == "0")
        {
            TID = ds.Tables[8].Rows[0][0].ToString();
        }

        this.myMap.DataSource = ds.Tables[1];
        this.myMap.DataBind();

        this.myNewsList.DataSource = ds.Tables[1];
        this.myNewsList.DataBind();

        this.myNewsType.DataSource = ds.Tables[2];
        this.myNewsType.DataBind();

        if (ds.Tables[3].Rows.Count > 0)
        {
            this.myCurrClass.Text = ds.Tables[3].Rows[0]["cClassName"].ToString();
            this.Title = this.Title + " -- " + this.myCurrClass.Text;
        }

        if( ds.Tables[4].Rows.Count>0)
        this.myUpClass.NavigateUrl = "?TID=" + ds.Tables[4].Rows[0][0].ToString();
        if (ds.Tables[5].Rows.Count > 0)
        this.myDownClass.NavigateUrl = "?TID=" + ds.Tables[5].Rows[0][0].ToString();

        if (ds.Tables[6].Rows.Count > 0)
            this.myUpType.NavigateUrl = "?TID=" + ds.Tables[6].Rows[0][0].ToString();
        if (ds.Tables[7].Rows.Count > 0)
            this.myDownType.NavigateUrl = "?TID=" + ds.Tables[7].Rows[0][0].ToString();

    
    }

    public string CurrType(object TID, object ID)
    {
        string cu = "";
        if (TID.ToString() == ID.ToString())
        {
            cu = "Font_B";
        }

        return cu;
    }
}