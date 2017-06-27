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
using BCW.Common;
using System.Text;

/// <summary>
/// CommonClass 的摘要说明
/// </summary>
public class CommonClass
{
	public CommonClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 连接数据库
    /// </summary>
    /// <returns>返回SqlConnection对象</returns>
    public SqlConnection GetConnection()
    {        
        string myStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        return myConn;
    }
    /// <summary>
    /// 说明：MessageBox用来在客户端弹出对话框。
    /// 参数：TxtMessage 对话框中显示的内容。
    /// 参数：Url 对话框关闭后，跳转的页
    /// </summary>
    public string MessageBox(string TxtMessage,string Url)
    {
        string str;
        str = "<script language=javascript>alert('" + TxtMessage + "');location='" + Url + "'</script>";
        return str;
    }
    /// <summary>
    /// 说明：MessageBox用来在客户端弹出对话框。
    /// 参数：TxtMessage 对话框中显示的内容。
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
    ///	参数：sqlStr SQL字符串
    /// </summary>
    public Boolean ExecSQL(string sqlStr)
    {
        SqlConnection myConn = GetConnection();
        myConn.Open();
        SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
        try
        {
            myCmd.ExecuteNonQuery();
            myConn.Close();
        }
        catch
        {
            myConn.Close();
            return false;
        }
        return true;
    }
    /// <summary>
    /// 说明：GetDataSet数据集，返回数据源的数据集
    ///	返回值：数据集DataSet
    ///	参数：sqlStr SQL字符串，TableName 数据表名称
    /// </summary>
    public System.Data.DataSet GetDataSet(string sqlStr, string TableName)
    {
        SqlConnection myConn =GetConnection();
        myConn.Open();
        SqlDataAdapter adapt = new SqlDataAdapter(sqlStr, myConn);
        DataSet ds = new DataSet();
        adapt.Fill(ds, TableName);
        myConn.Close();
        return ds;
    }
    /// <summary>
    /// 防止SQL 注入式攻击
    /// 
    /// </summary>
    /// <param name="loginName">用户登录名称</param>
    /// <param name="loginPwd">用户登录密码</param>
    public int checkLogin(string loginName, string loginPwd)
    {
        SqlConnection myConn = GetConnection();
        SqlCommand myCmd = new SqlCommand("select count(*) from tb_User where Name=@loginName and PassWord=@loginPwd and isValid=1", myConn);
        myCmd.Parameters.Add(new SqlParameter("@loginName", SqlDbType.VarChar, 20));
        myCmd.Parameters["@loginName"].Value = loginName;
        myCmd.Parameters.Add(new SqlParameter("@loginPwd", SqlDbType.VarChar, 50));
        myCmd.Parameters["@loginPwd"].Value = Utils.MD5(loginPwd);
        myConn.Open();
        int i = (int)myCmd.ExecuteScalar();
        myCmd.Dispose();
        myConn.Close();
        return i;
    }
    /// <summary>
    /// 实现随机验证码
    /// </summary>
    /// <param name="n">显示验证码的个数</param>
    /// <returns>返回生成的随机数</returns>
    public string RandomNum(int n) //
    {
        //定义一个包括数字、大写英文字母和小写英文字母的字符串
        string strchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        //将strchar字符串转化为数组
        //String.Split 方法返回包含此实例中的子字符串（由指定Char数组的元素分隔）的 String 数组。
        string[] VcArray = strchar.Split(',');
        string VNum = "";
        //记录上次随机数值，尽量避免产生几个一样的随机数           
        int temp = -1;                       
        //采用一个简单的算法以保证生成随机数的不同
        Random rand = new Random();
        for (int i = 1; i < n + 1; i++)
        {
            if (temp != -1)
            {
                //unchecked 关键字用于取消整型算术运算和转换的溢出检查。
                //DateTime.Ticks 属性获取表示此实例的日期和时间的刻度数。
                rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
            }
            //Random.Next 方法返回一个小于所指定最大值的非负随机数。
            int t = rand.Next(61);
            if (temp != -1 && temp == t)
            { 
                return RandomNum(n);
            }
            temp = t;
            VNum += VcArray[t];
        }
        return VNum;//返回生成的随机数
    }

    public static string UrlEnCode(string str, System.Text.Encoding _type)
    {
        return System.Web.HttpUtility.UrlEncode(str, _type);
    }

    public static string UrlDeCode(string str, System.Text.Encoding _type)
    {
        return System.Web.HttpUtility.UrlDecode(str, _type);
    }

    /// <summary>
    /// 截取中英文混合字符串
    /// </summary>
    /// <param name="text">字符文本</param>
    /// <param name="length">截取长度</param>
    /// <param name="replacetxt">replacetxt替换的多余字符</param>
    /// <returns></returns>
    public static string GetString(string text, int length, string replacetxt)
    {
        int strLength = 0;
        StringBuilder strb = new StringBuilder();
        char[] Temp = text.ToCharArray();
        for (int i = 0; i != Temp.Length; i++)
        {
            if (strLength >= length) //
            {
                strb.Append(replacetxt);
                break;
            }
            else
            {
                if (((int)Temp[i]) < 255) //大于255的都是汉字或者特殊字符
                {
                    strLength++;
                }
                else
                {
                    strLength = strLength + 2;
                }
                strb.Append(Temp[i]);
            }
        }
        return strb.ToString();
    }


    /// <summary>
    /// 这个方法可以实现去除html标签的功能。ength参数可以根据传入值取固定长度的值。用于生成文章摘要比较方便。
    /// </summary>
    /// <param name="html"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string ReplaceHtmlTag(string html, int length = 0)
    {
        string strText = System.Text.RegularExpressions.Regex.Replace(html, "<[^>]+>", "");
        strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");

        if (length > 0 && strText.Length > length)
            return strText.Substring(0, length);

        return strText;
    }

    #region 直接在DataSet(数据集)中分页

    /// <summary>
    /// 直接在DataSet(数据集)中分页
    /// </summary>
    /// <param name="ds">DataSet</param>
    /// <param name="PageNum">每页显示条数</param>
    /// <param name="InPage">第几页</param>
    /// <returns></returns>
    public static DataSet SplitDataSet(DataSet ds, int InPage, int PageNum)
    {
        DataSet vds = new DataSet();
        vds = ds.Clone();
        int fromIndex = PageNum * (InPage - 1);
        int toIndex = PageNum * InPage - 1;
        for (int i = fromIndex; i <= toIndex; i++)
        {
            if (i >= ds.Tables[0].Rows.Count)
                break;
            vds.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
        }
        ds.Dispose();
        return vds;
    }
    #endregion
}
