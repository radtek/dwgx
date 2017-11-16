using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MasterPageDwgx : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();
    }
}
