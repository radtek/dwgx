<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReView.aspx.cs" Inherits="ReView" %>

<%@ Register src="UC/Bottom.ascx" tagname="Bottom" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>期刊回顾</title>      
<meta name="keywords" content="大旺通讯电子报" />
<meta name="description" content="大旺通讯电子报" />
<link href="images/style.css" rel="stylesheet" type="text/css" />
<script src="js/jquery-1.4.2.min.js" type="text/javascript"></script>
<script src="js/jq_scroll.js" type="text/javascript"></script>
<script src="js/tip_tool.js" type="text/javascript"></script>
<link href="images/main.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <DIV id="main_cont">
	<div class="main_logo"><img src="images/logo.png"   /></div>
    <div class="review_list">
    <ul>
    <asp:Repeater ID="myDataList" runat=server>
    <ItemTemplate><li><p><a href="default.Aspx?tid=<%#Eval("TID") %>"><img src="/uploadFile/productclass/<%#Eval("tcPic") %>"></a></p><span><a href="default.Aspx?tid=<%#Eval("TID") %>"><%#Eval("cClassName") %></a></span></li></ItemTemplate>
    </asp:Repeater>
</ul>
<table width="98%" border="0" cellspacing="0" cellpadding="0">
  <tr height="35">
    <td align="center">
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
   <uc1:Bottom ID="Bottom1" runat="server" />

    </div>
  
 

    </form>
</body>
</html>
