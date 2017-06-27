using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Manage_VoteData_Edit : System.Web.UI.Page
{
    private string pAct;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }


        pAct = Request.QueryString["pAct"];

        if (!IsPostBack)
        { 
        if (pAct == "add")
            AddVote();
        else
            EditVote();
         }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cTitle.Text.Trim()))
        {
            Response.Write(new CommonClass().MessageBox("请填写投票名称"));
            cTitle.Focus();
            return;
        }

        if (Regex.IsMatch(iCount.Text, @"^\d*$") == false)
        {
            Response.Write(new CommonClass().MessageBox("请输入正确的投票次数"));
            iCount.Focus();
            return;
        }

        if (pAct == "add")
        {
            int _VID = int.Parse(Request.QueryString["VID"]);            

            DWGX.Model.VoteData _voteData = new DWGX.Model.VoteData();
            _voteData.cName = cTitle.Text;
            _voteData.iCount = int.Parse(iCount.Text);
            _voteData.dCreateTime = DateTime.Parse(dCreateTime.Text);
            _voteData.iVoteID = _VID;
            new DWGX.BLL.VoteData().Add(_voteData);
            Response.Write(new CommonClass().MessageBox("添加成功", "VoteData_List.aspx?VID=" + _VID));
        }
        else
        {
            int _ID = int.Parse(Request.QueryString["ID"]);

            DWGX.Model.VoteData _voteData = new DWGX.BLL.VoteData().GetVoteData(_ID);
            if (_voteData != null)
            {
                _voteData.cName = cTitle.Text;
                _voteData.iCount = int.Parse(iCount.Text);
                _voteData.dCreateTime = DateTime.Parse(dCreateTime.Text);
                new DWGX.BLL.VoteData().Update(_voteData);
              Response.Write(new CommonClass().MessageBox("编辑成功", "VoteData_List.aspx?VID="+ _voteData.iVoteID));
            }
        }
    }

    private void AddVote()
    {
        Button1.Text = "添加";
        dCreateTime.Text = DateTime.Now.ToString();
    }

    private void EditVote()
    {
        myTitle.Text = "编辑投票";
        Button1.Text = "编辑";
        int _ID = int.Parse(Request.QueryString["ID"]);

        DWGX.Model.VoteData _voteData = new DWGX.BLL.VoteData().GetVoteData(_ID);
        if (_voteData != null)
        {
            cTitle.Text = _voteData.cName;
            iCount.Text = _voteData.iCount.ToString();
            dCreateTime.Text = _voteData.dCreateTime.ToString();

        }
    }
}