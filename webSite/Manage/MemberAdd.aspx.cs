using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using BCW.Common;


public partial class Manger_MemberAdd : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            DataSet _dsNewsType = new DWGX.BLL.NewsType().GetList("iShow=1");
            if (_dsNewsType != null)
            {
                News_Count.RowSpan = _dsNewsType.Tables[0].Rows.Count+1;
                myNew_List.DataSource = _dsNewsType;
                myNew_List.DataBind();
            }

            //内容管理权限
            DataSet _dsInfo = new DWGX.BLL.Info().GetList("*", "isShow=1");
            if (_dsInfo != null)
            {
                Info_Count.RowSpan = _dsNewsType.Tables[0].Rows.Count;
                RepeaterInfo.DataSource = _dsInfo;
                RepeaterInfo.DataBind();
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        cAccount.Text = "";
        cPass.Text = "";
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

        if (cAccount.Text == "")
        {
            Response.Write(CC.MessageBox("请输入用户帐号！", "MemberAdd.aspx"));
            return;
        }
        if (cPass.Text == "")
        {
            Response.Write(CC.MessageBox("登录密码不能为空！", "MemberAdd.aspx"));
            return;
        }
        if (cName.Text == "")
        {
            Response.Write(CC.MessageBox("用户昵称不能为空！", "MemberAdd.aspx"));
            return;
        }
        if (bValid.SelectedIndex == 0)
        {
            Response.Write(CC.MessageBox("请指定该用户是否有效！", "MemberAdd.aspx"));
            return;
        }

        else
        {
            int IntUserIn = CC.checkLogin(cAccount.Text.Trim(), this.cPass.Text.Trim());
            if (IntUserIn > 0)
            {
                Response.Write(CC.MessageBox("该管理员名已存在！", "MemberAdd.aspx"));
            }
            else
            {

                DWGX.Model.User _user = new DWGX.Model.User();
                _user.name = cAccount.Text;
                _user.passWord =Utils.MD5(cPass.Text);
                _user.nickName = cName.Text;
                _user.addDate = DateTime.Now;
                _user.lastLoginTime = DateTime.Now;
                _user.lastLoginIP = BCW.Common.Utils.GetUsIP();
                _user.Limit = GetLimitStr();
                _user.isValid = true;

                //权限管理

                new DWGX.BLL.User().Add(_user);

                //CC.ExecSQL("INSERT INTO tb_User( Name, PassWord) VALUES ('" + this.txtName.Text.Trim() + "', '" + this.txtPass.Text.Trim() + "')");

                Response.Write(CC.MessageBox("添加成功！", "MemberAdd.aspx"));
            }
        }
    }

    public string GetLimitStr()
    {
        string _limitStr = "";
        if (SYS_Users.Checked)
            _limitStr += SYS_Users.ID + ",";
        if (SYS_ChangePass.Checked)
            _limitStr += SYS_ChangePass.ID + ",";
        if (SYS_LogHandle.Checked)
            _limitStr += SYS_LogHandle.ID + ",";
        if (Boss_GuestList.Checked)
            _limitStr += Boss_GuestList.ID + ",";
        if (News_All.Checked)
            _limitStr += News_All.ID + ",";
        if (Info_All.Checked)
            _limitStr += Info_All.ID + ",";

        //权限处理
        foreach (RepeaterItem _item in myNew_List.Items)
        {
            CheckBox cb = _item.FindControl("myCheck") as CheckBox;
            string _attr = cb.Attributes["dataID"];
            if (cb.Checked)
                _limitStr += "News_T" + _attr+",";

        }

        //内容管理权限处理
        foreach (RepeaterItem _item in RepeaterInfo.Items)
        {
            CheckBox cb = _item.FindControl("myInfoCheck") as CheckBox;
            string _attr = cb.Attributes["dataID"];
            if (cb.Checked)
                _limitStr += "Info_T" + _attr + ",";

        }

        return _limitStr;
    }
}
