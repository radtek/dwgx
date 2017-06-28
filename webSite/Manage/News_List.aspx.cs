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
    public string reqTypeId;
    public string reqTypeName;
    public string reqSeekTitle;
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
        //新闻列表

        reqTypeId = Request.QueryString["TypeId"];
        reqSeekTitle = Request.QueryString["seekStr"];
        string whereStr = " where N.iTypeId = NT.ID";
        reqTypeName = CommonClass.UrlEnCode(Request.QueryString["cTypeName"], System.Text.Encoding.UTF8);

        //如果是专题专栏，则跳转到专题专栏类别
        if (reqTypeId != null && (int.Parse(reqTypeId) == 5 || int.Parse(reqTypeId) == 31))
        {
            Response.Redirect("specialTypeList.aspx?TypeId="+ reqTypeId);
            return;  
        }


        if (string.IsNullOrEmpty(reqTypeId) == false)
            whereStr += string.Format(" and N.iTypeId = {0} ", reqTypeId);

        if (string.IsNullOrEmpty(reqSeekTitle) == false)
            whereStr += string.Format(" and cTitle like '%{0}%' ", reqSeekTitle);

        string _str = "select N.*,NT.cTypeName from tb_News N,tb_NewsType Nt "+whereStr+" order by N.dCreateTime desc";
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
                lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId="+ reqTypeId + "&seekStr="+ reqSeekTitle + "&Page=" + Convert.ToString(CurrentPage - 1);
            } 
            //   如果不是最后一页，通过参数Page设置下一页为当前页+1，否则不显示连接
            if (!pds.IsLastPage)
            {
                //    Request.CurrentExecutionFilePath为当前请求虚拟路径
                lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(CurrentPage + 1);
            }
            //首页
            First.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(1);
            //尾页
            Last.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&page=" + pds.PageCount.ToString(); 

            if (Convert.ToInt32(HttpContext.Current.Request["page"]) > pds.PageCount)
            {

                First.NavigateUrl = Request.CurrentExecutionFilePath + "?TypeId=" + reqTypeId + "&seekStr=" + reqSeekTitle + "&Page=" + Convert.ToString(1);
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
            foreach (string _newId in _arryUserId)
            {
                if (string.IsNullOrEmpty(_newId))
                    continue;

                new DWGX.BLL.News().Delete(int.Parse(_newId));
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