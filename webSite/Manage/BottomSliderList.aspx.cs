using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;

public partial class Manage_BottomSliderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            bind();           
        }

       
    }

    public void bind()
    {
        DataSet _dsSpecialType = new DWGX.BLL.BottomAd().GetList("1=1");
        if (_dsSpecialType != null)
        {
            myDataList.DataSource = _dsSpecialType;
            myDataList.DataBind();
        }
        

    }

    [WebMethod]
    public static string DeleteSpecialData(string str)
    {
        string[] _arryUserId = str.Split(',');
        try
        {
            foreach (string _id in _arryUserId)
            {
                if (string.IsNullOrEmpty(_id))
                    continue;


                new DWGX.BLL.BottomAd().Delete(int.Parse(_id));

            }
            return "操作成功";
        }
        catch (Exception e)
        {
            return "操作失败:" + e.Message;
        }


    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
       
    }


    protected void myDataList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}