using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Global 的摘要说明
/// </summary>
public class Global
{
    public Global()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    protected void Application_BeginRequest(Object sender, EventArgs e)
    {       
        
        SqlChecker SqlChecker = new SqlChecker(HttpContext.Current.Request, HttpContext.Current.Response);
        //或 SqlChecker SqlChecker = new SqlChecker(this.Request,this.Response,safeUrl); 
        SqlChecker.Check();
    }
}