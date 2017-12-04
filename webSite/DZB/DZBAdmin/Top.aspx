<%@ page language="C#" autoeventwireup="true" inherits="IOAdmin_Top, App_Web_lekpraw3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
 <link href="Css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server"> <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="74" colspan="2" background="images/index1_03.gif">
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td width="33%" rowspan="2"><img src="images/index_01.jpg"   /></td>
          <td width="6%" rowspan="2">&nbsp;</td>
          <td width="61%" height="38" align="right">
            <table width="120" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="center"><img src="images/index1_06.gif" width="16" height="16" /></td>
                <td align="center" class="font2"><a href="http://www.zq3l.com" class="font2"><strong>帮助</strong></a></td>
                <td align="center"><img src="images/index1_08.gif" width="16" height="16" /></td>
                <td align="center" class="font2"><a href="Logout.aspx" target=_top class="font2"><strong>退出</strong></a></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr>
          <td align="right">
            <table  border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="right" class="font2"><a href="Main.aspx" target="Main"><img src="images/index1_13.gif" width="84" height="24" border="0" align="absmiddle" /></a></td><td>&nbsp;|&nbsp;登陆用户：<asp:Literal
                        ID="cAccount" runat="server"></asp:Literal>
                    | 身份：<asp:Literal ID="cName" runat="server">管理员</asp:Literal>
                    | 登录次数：<asp:Literal ID="iLoginCount" runat="server">1</asp:Literal> 次
                    | 最后登录时间：<asp:Literal ID="dLastTime" runat="server"></asp:Literal><a href="#"></a>&nbsp;</td>
              </tr>
            </table>
          </td>
        </tr>
      </table>
    </td>
  </tr></table>
  
    </form>
</body>
</html>
