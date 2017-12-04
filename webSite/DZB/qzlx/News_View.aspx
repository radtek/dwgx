<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_View.aspx.cs" Inherits="qzlx_News_View" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>

<%@ Register src="Bottom.ascx" tagname="Bottom" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    <link href="Css/Base.css" rel="stylesheet" type="text/css" />
<link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="Js/jquery-1.3.1.min.js"></script>
       <script language=javascript src="js/Init.js"></script>
         <script type="text/javascript" src="Js/MSClass.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <uc1:Top ID="Top1" runat="server" />
          <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td align="center" style="text-align:center">
    
    

    <table width="999" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td  align="left" valign="top"><div class="Border"  >
      <table width="100%" border="0" align="center" cellpadding="3" cellspacing="3">
        <tr>
          <td class="Font_14 Font_B" style="text-align:center" height="30">
              <asp:Literal ID="cTitle" runat="server"></asp:Literal>
            </td>
        </tr>
         <td   >
              <div align=center style="width:100%; border-bottom:1px; border-bottom-color:#ccc; border-bottom-style:solid;"></div>
            </td>
        </tr>
        <tr>
          <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
            <tr>
              <td  >
              <div style="  line-height:18px; text-align:left;" > 
 
                  <asp:Literal ID="cContent" runat="server"></asp:Literal>

              </div>
 

              
              </td>
              </tr>
          </table></td>
        </tr>
      </table>
    </div></td>
     
      </tr>
    </table>
    
    
    
    
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
  </table>
    

    <uc2:Bottom ID="Bottom1" runat="server" />
    
    </div>
    </form>
</body>
</html>
