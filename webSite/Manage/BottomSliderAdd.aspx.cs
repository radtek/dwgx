using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_BottomSliderAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string savePath = Server.MapPath("/uploads/bottomSlider/");
        bool isOk = false;

        if (upFile.HasFile)
        {
            //检查路径是否存在
            if (!System.IO.Directory.Exists(savePath))
                System.IO.Directory.CreateDirectory(savePath);

            //检查上传的图片类型是否正确
            string extName = System.IO.Path.GetExtension(upFile.FileName).ToLower();
            string[] allowExtension = { ".jpg", ".jpeg", ".bmp", ".png" };
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (extName == allowExtension[i])
                {
                    isOk = true;
                    break;
                }
            }
            if (isOk)
            {
                string fullName = savePath + upFile.FileName;
                upFile.SaveAs(fullName);
                DWGX.Model.BottomAd _pic = new DWGX.Model.BottomAd();
                _pic.cPath = upFile.FileName;
                _pic.cUrl = edtUrl.Text;
                _pic.addTime = DateTime.Now;
                new DWGX.BLL.BottomAd().Add(_pic);
                Response.Write(new CommonClass().MessageBox("上传成功", "BottomSliderList.aspx"));
            }
            else
            {
                Response.Write(new CommonClass().MessageBox("只支持(.jpg/.jpeg/.bmp/.png)格式的文件"));
            }
        }
        else
        {
            Response.Write(new CommonClass().MessageBox("选择要上传的图片"));
        }
    }
}