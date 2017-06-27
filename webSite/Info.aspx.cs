using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Detaile : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        string pId = Request.QueryString["id"];

        if (string.IsNullOrEmpty(pId))
        {
            Response.Write(new CommonClass().MessageBox("参数错误","index.aspx"));
            Response.End();
        }

        //查询出对应的信息
        DWGX.Model.Info _info = new DWGX.BLL.Info().GetInfo(int.Parse(pId));
        if (_info != null)
        {
            infoTitle.InnerHtml = _info.cMemo;
            infoContent.InnerHtml = _info.cContent;
        }

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();
    }
 
}