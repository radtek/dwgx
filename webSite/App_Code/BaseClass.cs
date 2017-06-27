using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Threading;
/// <summary>
/// BaseClass 的摘要说明
/// </summary>
//该源码下载自www.51asp.net

public class BaseClass
{
	public BaseClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 说明：MessageBox用来在客户端弹出对话框。
    /// 参数：TxtMessage 对话框中显示的内容。
    /// 创建日期：2006-1-20
    /// 创建人：张耀庭
    /// </summary>
    public string MessageBox(string TxtMessage)
    {
        string str;
        str = "<script language=javascript>alert('" + TxtMessage + "')</script>";
        return str;
    }
    /// <summary>
    /// 说明：ExecSQL用来执行SQL语句。
    ///	返回值：操作是否成功(True\False)。
    ///	参数：sQueryString SQL字符串
    /// 创建日期：2006-1-22
    /// 创建人：张耀庭
    /// </summary>
    public Boolean ExecSQL(string sQueryString)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]);
        con.Open();
        SqlCommand dbCommand = new SqlCommand(sQueryString, con);
        try
        {
            dbCommand.ExecuteNonQuery();
            con.Close();
        }
        catch
        {
            con.Close();
            return false;
        }
        return true;
    }
    /// <summary>
    /// 说明：GetDataSet数据集，返回数据源的数据集
    ///	返回值：数据集DataSet
    ///	参数：sQueryString SQL字符串，TableName 数据表名称
    /// 创建日期：2006-1-22
    /// 创建人：张耀庭
    /// </summary>
    public System.Data.DataSet GetDataSet(string sQueryString, string TableName)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]);
        con.Open();
        SqlDataAdapter dbAdapter = new SqlDataAdapter(sQueryString, con);
        DataSet dataset = new DataSet();
        dbAdapter.Fill(dataset, TableName);
        con.Close();
        return dataset;
    }
    /// <summary>
    /// 说明：SubStr用来将字符串保留到指定长度，将超出部分用“...”代替。
    /// 返回值：处理后的这符串。
    /// 参数：	sString原字符串。
    ///			nLeng长度。
    /// 创建日期：2006-02-22
    /// 创建人：张耀庭
    /// </summary>
    public string SubStr(string sString, int nLeng)
    {
        if (sString.Length <= nLeng)
        {
            return sString;
        }
        int nStrLeng = nLeng - 3;
        string sNewStr = sString.Substring(0, nStrLeng);
        sNewStr = sNewStr + "...";
        return sNewStr;
    }
    /// <summary>
    /// 说明:过滤危险字符
    /// 返回值：处理后的这符串。
    /// 参数：	str原字符串。
    /// 创建日期：2006-02-22
    /// 创建人：张耀庭
    /// </summary>

    public string HtmlEncode(string str)
    {
        str = str.Replace("&", "&amp;");
        str = str.Replace("<", "&lt;");
        str = str.Replace(">", "&gt");
        str = str.Replace("'", "''");
        str = str.Replace("*", "");
        str = str.Replace("\n", "<br/>");
        str = str.Replace("\r\n", "<br/>");
        //str = str.Replace("?","");
        str = str.Replace("select", "");
        str = str.Replace("insert", "");
        str = str.Replace("update", "");
        str = str.Replace("delete", "");
        str = str.Replace("create", "");
        str = str.Replace("drop", "");
        str = str.Replace("delcare", "");
        if (str.Trim().ToString() == "") { str = "无"; }
        return str.Trim();
    }
    /// <summary>
    /// 防止SQL 注入试攻击
    /// 
    /// </summary>
    /// <param name="loginName">用户登录名称</param>
    /// <param name="loginPwd">用户登录密码</param>
    /// 创建日期：2006-04-05
    /// 创建人：张耀庭
    public int checkLogin(string loginName,string loginPwd)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]);
        SqlCommand myCommand = new SqlCommand("select count(*) from tbuser where Name=@loginName and PassWord=@loginPwd", con);
        myCommand.Parameters.Add(new SqlParameter("@loginName", SqlDbType.NVarChar, 20));
        myCommand.Parameters["@loginName"].Value = loginName;
        myCommand.Parameters.Add(new SqlParameter("@loginPwd", SqlDbType.NVarChar, 20));
        myCommand.Parameters["@loginPwd"].Value = loginPwd;
        myCommand.Connection.Open();
        int i=(int)myCommand.ExecuteScalar();
        myCommand.Connection.Close();
        return i;
    }



}
