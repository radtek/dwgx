<%@ WebHandler Language="C#" Class="VoteDo" %>

using System;
using System.Web;
using System.Data;
using System.Web.Services;

public class VoteDo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int voteId = CommitVote(context.Request["Checkbox"]);

        context.Response.Redirect("VoteChart.aspx?voteId="+voteId.ToString());
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

    public int CommitVote(string str)
    {


        int voteId = 0;
        string[] _arryUserId = str.Split(',');

        foreach (string _Id in _arryUserId)
        {
            if (string.IsNullOrEmpty(_Id))
                continue;

            DWGX.Model.VoteData _voteData = new DWGX.BLL.VoteData().GetVoteData(int.Parse(_Id));
            if (_voteData != null)
            {
                _voteData.iCount += 1;
                new DWGX.BLL.VoteData().Update(_voteData);
                voteId = (int)_voteData.iVoteID;
            }
        }

        return voteId;
    }




}