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

public partial class LDAdmin_Pass_Change : XQiang.Page.AdminPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            System.Data.SqlClient.SqlDataReader dr = null;
            mySql.ExecSql("select * from U_Users where ID="+ao.ID , out dr);
            while (dr.Read())
            {
                this.cAccount.Text = dr["cAccount"].ToString();
                this.cName.Text = dr["cName"].ToString();
            }
            dr.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlParameter[] paras=new System.Data.SqlClient.SqlParameter[] { mySql.MakeOutParam("@Status",SqlDbType.Int,8),
            mySql.MakeInParam("@cAccount", SqlDbType.VarChar , 50, ao.cAccount ),
            mySql.MakeInParam("@AdminID", SqlDbType.Int, 8, ao.ID),
            mySql.MakeInParam("@cIP", SqlDbType.VarChar, 50, myPath.getClientIp()), 
            mySql.MakeInParam("@cOldPass", SqlDbType.VarChar, 50 , XQiang.Common.Fun_Class.Md5_Encrypt(myChar.RequestDataForm("cOldPass"))), 
            mySql.MakeInParam("@cNewPass", SqlDbType.VarChar, 50, XQiang.Common.Fun_Class.Md5_Encrypt( myChar.RequestDataForm("cNewPass"))), 
 mySql.MakeInParam("@cName", SqlDbType.VarChar, 50,myChar.RequestDataForm("cName")) };
        mySql.RunProc("sp_Admin_Pass_Change",paras  );
        if (System.Convert.ToInt16(paras[0].Value) == 1)
        {
            myJScript.Alert("修改新密码成功！", myPath.currPath());
        }
        else
        {
            myJScript.Alert("旧密码输入错误！", myPath.currPath());
        }
    }
}
