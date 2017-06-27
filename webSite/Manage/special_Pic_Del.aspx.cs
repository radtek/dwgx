using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_special_Pic_Del : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int newId = int.Parse(Request.QueryString["Id"]);
        int typeId = int.Parse(Request.QueryString["TypeId"]);

        //清空数据库图片
        DWGX.Model.NewsType _newType = new DWGX.BLL.NewsType().GetModel(newId);
        if (_newType != null)
        {
            //删除本地文件
            string savePath = Server.MapPath("../uploads/SpecialImg/");//指定上传文件在服务器上的保存路径
                                                            //检查服务器上是否存在这个物理路径，如果不存在则创建
            savePath = savePath + _newType.cPic;

            if (System.IO.File.Exists(savePath))
            {
                System.IO.File.Delete(savePath);
            }


            _newType.cPic = "";
            new DWGX.BLL.NewsType().Update(_newType);
            Response.Write(new CommonClass().MessageBox("成功删除图片", "specialTypeEdit.aspx?id=" + newId+"&typeId="+ typeId));
        }
    }
}