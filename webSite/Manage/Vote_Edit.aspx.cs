using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Vote_Edit : System.Web.UI.Page
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

        if (myNewsClassList.SelectedIndex == 0)
        {
            Response.Write(new CommonClass().MessageBox("请选择投票类型"));
            myNewsClassList.Focus();
            return;
        }

        if (string.IsNullOrEmpty(cTitle.Text.Trim()))
        {
            Response.Write(new CommonClass().MessageBox("请填写投票名称"));
            cTitle.Focus();
            return;
        }

        if (pAct == "add")
        {
            string userName = Request.Cookies["Login"]["userName"];
            DWGX.Model.User _user = new DWGX.BLL.User().GetUser(userName);


            DWGX.Model.Vote _vote = new DWGX.Model.Vote();
            _vote.cTitle = cTitle.Text;
            _vote.cType = myNewsClassList.SelectedValue;
            _vote.dCreateTime = DateTime.Parse(dCreateTime.Text);
            _vote.iCreatorID = _user != null ? _user.id : 0;
            new DWGX.BLL.Vote().Add(_vote);
            Response.Write(new CommonClass().MessageBox("添加成功","Vote.aspx"));
        }
        else
        {
            int _voteId = int.Parse(Request.QueryString["ID"]);
            DWGX.Model.Vote _vote = new DWGX.BLL.Vote().GetVote(_voteId);
            if (_vote != null)
            {
                Response.Write(new CommonClass().MessageBox(cTitle.Text));
                _vote.cTitle = cTitle.Text;
                _vote.cType = myNewsClassList.SelectedValue;
                _vote.dCreateTime = DateTime.Parse(dCreateTime.Text);
                new DWGX.BLL.Vote().Update(_vote);
                Response.Write(new CommonClass().MessageBox("编辑成功", "Vote.aspx"));
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
        Button1.Text = "编辑";
        int _voteId = int.Parse(Request.QueryString["ID"]);

        DWGX.Model.Vote _vote = new DWGX.BLL.Vote().GetVote(_voteId);
        if (_vote != null)
        {
            cTitle.Text = _vote.cTitle;
            myNewsClassList.SelectedValue = _vote.cType;
            dCreateTime.Text = _vote.dCreateTime.ToString();
            
        }
    }
}