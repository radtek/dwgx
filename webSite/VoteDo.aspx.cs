using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;

public partial class VoteDo : System.Web.UI.Page
{
    public int voteType;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(Request.QueryString["ID"]))
                return;

            int _voteID = int.Parse(Request.QueryString["ID"]);        //投票ID
            string whereStr = " where iVoteID="+_voteID.ToString();

            DWGX.Model.Vote vote =  new DWGX.BLL.Vote().GetVote(_voteID);
            if (vote != null)
                voteType = (vote.cType == "单选" ? 0 : 1);

            //大旺新闻
            string _sqlStr;
            _sqlStr = "select ID,cName,iCount,dCreateTime from dbo.tb_VoteData " + whereStr + " order by ID";
            DataSet _dsVoteData = DWGX.Data.SqlHelper.Query(_sqlStr);
            rptVoteData.DataSource = _dsVoteData;
            rptVoteData.DataBind();


            //底部轮播图片
            DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
            bottomAd.DataSource = _dsBottomAd;
            bottomAd.DataBind();
        }
    }

    protected void btnVoteComit_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    //[WebMethod]
    //public static string CommitVote(string str)
    //{
    //    int voteId = 0;
    //    string[] _arryUserId = str.Split(',');
    //    try
    //    {
    //        foreach (string _Id in _arryUserId)
    //        {
    //            if (string.IsNullOrEmpty(_Id))
    //                continue;

    //            DWGX.Model.VoteData _voteData = new DWGX.BLL.VoteData().GetVoteData(int.Parse(_Id));
    //            if (_voteData != null)
    //            { 
    //                _voteData.iCount += 1;
    //                 new DWGX.BLL.VoteData().Update(_voteData);
    //                voteId = (int)_voteData.iVoteID;
    //            }
    //        }
    //        return voteId.ToString();
    //    }
    //    catch (Exception e)
    //    {
    //        return "投票失败:" + e.Message;
    //    }


    //}
}