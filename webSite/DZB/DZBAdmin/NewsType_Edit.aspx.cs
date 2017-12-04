using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DZBAdmin_NewsType_Edit : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string CID = myChar.RequestQueryString("CID");

           System.Data.DataSet  ds;
            mySql.RunProc("sp_Admin_NewsType_Add",
           new System.Data.SqlClient.SqlParameter[] {
 
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) },
               out ds);

            myDTC.DropDownListDataBind(myNewsClassList, ds.Tables[0]);
            
            this.DropDownListFindValue(myNewsClassList, CID);


            if (myChar.RequestQueryString("ID").Length > 0)
            {
                ID = myChar.RequestDataQueryString("ID");

                System.Data.SqlClient.SqlDataReader dr;
                mySql.RunProc("sp_Admin_NewsType_Edit",
               new System.Data.SqlClient.SqlParameter[] {
                 mySql.MakeInParam("@ID",SqlDbType.Int,0,ID),
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) },
                   out dr);
                while (dr.Read())
                {
                    this.cTypeName.Text = dr["cTypeName"].ToString();
                    this.cPic.Text = "<a href='/UploadFile/ProductClass/" + dr["cPic"].ToString() + "' target=_blank><img src='/UploadFile/ProductClass/" + dr["cPic"].ToString() + "' width=82 height=120 border=0></a><input type=hidden name=cOldPic value='" + dr["cPic"].ToString() + "'>";
                    this.dCreateTime.Text = dr["dCreateTime"].ToString();
                    this.DropDownListFindValue(myNewsClassList, dr["iClassID"].ToString());
                    this.myCreateTimeTr.Style["display"] = "";
                    this.Button1.Text = "编辑";
                }
                dr.Close();
            }
            else
            {
                this.dCreateTime.Text = System.DateTime.Now.ToString();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (myChar.RequestForm("myNewsClassList").Length == 0)
        {
            myJScript.AlertGoBack("请选择期刊!");
            return;
        }
        if (myChar.RequestQueryString("ID").Length == 0)
        {
            if (FileUpload1.PostedFile.ContentLength == 0)
            {
                myJScript.AlertGoBack("请选择上传版面图片！");
                return;
            }
            string _cPic = "";
            _cPic = myFuns.UpLoadPic(FileUpload1, XQiang.Common.Fun_Class.PicType.ProductClass);
            mySql.RunProc("sp_Admin_NewsType_Add_Submit",
                new System.Data.SqlClient.SqlParameter[] {
                 mySql.MakeInParam("@cTypeName", SqlDbType.VarChar, 50, myChar.RequestDataForm("cTypeName")),
                 mySql.MakeInParam("@iClassId",SqlDbType.Int ,0,myChar.RequestDataForm("myNewsClassList")),
                 mySql.MakeInParam("@dCreateTime",SqlDbType.DateTime,0,myChar.RequestDataForm("dCreateTime")),
                  mySql.MakeInParam("@cPic",SqlDbType.VarChar,50,_cPic),
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) }
                    );
            myJScript.Alert("添加版面成功！", myPath.currPath());
        }
        else
        {
            string _cPic = "";
            if (FileUpload1.PostedFile.ContentLength > 0)
            {
                _cPic = myFuns.UpLoadPic(FileUpload1, XQiang.Common.Fun_Class.PicType.ProductClass);
            }
            else
            {
                _cPic = myChar.RequestDataForm("cOldPic");
            }
            mySql.RunProc("sp_Admin_NewsType_Edit_Submit",
               new System.Data.SqlClient.SqlParameter[] {
                 mySql.MakeInParam("@cTypeName", SqlDbType.VarChar, 50, myChar.RequestDataForm("cTypeName")),
                 mySql.MakeInParam("@iClassId",SqlDbType.Int ,0,myChar.RequestDataForm("myNewsClassList")),
                 mySql.MakeInParam("@dCreateTime",SqlDbType.DateTime,0,myChar.RequestDataForm("dCreateTime")),
                  mySql.MakeInParam("@cPic",SqlDbType.VarChar,50,_cPic),
                  mySql.MakeInParam("@ID", SqlDbType.Int, 8, myChar.RequestDataQueryString("ID")),
                mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
                mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()) }
                   );
            myJScript.Alert("编辑版面成功！", myPath.currPath());
        }
        

    }
}