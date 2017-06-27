using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class NewDetail : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Form.Target = "_blank";
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
                Response.Write("<script>window.open('" + _new.cUrl + "','_blank');</script>");
                Response.Write("<script>window.history.go(-1);</script>");
            }

            hasVideo = !string.IsNullOrEmpty(_new.cVideoPath);
            videoPath = string.IsNullOrEmpty(_new.cVideoPath) ? "" : _new.cVideoPath;
            newTitle.InnerHtml = _new.cTitle;
            newSource.Text = _new.cLittleTitle + "&nbsp;发布日期：" + DateTime.Parse(_new.dCreateTime.ToString()).ToString("yyyy/MM/dd H:mm:ss");
            newContent.InnerHtml = _new.cContent;

            //设置导航栏
            DWGX.Model.NewsType _newType = new DWGX.BLL.NewsType().GetModel(_new.iTypeId == null ? 0 : (int)_new.iTypeId);
            if (_newType != null)
            {
                navTitle.Text = string.Format("<a href=\"class.aspx?TypeId={0}&toolTip={1}\">{2}</a>", _newType.ID,_newType.cTypeName, _newType.cTypeName);
            }
        }

        //底部轮播图片
        DataSet _dsBottomAd = new DWGX.BLL.BottomAd().GetList("1=1");
        bottomAd.DataSource = _dsBottomAd;
        bottomAd.DataBind();
    }

    public bool hasVideo { get; set; }
    public string videoPath { get; set; }
}