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

public partial class IOAdmin_Left : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        myNewsTypeList.ItemDataBound += new RepeaterItemEventHandler(myNewsTypeList_ItemDataBound);
        myNewsTypeList.DataSource = mySql.getDs("select * from N_NewsType where (iClassID=1 or iClassID=2) and ishow=1 order by iClassId");
        myNewsTypeList.DataBind();

        myNewsTypeList2.DataSource = mySql.getDs("select * from N_NewsType2 where (iClassID=1) and ishow=1 order by iClassId");
        myNewsTypeList2.DataBind();
    }

 
    void myNewsTypeList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemIndex > -1)
        {
            if(ao.cLimit.IndexOf("News_T"+DataBinder.Eval(e.Item.DataItem,"ID").ToString())==-1){
                ((System.Web.UI.HtmlControls.HtmlTableRow)e.Item.FindControl("myNewsShow")).Style["display"]="none";
            }
        }
    }
}
