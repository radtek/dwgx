using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_specialTypeAdd : System.Web.UI.Page
{
    public int typeId;

    protected void Page_Load(object sender, EventArgs e)
    {

        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        typeId = int.Parse(Request.QueryString["typeId"]);
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DWGX.Model.NewsType _specialType = new DWGX.Model.NewsType();
        _specialType.parentid = typeId;
        _specialType.cTypeName = clbName.Text;
        _specialType.iClassId = 1;
        _specialType.iDesc = 0;
        _specialType.dCreateTime = DateTime.Now;
        _specialType.cPic = "";
        _specialType.iShow = 1;

        //文件上传
        if (uploadFile.HasFile)
        {
            string savePath = Server.MapPath("~/uploads/SpecialImg/");//指定上传文件在服务器上的保存路径
                                                           //检查服务器上是否存在这个物理路径，如果不存在则创建
            if (!System.IO.Directory.Exists(savePath))
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
            savePath = savePath + "\\" + uploadFile.FileName;
            uploadFile.SaveAs(savePath);
            _specialType.cPic = uploadFile.FileName;
        }

        int id =  new DWGX.BLL.NewsType().Add(_specialType);

        Response.Write(new CommonClass().MessageBox("添加成功", "specialTypeList.aspx?TypeId=" + typeId));

    }
}