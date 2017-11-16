using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using XQiang.Page;
using System.Web.Services;

public partial class Manage_News_List : System.Web.UI.Page
{
    private int CurrentPage;

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录 
        if (Request.Cookies["login"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            this.bindData();
        }
    }

    private void bindData()
    {
        //招聘列表

        string _str = "select * from tb_RcInfo order by updateTime desc";
        DataSet _dsNews = DWGX.Data.SqlHelper.Query(_str);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = _dsNews.Tables[0].DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 20;

        if (Request.QueryString["Page"] != null)
        {

            CurrentPage = Convert.ToInt32(Request.QueryString["Page"]);
        }
        else
        {
            CurrentPage = 1;
        }

        
        if (_dsNews != null)
        {
            pds.CurrentPageIndex = CurrentPage - 1;       //     当前页所引为页码-1
          //  dangqian.Text = CurrentPage.ToString();       //     当前页
            if (!pds.IsFirstPage)
            {
                //            Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage - 1);
            } 
            //   如果不是最后一页，通过参数Page设置下一页为当前页+1，否则不显示连接
            if (!pds.IsLastPage)
            {
                //    Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurrentPage + 1);
            }
            //首页
            First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(1);
            //尾页
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + pds.PageCount.ToString(); 

            if (Convert.ToInt32(HttpContext.Current.Request["page"]) > pds.PageCount)
            {

                First.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(1);
            }


            PageCount.Text = pds.PageCount.ToString();
            lblCurrentPage.Text = (CurrentPage).ToString();
            myCount.Text = _dsNews.Tables[0].Rows.Count.ToString();

            myDataList.DataSource = pds;
            myDataList.DataBind();
        }

    }

    public string getStrByLen(string str, int len)
    {
        if (str.Length >= len)
            return str.Substring(0, len) + "..";
        return str;
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        
    }

    [WebMethod]
    public static string DeleteNews(string str)
    {
        string[] _arryUserId = str.Split(',');
        try
        {
            foreach (string rcId in _arryUserId)
            {
                if (string.IsNullOrEmpty(rcId))
                    continue;

                new DWGX.BLL.RcInfo().Delete(int.Parse(rcId));
            }
            return "操作成功";
        }
        catch (Exception e)
        {
            return "操作失败:" + e.Message;
        }

        
    }

    public void FindData_Click()
    {
        Response.Write("查找 ");
    }


}