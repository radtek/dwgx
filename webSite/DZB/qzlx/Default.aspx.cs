using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class qzlx_Default : XQiang.Page.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataSet ds = null;
        mySql.RunProc("sp_Index_qzlx_Default", out ds);




        //图片新闻
        string arr = "", str = "", myStr = "";
        int count = 0;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            arr = arr + ",'" + System.Convert.ToString(i + 1) + "'";
            str = str + "imgUrl[" + System.Convert.ToString(i + 1) + "]='/Uploadfile/News/" + ds.Tables[0].Rows[i]["cPicPath"].ToString() + "';\nimgLink[" + System.Convert.ToString(i + 1) + "]='News_View.aspx?id=" + ds.Tables[0].Rows[i]["id"].ToString() + "';\nimgText[" + System.Convert.ToString(i + 1) + "]='" + ds.Tables[0].Rows[i]["cTitle"].ToString() + "';\n";
            count = count + 1;
        }

        myStr = "var order=new Array(''" + arr + ");\nvar xb;\nvar cc;\ncc=" + count + ";\nvar pics=\"\";\nvar links=\"\";\nvar texts=\"\";\nvar imgUrl=new Array();\nvar imgLink=new Array();\nvar imgText=new Array();\n" + str;
        myNews0PicJs.Text = myStr;

        this.myNews0List.DataSource = ds.Tables[1];
        this.myNews0List.DataBind();

        this.myNews1List.DataSource = ds.Tables[2];
        this.myNews1List.DataBind();

        this.myNews2List.DataSource = ds.Tables[3];
        this.myNews2List.DataBind();

        this.myNews3List.DataSource = ds.Tables[4];
        this.myNews3List.DataBind();

        this.myNews4List.DataSource = ds.Tables[5];
        this.myNews4List.DataBind();

        this.myPicList0.DataSource = ds.Tables[6];
        this.myPicList0.DataBind();

    }
}