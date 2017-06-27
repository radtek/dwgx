using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCW.Common;

public partial class Manage_Info_Edit : System.Web.UI.Page
{
    private int infoId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }


        infoId = int.Parse(Request.QueryString["Id"]);


        if (!IsPostBack)
        {
            DWGX.Model.Info info = new DWGX.BLL.Info().GetInfo(infoId);
            if (info != null)
            {
                cTitle.Text = info.cMemo;
                FCKeditor1.Value = info.cContent;
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DWGX.Model.Info info = new DWGX.BLL.Info().GetInfo(infoId);
        if (info != null)
        {
            info.cContent = FCKeditor1.Value;
            new DWGX.BLL.Info().Update(info);
            Response.Write(new CommonClass().MessageBox("操作成功"));
        }
    }
}