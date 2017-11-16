using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_RcInfo_Edit : System.Web.UI.Page
{
    private int rcId;

    protected void Page_Load(object sender, EventArgs e)
    {
        rcId = int.Parse(Request.QueryString["Id"]);

        if (!IsPostBack)
        {
            DWGX.Model.RcInfo rcInfoModel = new DWGX.BLL.RcInfo().GetModel(rcId);
            if (rcInfoModel != null)
            {
                edtCompanyName.Text = rcInfoModel.companyName;
                edtJobName.Text = rcInfoModel.jobName;
                edtJobType.Text = rcInfoModel.jobType;
                edtAmount.Text = rcInfoModel.amount.ToString();
                edtSex.SelectedValue =  rcInfoModel.sex.ToString();
                edtAge.Text = rcInfoModel.age.ToString();
                edtRofs.Text = rcInfoModel.rofs;
                edtMajor.Text = rcInfoModel.major;
                edtJobobject.Text = rcInfoModel.jobobject;
                edtTitleRequire.Text = rcInfoModel.titleRequire;
                edtStatureRequire.Text = rcInfoModel.statureRequire;
                edtAreaRequire.Text = rcInfoModel.areaRequire;
                edtCertificatesRequire.Text = rcInfoModel.certificatesRequire;
                edtSignificantInterval.Text = rcInfoModel.significantInterval;
                edtJobAddr.Text = rcInfoModel.jobAddr;
                edtSalary.Text = rcInfoModel.salary;
                edtCompnyAddr.Text = rcInfoModel.compnyAddr;
                edtPhone.Text = rcInfoModel.phone;
                edtOthers.Text = rcInfoModel.others.Replace("<br />", "\n"); 
                //myNewsType.Items.FindByValue(_newModel.iTypeId.ToString()).Selected = true;
                // cTitle.Text = _newModel.cTitle;
            }
          
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DWGX.Model.RcInfo rcInfoModel = new DWGX.BLL.RcInfo().GetModel(rcId);
        if (rcInfoModel != null)
        {
            rcInfoModel.companyName = edtCompanyName.Text;
            rcInfoModel.jobName = edtJobName.Text;
            rcInfoModel.jobType = edtJobType.Text;
            rcInfoModel.amount = int.Parse(edtAmount.Text);
            rcInfoModel.sex = int.Parse(edtSex.SelectedValue);
            rcInfoModel.age = int.Parse(edtAge.Text);
            rcInfoModel.rofs = edtRofs.Text;
            rcInfoModel.major = edtMajor.Text;
            rcInfoModel.jobobject = edtJobobject.Text;
            rcInfoModel.titleRequire = edtTitleRequire.Text;
            rcInfoModel.statureRequire = edtStatureRequire.Text;
            rcInfoModel.areaRequire = edtAreaRequire.Text;
            rcInfoModel.certificatesRequire = edtCertificatesRequire.Text;
            rcInfoModel.significantInterval = edtSignificantInterval.Text;
            rcInfoModel.jobAddr = edtJobAddr.Text;
            rcInfoModel.salary = edtSalary.Text;
            rcInfoModel.compnyAddr = edtCompnyAddr.Text;
            rcInfoModel.phone = edtPhone.Text;
            rcInfoModel.others = edtOthers.Text.Replace("\n", "<br />");
            rcInfoModel.updateTime = DateTime.Now;
            try
            { 
                 new DWGX.BLL.RcInfo().Update(rcInfoModel);
                Response.Write(new CommonClass().MessageBox("修改成功", "RcList.aspx"));
            }
            catch
            {
                Response.Write(new CommonClass().MessageBox("修改失败,请检查内容是否有非法值", string.Format("RcEdit.aspx?Id={1}",  rcId.ToString())));
            }
            
        }
        
    }


}