using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_News_Edit : System.Web.UI.Page
{
    private int newId;
    private int typeId;

    protected void Page_Load(object sender, EventArgs e)
    {
        newId = int.Parse(Request.QueryString["Id"]);

        if (!IsPostBack)
        {
            //初始化
            //DataSet _dsNewsType = new DWGX.BLL.NewsType().GetList("ID,cTypeName", "iShow=1");
            //myNewsType.Items.Clear();
            //myNewsType.DataSource = _dsNewsType;
            //myNewsType.DataTextField = "cTypeName";
            //myNewsType.DataValueField = "ID";
            //myNewsType.DataBind();
            dCreateTime.Text = DateTime.Now.ToString();

            DWGX.Model.News _newModel = new DWGX.BLL.News().GetNews(newId);
            if (_newModel != null)
            {
                typeId = (int)_newModel.iTypeId;

                //myNewsType.Items.FindByValue(_newModel.iTypeId.ToString()).Selected = true;
                cTitle.Text = _newModel.cTitle;
                cLittleTitle.Text = _newModel.cLittleTitle;
                cUrl.Text = _newModel.cUrl;
                isPut.Checked = _newModel.isPut;
                isScrollPic.Checked = _newModel.isScrollPic;
                dCreateTime.Text = _newModel.dCreateTime.ToString();
                FCKeditor1.Value = _newModel.cContent;
                cPutPicPath.Text = !string.IsNullOrEmpty(_newModel.cPicPath) ? string.Format("<a href='../uploads/{0}'>uploads/{0}</a>", _newModel.cPicPath):"";
                cVideoImgPath.Text = !string.IsNullOrEmpty(_newModel.cPutPicPath) ? string.Format("<a href='../uploads/videoImg/{0}'>uploads/videoImg/{0}</a>", _newModel.cPutPicPath) : "";
                cVideoPath.Text = !string.IsNullOrEmpty(_newModel.cVideoPath) ? string.Format("<a href='../uploads/Video/{0}' target='_blank'>uploads/Video/{0}</a>", _newModel.cVideoPath) : "";
                delePic.Visible = !string.IsNullOrEmpty(_newModel.cPicPath);
                delePic.NavigateUrl = "News_Pic_Del.aspx?act=scroll&id="+newId;
                deleVideoPic.Visible = !string.IsNullOrEmpty(_newModel.cPutPicPath);
                deleVideoPic.NavigateUrl = "News_Pic_Del.aspx?act=video&id=" + newId;
            }
          
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DWGX.Model.News _newModel = new DWGX.BLL.News().GetNews(newId);
        if (_newModel != null)
        {
            //_newModel.iTypeId = int.Parse(myNewsType.SelectedValue);
            _newModel.cTitle = cTitle.Text.Trim();
            _newModel.cLittleTitle = cLittleTitle.Text.Trim();
            _newModel.cUrl = cUrl.Text.Trim();
            _newModel.isPut = isPut.Checked;
            _newModel.isScrollPic = isScrollPic.Checked;
            _newModel.dCreateTime = DateTime.Parse(dCreateTime.Text);
            _newModel.cContent = FCKeditor1.Value;            

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
                cPutPicPath.Text = string.Format("<a href='uploads/{0}'>uploads/{0}</a>", FileUpload3.FileName);
                _newModel.cPicPath = FileUpload3.FileName;
            }

            //高新电视台视频图
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
                _newModel.cPutPicPath = upLoadVideoImg.FileName;
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
                cPutPicPath.Text = string.Format("<a href='uploads/Video/{0}'>uploads/Video/{0}</a>", videoUpLoad.FileName);
                _newModel.cVideoPath = videoUpLoad.FileName;
            }


            new DWGX.BLL.News().Update(_newModel);

            //查找类别名称
            DWGX.Model.NewsType _newType = new DWGX.BLL.NewsType().GetModel((int)_newModel.iTypeId);

            Response.Write(new CommonClass().MessageBox("修改成功", string.Format("News_List.aspx?Name={0}&TypeId={1}", CommonClass.UrlEnCode(_newType.cTypeName, System.Text.Encoding.UTF8), _newModel.iTypeId)));
        }
        //  Response.Write(new CommonClass().MessageBox(myNewsType.SelectedValue.ToString()));
    }

    public int newsTypeId
    {
        get { return typeId; }
    }

}