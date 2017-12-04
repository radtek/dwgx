using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class qzlx_News_View : XQiang.Page.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlDataReader dr = null;

        mySql.RunProc("sp_Index_qzlx_News_View", new System.Data.SqlClient.SqlParameter[] { mySql.MakeInParam("@ID", System.Data.SqlDbType.Int, 0, myChar.RequestDataQueryString("ID")) }, out dr);

        while (dr.Read())
        {
            this.Title = dr["cTitle"].ToString();
            this.cTitle.Text = this.Title;
            this.cContent.Text = dr["cContent"].ToString();
        }
        dr.Close();
    }
}