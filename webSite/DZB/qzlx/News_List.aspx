<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_List.aspx.cs" Inherits="qzlx_News_List" %>

<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>

<%@ Register src="Bottom.ascx" tagname="Bottom" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>肇庆国家高新区群众路线网</title>
    <link href="Css/Base.css" rel="stylesheet" type="text/css" />
<link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="Js/jquery-1.3.1.min.js"></script>
       <script language=javascript src="js/Init.js"></script>
         <script type="text/javascript" src="Js/MSClass.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<style>
BODY {
	BORDER-BOTTOM-STYLE: none; PADDING-BOTTOM: 0px; BORDER-RIGHT-STYLE: none; MARGIN: 0px; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; BORDER-TOP-STYLE: none; BORDER-LEFT-STYLE: none; PADDING-TOP: 0px
}
UL {
	BORDER-BOTTOM-STYLE: none; PADDING-BOTTOM: 0px; BORDER-RIGHT-STYLE: none; MARGIN: 0px; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; BORDER-TOP-STYLE: none; BORDER-LEFT-STYLE: none; PADDING-TOP: 0px
}
OL {
	BORDER-BOTTOM-STYLE: none; PADDING-BOTTOM: 0px; BORDER-RIGHT-STYLE: none; MARGIN: 0px; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; BORDER-TOP-STYLE: none; BORDER-LEFT-STYLE: none; PADDING-TOP: 0px
}

</style>
</head>
<body>
    <form id="form1" runat="server">
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
      <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td style="background-image:url(images/title.jpg);height:33px;width:999px;" class="Font_14 Font_B Font_White"> &nbsp;
              <asp:Literal ID="cTypeName" runat="server"></asp:Literal>
              &nbsp;</td>
        </tr>
        <tr>
          <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
            <tr>
              <td  >
              <div style="padding:5px; margin 0px auto" > 

                 <asp:Repeater ID="myDataList" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="4" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),22) %></a></td><td width="120"><%#Eval("dCreateTime").ToString() %></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater>
     <br /><table width="98%" border="0" cellspacing="0" cellpadding="0">
  <tr height="35">
    <td  style="text-align:right">
&nbsp;<asp:HyperLink ID="First" runat="server">首页</asp:HyperLink>
                                      &nbsp; &nbsp;
                                      <asp:HyperLink ID="lnkPrev" runat="server">上一页</asp:HyperLink>
                                      &nbsp; &nbsp;
                                      <asp:HyperLink ID="lnkNext" runat="server">下一页</asp:HyperLink>
                                      &nbsp; &nbsp;
                                      <asp:HyperLink ID="Last" runat="server">尾页</asp:HyperLink>
                                      &nbsp; &nbsp;当前页码：
                                      <asp:Literal ID="lblCurrentPage" runat="server"></asp:Literal>／<asp:Literal ID="PageCount"
                                          runat="server"></asp:Literal>页 &nbsp;&nbsp; 记录总数：<asp:Literal ID="myCount" runat="server"></asp:Literal>
                                      条  </td>
  </tr>
</table>
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
    

    </form>
</body>
</html>
