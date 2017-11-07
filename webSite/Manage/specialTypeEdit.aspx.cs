using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_specialTypeEdit : System.Web.UI.Page
{
    public int typeId;
    private int id;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }


        typeId = int.Parse(Request.QueryString["TypeId"]);
        id = int.Parse(Request.QueryString["ID"]);

        if (!IsPostBack)
        { 
            DWGX.Model.NewsType _specialType = new DWGX.BLL.NewsType().GetModel(id);
            cPic.Text = !string.IsNullOrEmpty(_specialType.cPic) ? string.Format("<a href='../uploads/SpecialImg/{0}'>uploads/SpecialImg/{0}</a>", _specialType.cPic) : "";
            delePic.Visible = !string.IsNullOrEmpty(_specialType.cPic);
            delePic.NavigateUrl = "special_Pic_Del.aspx?id=" + id+ "&typeId="+typeId;
            clbName.Text = _specialType.cTypeName.ToString();
            clbLinkUrl.Text = _specialType.linkUrl.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        DWGX.Model.NewsType _specialType = new DWGX.BLL.NewsType().GetModel(id);
        if (_specialType != null)
        {
            _specialType.cTypeName = clbName.Text;
            _specialType.linkUrl = clbLinkUrl.Text;
            //文件上传
            if (upLoadFile.HasFile)
            {
                string savePath = Server.MapPath("~/uploads/SpecialImg/");//指定上传文件在服务器上的保存路径
                                                                          //检查服务器上是否存在这个物理路径，如果不存在则创建
                if (!System.IO.Directory.Exists(savePath))
                {
                    System.IO.Directory.CreateDirectory(savePath);
                }
                savePath = savePath + "\\" + upLoadFile.FileName;
                upLoadFile.SaveAs(savePath);
                _specialType.cPic = upLoadFile.FileName;
            }

            new DWGX.BLL.NewsType().Update(_specialType);



            Response.Write(new CommonClass().MessageBox("编辑成功", "specialTypeList.aspx?TypeId=" + typeId));
        }


    }


}