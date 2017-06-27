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
using System.IO;   //引入

public partial class manage_link_lindEdit : System.Web.UI.Page
{
    BaseClass bc = new BaseClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = bc.GetDataSet("select * from tbLink","tbLink");
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //删除服务器图片数据
        DataSet ds = bc.GetDataSet("select * from tbLink where id='"+GridView1.DataKeys[e.RowIndex].Value.ToString()+"'","tbLink");
        DataRow[] row = ds.Tables[0].Select();
        foreach (DataRow rs in row)  //将检索到的数据逐一,循环添加到Listbox1中
        {
            string picName=rs["picPath"].ToString();
            FileInfo file = new FileInfo(Server.MapPath("..") + "\\logo\\"+picName.Substring(picName.LastIndexOf("\\")+1));
            file.Delete();
        }
        //清除表记录
        bc.ExecSQL("delete from tbLink where id='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'");
        GridView1.DataSource = bc.GetDataSet("select * from tbLink", "tbLink");
        GridView1.DataBind();
    }
}
