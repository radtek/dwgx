using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_Info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        string pId = Request.QueryString["id"];

        if (string.IsNullOrEmpty(pId))
        {
            Response.Write(new CommonClass().MessageBox("参数错误", "index.aspx"));
            Response.End();
        }

        //查询出对应的信息
        DWGX.Model.Info _info = new DWGX.BLL.Info().GetInfo(int.Parse(pId));
        if (_info != null)
        {
            cTitle.Text= _info.cMemo;
            cContent.Text = _info.cContent;
        }
    }
}