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

public partial class LDAdmin_News_Edit2 : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = null;

            string ClassID = "0", TypeID = "0";
            if (myChar.RequestQueryString("CID").Length > 0)
            {
                ClassID = myChar.RequestQueryString("CID");
            }
 
        

         

            
            mySql.RunProc("sp_Admin_News_Edit2", new System.Data.SqlClient.SqlParameter[] { mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID), mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()), mySql.MakeInParam("@ID", SqlDbType.Int, 8, myChar.RequestQueryString("ID")) }, out ds);

         

            myDTC.DropDownListDataBind(this.cTitleSize, myDTC.ForeSize());
 
              
               myDTC.DropDownListDataBind(this.myNewsType, ds.Tables[2]);
            if (ds.Tables[1].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[1].Rows[0];
               
                this.DropDownListFindValue(this.myNewsType,dr["iTypeID"].ToString());
 
                this.cTitle.Text=dr["cTitle"].ToString();
             
                this.cTitleColor.Text = dr["cTitleColor"].ToString();
                this.dCreateTime.Text = dr["dCreateTime"].ToString();

               

                if (dr["cTitleB"].ToString() == "on")
                {
                    this.cTitleB.Checked = true;
                }
                if (dr["cTitleU"].ToString() == "on")
                {
                    this.cTitleU.Checked = true;
                }
                string cTitleShow = dr["cTitleShow"].ToString();
                if (cTitleShow.IndexOf("0") != -1)
                {
                    this.cTitleShow0.Checked = true;
                }
                if (cTitleShow.IndexOf("1") != -1)
                {
                    this.cTitleShow1.Checked = true;
                }
                if (cTitleShow.IndexOf("2") != -1)
                {
                    this.cTitleShow2.Checked = true;
                }
                if (cTitleShow.IndexOf("3") != -1)
                {
                    this.cTitleShow3.Checked = true;
                }
                this.iViewCount.Text = dr["iViewCount"].ToString();
                this.DropDownListFindValue(this.cTitleSize, dr["cTitleSize"].ToString());

                this.cPicPath.Text = dr["cPicPath"].ToString() + "<input type=hidden name='cOldPicPath' value='" + dr["cPicPath"].ToString() + "' />";
                this.cPicPath.NavigateUrl = "/UploadFile/News/" + dr["cPicPath"].ToString();
                this.cVideoPath.Text = dr["cVideoPath"].ToString() + "<input type=hidden name='cOldVideoPath' value='" + dr["cVideoPath"].ToString() + "' />"; ;
                this.cVideoPath.NavigateUrl = "/UploadFile/Video/" + dr["cVideoPath"].ToString();

                this.iPut.Checked = System.Convert.ToBoolean(dr["iPut"]);
 
                this.FCKeditor1.Value = dr["cContent"].ToString();
            }

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
        
        cIsNew = cNIN0 + "|" + cNIN1 + "|" + cNIN2 + "|" + cNIN3;


        string _cPicPath = "", _cVideoPath = "";
        if (FileUpload1.PostedFile.ContentLength > 0)
        {
            _cPicPath = myFuns.UpLoadPic(FileUpload1, XQiang.Common.Fun_Class.PicType.News);
            if (myChar.RequestForm("cOldPicPath").Length > 0)
            {
                myFuns.DelPic(myChar.RequestForm("cOldPicPath"), XQiang.Common.Fun_Class.PicType.News);
            }
        }
        else
        {
            _cPicPath = myChar.RequestForm("cOldPicPath");
        }
        if (FileUpload2.PostedFile.ContentLength > 0)
        {
            _cVideoPath = myFuns.UpLoadVideo(FileUpload2);
            if (myChar.RequestForm("cOldVideoPath").Length > 0)
            {
                myFuns.DelFile("UploadFile/Video/" + myChar.RequestForm("cOldVideoPath"));
            }
        }
        else
        {
            _cVideoPath = myChar.RequestForm("cOldVideoPath");
        }
        mySql.RunProc("sp_Admin_News_Edit_Submit2", new System.Data.SqlClient.SqlParameter[] {mySql.MakeInParam("@cTitle",SqlDbType.VarChar,200,myChar.RequestDataForm("cTitle")),mySql.MakeInParam("@dCreateTime",SqlDbType.DateTime,8,myChar.RequestDataForm("dCreateTime")),
            mySql.MakeInParam("@cTitleColor",SqlDbType.VarChar,10,myChar.RequestForm("cTitleColor")),mySql.MakeInParam("@cTitleB",SqlDbType.VarChar,2,myChar.RequestForm("cTitleB")),
            mySql.MakeInParam("@cLittleTitle",SqlDbType.VarChar,200,myChar.RequestForm("cLittleTitle")),
            mySql.MakeInParam("@cTitleU",SqlDbType.VarChar,2,myChar.RequestForm("cTitleU")),mySql.MakeInParam("@cTitleSize",SqlDbType.VarChar,10,myChar.RequestForm("cTitleSize")),mySql.MakeInParam("@cTitleShow",SqlDbType.VarChar,10,cTitleShow),mySql.MakeInParam("@cIP",SqlDbType.VarChar,50,myPath.getClientIp()),
        mySql.MakeInParam("@AdminId",SqlDbType.Int,4,ao.ID),mySql.MakeInParam("@iTypeId",SqlDbType.Int,4,myChar.RequestDataForm("myNewsType")),mySql.MakeInParam("@cContent",SqlDbType.Text,0,FCKeditor1.Value ),mySql.MakeInParam("@Id",SqlDbType.Int,8,myChar.RequestQueryString("ID"))
       , mySql.MakeInParam("@cPicPath",SqlDbType.VarChar,200,_cPicPath),
         mySql.MakeInParam("@cVideoPath",SqlDbType.VarChar,200,_cVideoPath),
         mySql.MakeInParam("@iPut",SqlDbType.Bit,1,this.iPut.Checked)
         });


        myJScript.Alert("编辑新闻成功！", "News_List2.aspx?CID=" + myChar.RequestQueryString("CID") + "&TID=" + myChar.RequestQueryString("TID") + "&Name=" + myChar.RequestQueryString("Name"));
    }
 
}
