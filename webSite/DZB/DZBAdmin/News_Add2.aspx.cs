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

public partial class LDAdmin_News_Add2 : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string ClassID = "0", TypeID="0";
            if (myChar.RequestQueryString("CID").Length > 0)
            {
                ClassID = myChar.RequestQueryString("CID");
            }
           
            DataSet ds=null;
            mySql.RunProc("sp_Admin_News_Add2",
                new System.Data.SqlClient.SqlParameter[] { 
                    mySql.MakeInParam("@ClassID", SqlDbType.Int, 8, ClassID),
                   
                    mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                    mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp())
                }, out ds);
          
          

     
                myDTC.DropDownListDataBind(this.myNewsType, ds.Tables[0]);
                this.DropDownListFindValue(this.myNewsType, TypeID);
           

            myDTC.DropDownListDataBind(this.cTitleSize, myDTC.ForeSize());

         

            this.DropDownListFindValue(this.myNewsType, myChar.RequestQueryString("TId"));

            this.dCreateTime.Text = System.DateTime.Now.ToString();
 

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cTitleShow = "", cNTS0 = "", cNTS1 = "", cNTS2 = "", cNTS3 = "";
        if (this.cTitleShow0.Checked)
        {
            cNTS0 = "0";
        }
        if (this.cTitleShow1.Checked)
        {
            cNTS1 = "1";
        }
        if (this.cTitleShow2.Checked)
        {
            cNTS2 = "2";
        }
        if (this.cTitleShow2.Checked)
        {
            cNTS3 = "3";
        }
        cTitleShow = cNTS0 + "|" + cNTS1 + "|" + cNTS2 + "|" + cNTS3;

        string cIsNew = "", cNIN0 = "", cNIN1 = "", cNIN2 = "", cNIN3 = "";
        if (this.cIsNew0.Checked)
        {
            cNIN0 = "0";
        }
        if (this.cIsNew1.Checked)
        {
            cNIN1 = "1";
        }
        if (this.cIsNew2.Checked)
        {
            cNIN2 = "2";
        }
        if (this.cIsNew3.Checked)
        {
            cNIN3 = "3";
        }
        cIsNew = cNIN0 + "|" + cNIN1 + "|" + cNIN2 + "|" + cNIN3;

        string _cPicPath = "",_cVideoPath="";
        if (FileUpload1.PostedFile.ContentLength > 0)
        {
            _cPicPath = myFuns.UpLoadPic(FileUpload1, XQiang.Common.Fun_Class.PicType.News);
        }
        if (FileUpload2.PostedFile.ContentLength > 0)
        {
            _cVideoPath = myFuns.UpLoadVideo(FileUpload2);
        }
        mySql.RunProc("sp_Admin_News_Add_Submit2", new System.Data.SqlClient.SqlParameter[] {mySql.MakeInParam("@cTitle",SqlDbType.VarChar,200,myChar.RequestDataForm("cTitle")),mySql.MakeInParam("@dCreateTime",SqlDbType.DateTime,8,myChar.RequestDataForm("dCreateTime")),
            mySql.MakeInParam("@cTitleColor",SqlDbType.VarChar,10,myChar.RequestForm("cTitleColor")),mySql.MakeInParam("@cTitleB",SqlDbType.VarChar,2,myChar.RequestForm("cTitleB")),
            mySql.MakeInParam("@cLittleTitle",SqlDbType.VarChar,200,myChar.RequestForm("cLittleTitle")),
            mySql.MakeInParam("@cTitleU",SqlDbType.VarChar,2,myChar.RequestForm("cTitleU")),mySql.MakeInParam("@cTitleSize",SqlDbType.VarChar,10,myChar.RequestForm("cTitleSize")),mySql.MakeInParam("@cTitleShow",SqlDbType.VarChar,10,cTitleShow),mySql.MakeInParam("@cIP",SqlDbType.VarChar,50,myPath.getClientIp()),
        mySql.MakeInParam("@AdminId",SqlDbType.Int,4,ao.ID),mySql.MakeInParam("@iTypeId",SqlDbType.Int,0,myChar.RequestDataForm("myNewsType")),
        mySql.MakeInParam("@cContent",SqlDbType.Text,0,FCKeditor1.Value ),
        mySql.MakeInParam("@cPicPath",SqlDbType.VarChar,200,_cPicPath),
        mySql.MakeInParam("@cVideoPath",SqlDbType.VarChar,200,_cVideoPath),
        mySql.MakeInParam("@iPut",SqlDbType.Bit,1,this.iPut.Checked)
        });

        myPath.Redirect("News_List2.aspx?CID=" + myChar.RequestQueryString("CID") + "&TypeID=" + myChar.RequestQueryString("TID") + "&Name=" + myChar.RequestQueryString("Name"));
    }
    
}
