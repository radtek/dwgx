using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class mobile_speciaTypelList : System.Web.UI.Page
{
    public string reqTypeId;
    public string reqTypeName;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        if (!IsPostBack)
        { 
            reqTypeId = Request.QueryString["TypeId"];

            string whereStr = " where parentId=" + reqTypeId;

            //大旺新闻
            string _sqlStr;
            _sqlStr = "select * from tb_NewsType " + whereStr + " order by dCreateTime desc";
            DataSet _dsNewsType = DWGX.Data.SqlHelper.Query(_sqlStr);
            rptNews.DataSource = _dsNewsType;
            rptNews.DataBind();
        }
    }
}