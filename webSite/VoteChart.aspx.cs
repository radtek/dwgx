using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class VoteChart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int _voteID = int.Parse(Request.QueryString["voteId"]);
        string whereStr = " where iVoteID=" + _voteID.ToString();

        string _sqlStr;
        _sqlStr = "select ID,cName,iCount,dCreateTime from dbo.tb_VoteData " + whereStr + " order by ID";
        DataSet _dsVoteData = DWGX.Data.SqlHelper.Query(_sqlStr);
        chartVote.DataSource = _dsVoteData;
        chartVote.Series[0].XValueMember = "cName";
        chartVote.Series[0].YValueMembers = "iCount";
        chartVote.DataBind();

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();

    }

    protected void Chart1_Load(object sender, EventArgs e)
    {

    }
}