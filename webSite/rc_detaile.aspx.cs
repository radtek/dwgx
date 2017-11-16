using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class rc_detaile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlChecker SqlChecker = new SqlChecker(this.Request, this.Response, "http://" + BCW.Common.Utils.GetDomain());
        SqlChecker.Check();

        string pId = Request.QueryString["jobId"];

        if (string.IsNullOrEmpty(pId))
        {
            Response.Write(new CommonClass().MessageBox("参数错误", "index.aspx"));
            Response.End();
        }

        DWGX.Model.RcInfo rcInfoObj = new DWGX.BLL.RcInfo().GetModel(int.Parse(pId));
        if (rcInfoObj != null)
        {
            comnpanyId.Text = rcInfoObj.companyName;
            jobName.Text = rcInfoObj.jobName;
            jobType.Text = rcInfoObj.jobType;
            amount.Text = rcInfoObj.amount.ToString();
            sex.Text = rcInfoObj.sex == 0 ? "男" : rcInfoObj.sex == 1 ? "女" : "不限";
            age.Text = rcInfoObj.age.ToString();
            rofs.Text = rcInfoObj.rofs;
            major.Text = rcInfoObj.major;
            jobobject.Text = rcInfoObj.jobobject;
            titleRequire.Text = rcInfoObj.titleRequire;
            statureRequire.Text = rcInfoObj.statureRequire;
            areaRequire.Text = rcInfoObj.areaRequire;
            certificatesRequire.Text = rcInfoObj.certificatesRequire;
            createTime.Text = rcInfoObj.createTime.ToString("yyyy-MM-dd");
            significantInterval.Text = rcInfoObj.significantInterval;
            jobAddr.Text = rcInfoObj.jobAddr;
            salary.Text = rcInfoObj.salary.ToString();
            compnyAddr.Text = rcInfoObj.compnyAddr;
            phone.Text = rcInfoObj.phone;
            others.Text = rcInfoObj.others;
        }
    }
}