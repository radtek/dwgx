using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_MemberInfoEdit : System.Web.UI.Page
{
    private int userId;
    public int newTypeRows;

    private List<string> lstLimit = new List<string>(); 
    
    protected void Page_Load(object sender, EventArgs e)
    {
        userId = int.Parse(Request.QueryString["id"]);

        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            bind();


        }
    }

    public void bind()
    {
        DWGX.Model.User _user = new DWGX.BLL.User().GetUser(userId);
        if (_user != null)
        {
            cAccount.Text = _user.name;
            cName.Text = _user.nickName;
            bValid.SelectedIndex = _user.isValid == true ? 1 : 2;
            dLastTime.Text = _user.lastLoginTime.ToString();
            cLastIp.Text = _user.lastLoginIP;
            iLoginCount.Text = _user.loginCount.ToString();
            dCreateTime.Text = _user.addDate.ToString();

            //权限处理
            string[] _arryLimit = _user.Limit.Split(',');
            List<string> _lstLimit = new List<string>(_arryLimit);            

            Setting_Users.Checked = _lstLimit.IndexOf(Setting_Users.ID) > -1;
            Setting_ChangePass.Checked = _lstLimit.IndexOf(Setting_ChangePass.ID) > -1;
            Setting_LogHandle.Checked = _lstLimit.IndexOf(Setting_LogHandle.ID) > -1;
            News_All.Checked = _lstLimit.IndexOf(News_All.ID) > -1;
            Info_All.Checked = _lstLimit.IndexOf(Info_All.ID) > -1;
            SYS_TUOPIAO.Checked = _lstLimit.IndexOf(SYS_TUOPIAO.ID) > -1;
            SYS_BOTTOMSLIDER.Checked = _lstLimit.IndexOf(SYS_BOTTOMSLIDER.ID) > -1;

            //信息管理权限
            DataSet _dsNewsType = new DWGX.BLL.NewsType().GetList("iShow=1 and parentId=0");
            if (_dsNewsType != null)
            {
                News_Count.RowSpan = _dsNewsType.Tables[0].Rows.Count+1;
                myNew_List.DataSource = _dsNewsType;                
                myNew_List.DataBind();


                foreach (RepeaterItem _item in myNew_List.Items)
                {
                    CheckBox cb = _item.FindControl("News_") as CheckBox;
                    string _attr = cb.Attributes["dataID"];
                    cb.Checked = _lstLimit.IndexOf("News_T" + _attr) > -1;
                 }
            }

            //内容管理权限
            DataSet _dsInfo = new DWGX.BLL.Info().GetList("*", "isShow=1");
            if (_dsInfo != null)
            {
                Info_Count.RowSpan = _dsInfo.Tables[0].Rows.Count+2;
                RepeaterInfo.DataSource = _dsInfo;
                RepeaterInfo.DataBind();
                
                foreach (RepeaterItem _item in RepeaterInfo.Items)
                {
                    CheckBox cb = _item.FindControl("Info_") as CheckBox;
                    string _attr = cb.Attributes["dataID"];
                    cb.Checked = _lstLimit.IndexOf("Info_T" + _attr) > -1;
                }
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        DWGX.Model.User _user = new DWGX.BLL.User().GetUser(userId);
        if (_user != null)
        {
            if (!string.IsNullOrEmpty(cPass.Text))
                _user.passWord = BCW.Common.Utils.MD5(cPass.Text);
            _user.nickName = cName.Text;
            _user.isValid = bValid.SelectedIndex == 1? true :false;
            _user.Limit = GetLimitStr();


            new DWGX.BLL.User().Update(_user);
            Response.Redirect("MemberEdit.aspx");
        }
    }

    public string GetLimitStr()
    {
        string _limitStr = "";
        if (Setting_Users.Checked)
            _limitStr += Setting_Users.ID + ",";
        if (Setting_ChangePass.Checked)
            _limitStr += Setting_ChangePass.ID + ",";
        if (Setting_LogHandle.Checked)
            _limitStr += Setting_LogHandle.ID + ",";
        if (News_All.Checked)
            _limitStr += News_All.ID + ",";
        if (Info_All.Checked)
            _limitStr += Info_All.ID + ",";
        if (SYS_TUOPIAO.Checked)
            _limitStr += SYS_TUOPIAO.ID + ",";
        if (SYS_BOTTOMSLIDER.Checked)
            _limitStr += SYS_BOTTOMSLIDER.ID + ",";

        //信息管理权限处理
        foreach (RepeaterItem _item in myNew_List.Items)
        {
            CheckBox cb = _item.FindControl("News_") as CheckBox;
            string _attr = cb.Attributes["dataID"];
            if (cb.Checked)
                _limitStr += "News_T" + _attr + ",";

        }

        //内容管理权限处理
        foreach (RepeaterItem _item in RepeaterInfo.Items)
        {
            CheckBox cb = _item.FindControl("Info_") as CheckBox;
            string _attr = cb.Attributes["dataID"];
            if (cb.Checked)
                _limitStr += "Info_T" + _attr + ",";

        }

        return _limitStr;
    }

    protected void SYS_Users_CheckedChanged(object sender, EventArgs e)
    {        
        SetLimet(sender, e);
    }

    private void SetLimet(object sender, EventArgs e)
    {
        Response.Write(((CheckBox)sender).ID);        
    }

}