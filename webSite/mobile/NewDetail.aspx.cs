using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_NewDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string pId = Request.QueryString["id"];

        if (string.IsNullOrEmpty(pId))
        {
            Response.Write(new CommonClass().MessageBox("参数错误", "index.aspx"));
            Response.End();
        }

        //查询出对应的信息
        DWGX.Model.News _new = new DWGX.BLL.News().GetNews(int.Parse(pId));
        if (_new != null)
        {
            //如果有跳转地址，则跳转到目标地址
            if (string.IsNullOrEmpty(_new.cUrl) == false)
            {
                Response.Redirect(_new.cUrl);
                //Response.Write("<script>window.open('" + _new.cUrl + "');</script>");               
            }

            cTitle.Text = _new.cTitle;
            newSource.Text = _new.cLittleTitle + "&nbsp;发布日期：" + DateTime.Parse(_new.dCreateTime.ToString()).ToString("yyyy/MM/dd H:mm:ss");
            cContent.Text= _new.cContent;

        }
    }
}