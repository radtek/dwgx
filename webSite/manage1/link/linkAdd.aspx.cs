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

public partial class manage_link_linkAdd : System.Web.UI.Page
{
    BaseClass bc = new BaseClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filePath= this.FileUpload1.PostedFile.FileName;  　　　　　　　　 //获取文件完整路径
        if (filePath == "")
        {
            Response.Write(bc.MessageBox("请选择上传图片！"));
            return;
        }
        string fileName = filePath.Substring(filePath.LastIndexOf("\\")+1);　　　//文件名称
        string s=Server.MapPath("..\\logo"+"\\"+fileName);　　　//将客户端文件保存到服务器logo文件夹中
        FileUpload1.SaveAs(s);
        bc.ExecSQL("INSERT INTO tbLink(picPath, linkName, linkAddress, addDate)VALUES ('" + "~\\manage\\logo\\" + fileName + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + DateTime.Now.ToString() + "')");
        Response.Write(bc.MessageBox("数据添加成功!"));
    }
}
