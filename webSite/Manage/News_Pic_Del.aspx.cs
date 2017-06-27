using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_News_Pic_Del : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = Request.QueryString["act"];
        int newId = int.Parse(Request.QueryString["Id"]);

        //清空数据库图片
        DWGX.Model.News _new = new DWGX.BLL.News().GetNews(newId);
        string savePath = "";
        if (_new != null)
        {
            if (act == "scroll")
            {
                //删除本地文件
                savePath = Server.MapPath("../uploads/");//指定上传文件在服务器上的保存路径
                                                                //检查服务器上是否存在这个物理路径，如果不存在则创建
                savePath = savePath + _new.cPicPath;
                _new.cPicPath = "";
            }
            else
            {
                //删除本地文件
                savePath = Server.MapPath("../uploads/videoImg/");//指定上传文件在服务器上的保存路径
                                                                //检查服务器上是否存在这个物理路径，如果不存在则创建
                savePath = savePath + _new.cPutPicPath;
                _new.cPutPicPath = "";
            }
            

            if (System.IO.File.Exists(savePath))
            {
                System.IO.File.Delete(savePath);
            }
            
            
            new DWGX.BLL.News().Update(_new);
            Response.Write( new CommonClass().MessageBox("成功删除图片", "News_Edit.aspx?id="+newId));
        }
    }
}