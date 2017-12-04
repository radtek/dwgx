<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="IOAdmin_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="Css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" border="0" cellspacing="10" cellpadding="0">
                <tr>
                    <td width="70%" valign="top">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td width="8" height="8">
                                    <img src="images/index1_23.gif" width="8" height="29" /></td>
                                <td width="99%" background="images/index1_24.gif">
                                </td>
                                <td width="8" height="8">
                                    <img src="images/index1_26.gif" width="8" height="29" /></td>
                            </tr>
                            <tr>
                                <td background="images/index1_45.gif">
                                </td>
                                <td bgcolor="#FFFFFF" style="padding: 0 2px 0 2px; vertical-align: top; height: 500px;">
                                    <table width="200" border="0" cellpadding="0" cellspacing="5">
                                        <% if (ao.cLimit.IndexOf("|SYS_") != -1)
                                           { %>
                                        <tr>
                                            <td width="16%" align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td width="84%">
                                                系统设置</td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                &nbsp;</td>
                                            <td>
                                                <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                    <% if (ao.cLimit.IndexOf("|SYS_Users|") != -1)
                                                       { %>
                                                    <tr>
                                                        <td width="18%" align="center">
                                                            <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                        <td width="82%">
                                                            <a href="User_List.aspx?Name=<%=myPath.UrlEncode("账号管理") %>" target="Main">账号管理</a></td>
                                                    </tr>
                                                    <%} %>
                                                    <% if (ao.cLimit.IndexOf("|SYS_ChangePass|") != -1)
                                                       { %>
                                                    <tr style="display: ">
                                                        <td align="center">
                                                            <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                        <td>
                                                            <a href="Pass_Change.aspx" target="Main">修改密码</a></td>
                                                    </tr>
                                                    <%} %>
                                                
                                                    <% if (ao.cLimit.IndexOf("|SYS_LogHandle|") != -1)
                                                       { %>
                                                    <tr style="display: ">
                                                        <td align="center">
                                                            <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                        <td>
                                                            <a href="Log_Hand.aspx" target="Main">操作日志</a>
                                                        </td>
                                                    </tr>
                                                    <%} %>
                                                </table>
                                            </td>
                                        </tr>
                                        <%} %>
                                        
                           
                                                    
                                        <% if (ao.cLimit.IndexOf("|Bossdd_") != -1)
                                           { %>
                                        <%} %>
                                        
                                           
                                        <% if (ao.cLimit.IndexOf("|News_") != -1)
                                           { %>
                                        <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                                电子报管理</td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                            </td>
                                            <td>
                                                <asp:Repeater ID="myNewsTypeList" runat="server">
                                                    <HeaderTemplate>
                                                        <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                            <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="NewsClass_List.aspx" target="Main">期刊设置</a></td>
                                                            </tr>
                                                              <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="NewsType_List.aspx" target="Main">版面设置</a></td>
                                                            </tr>
                                                             <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="News_List.aspx" target="Main">文章管理</a></td>
                                                            </tr>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr id="myNewsShow" runat="server">
                                                            <td width="18%" align="center">
                                                                <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                            <td width="82%">
                                                                <a href="News_List.aspx?Name=<%#myPath.UrlEncode(Eval("cTypeName").ToString()) %>&TypeId=<%#Eval("ID").ToString() %>"
                                                                    target="Main">
                                                                    <%#Eval("cTypeName").ToString() %>
                                                                </a>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        </table></FooterTemplate>
                                                </asp:Repeater>
                                            </td>
                                        </tr>
                                        <%} %>

                                         <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                                群众路线网管理</td>
                                        </tr>  
                                       <tr><td></td><td>
                                       <asp:Repeater ID="myNewsTypeList2" runat=server>
                                       <HeaderTemplate><table width="100%" border="0" cellspacing="5" cellpadding="0"></HeaderTemplate>
                                       <ItemTemplate><tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                              
                                                                <a href="News_List2.aspx?Name=<%#myPath.UrlEncode(Eval("cTypeName").ToString()) %>&TypeId=<%#Eval("ID").ToString() %>"
                                                                    target="Main"><%#Eval("cTypeName").ToString()%></a></td>
                                                            </tr></ItemTemplate>
                                       <FooterTemplate></table></FooterTemplate>
                                       </asp:Repeater>
                                        
                                                            
                                                              
                                                            
                                       
                                       </td></tr>
                                      
                                       <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                                其它管理</td>
                                        </tr>  
                                       <tr><td></td><td>
                                        <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                            <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="NewsClass_List.aspx" target="_blank">统计管理</a></td>
                                                            </tr>
                                                              <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="NewsType_List.aspx" target="_parent">退出系统</a></td>
                                                            </tr></table>
                                       
                                       </td></tr>
                                            
                                       
                                      
                                        
                                          </table>
                                </td>
                                <td background="images/index1_47.gif">
                                </td>
                            </tr>
                            <tr>
                                <td width="8" height="8">
                                    <img src="images/index1_91.gif" width="8" height="8" /></td>
                                <td background="images/index1_92.gif">
                                </td>
                                <td width="8" height="8">
                                    <img src="images/index1_93.gif" width="8" height="8" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
