using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_News_Add : System.Web.UI.Page
{
    private string act;
    private int typeId;
    private string typeName;

    protected void Page_Load(object sender, EventArgs e)
    {
        typeId = int.Parse(Request.QueryString["TId"]);
        typeName = Request.QueryString["TName"];
        if (!IsPostBack)
        { 
            ////初始化
            //DataSet _dsNewsType = new DWGX.BLL.NewsType().GetList("ID,cTypeName", "iShow=1");
            //myNewsType.Items.Clear();
            //myNewsType.DataSource = _dsNewsType;
            //myNewsType.DataTextField = "cTypeName";
            //myNewsType.DataValueField = "ID";        
            //myNewsType.DataBind();
            dCreateTime.Text = DateTime.Now.ToString();
            //myNewsType.Items.FindByValue(typeId.ToString()).Selected = true;
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DWGX.Model.News newInfo = new DWGX.Model.News();
        newInfo.iTypeId = typeId;//int.Parse(myNewsType.SelectedValue);
        newInfo.cTitle = cTitle.Text.Trim();
        newInfo.cLittleTitle = cLittleTitle.Text.Trim();
        newInfo.cUrl = cUrl.Text.Trim();
        newInfo.isPut = isPut.Checked;
        newInfo.isScrollPic = isScrollPic.Checked;
        newInfo.dCreateTime = DateTime.Parse(dCreateTime.Text);
        newInfo.cContent = FCKeditor1.Value;
        newInfo.cTitleColor = "";
        newInfo.cTitleB = "";
        newInfo.cTitleU = "";
        newInfo.cTitleSize = "";
        newInfo.cTitleShow = "";
        newInfo.iViewCount = 0;
        newInfo.cPicPath = "";
        newInfo.cVideoPath = "";
        newInfo.cPutPicPath = "";


        //滚动文件上传
        if (FileUpload3.HasFile)
        {
            string savePath = Server.MapPath("~/uploads/");//指定上传文件在服务器上的保存路径
                                                           //检查服务器上是否存在这个物理路径，如果不存在则创建
            if (!System.IO.Directory.Exists(savePath))
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
            savePath = savePath + "\\" + FileUpload3.FileName;
            FileUpload3.SaveAs(savePath);
            newInfo.cPicPath = FileUpload3.FileName;
        }

        //如果是高新电视台
        if (upLoadVideoImg.HasFile)
        {
            string savePath = Server.MapPath("~/uploads/videoImg/");//指定上传文件在服务器上的保存路径
                                                           //检查服务器上是否存在这个物理路径，如果不存在则创建
            if (!System.IO.Directory.Exists(savePath))
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
            savePath = savePath + "\\" + upLoadVideoImg.FileName;
            upLoadVideoImg.SaveAs(savePath);
            newInfo.cPutPicPath = upLoadVideoImg.FileName;
        }

        //视频上传
        if (videoUpLoad.HasFile)
        {
            string savePath = Server.MapPath("~/uploads/Video");//指定上传文件在服务器上的保存路径
                                                                //检查服务器上是否存在这个物理路径，如果不存在则创建
            if (!System.IO.Directory.Exists(savePath))
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
            savePath = savePath + "\\" + videoUpLoad.FileName;
            videoUpLoad.SaveAs(savePath);
            newInfo.cVideoPath = videoUpLoad.FileName;
        }

        new DWGX.BLL.News().Add(newInfo);
         Response.Write(new CommonClass().MessageBox("添加成功",string.Format("News_List.aspx?Name={0}&TypeId={1}",CommonClass.UrlEnCode(typeName,System.Text.Encoding.UTF8), typeId)));
      //  Response.Write(new CommonClass().MessageBox(myNewsType.SelectedValue.ToString()));
    }

    protected void myNewsType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    public int newsTypeId
    {
        get { return typeId; }
    }
    
}