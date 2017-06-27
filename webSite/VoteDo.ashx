﻿<%@ WebHandler Language="C#" Class="VoteDo" %>

using System;
using System.Web;
using System.Data;
using System.Web.Services;

public class VoteDo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write(context.Request.Form["pAct"]);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }


    [WebMethod]
    public static string CommitVote(string str)
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
        return voteId.ToString();
    }




}