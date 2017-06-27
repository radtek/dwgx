<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Manger_Left" %>

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

                                        <%if (GetBigTypeLimit("Setting_"))
                                            {%>
                                        <tr>
                                            <td width="16%" align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td width="84%">
                                                系统设置</td>
                                        </tr>
                                        <%} %>

                                        <tr>
                                            <td align="center">
                                                &nbsp;</td>
                                            <td>
                                                <table width="100%" border="0" cellspacing="5" cellpadding="0">

                                                    <% if (GetNewsTypeLimit("Setting_Users"))
                                                        { %>
                                                    <tr>
                                                        <td width="18%" align="center">
                                                            <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                        <td width="82%">
                                                            <a href="MemberEdit.aspx" target="Main">账号管理</a></td>
                                                    </tr>
                                                    <%} %>
          
                                                     <% if (GetNewsTypeLimit("Setting_ChangePass"))
    { %>
                                                    <tr style="display: ">
                                                        <td align="center">
                                                            <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                        <td>
                                                            <a href="Pass_Change.aspx" target="Main">修改密码</a></td>
                                                    </tr>
                                                     <%} %>


                                                </table>
                                            </td>
                                        </tr>
                                        
                           
                                                  
                                        
                                           
                                         <%if (GetBigTypeLimit("News_"))
                                             {%>
                                        <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                                信息管理</td>
                                        </tr>
                                        <%} %>

                                        <tr>
                                            <td align="center">
                                            </td>
                                            <td>
                                                <asp:Repeater ID="myVideoList" runat="server">
                                                    <HeaderTemplate>
                                                        <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                          
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr id="myNewTypeTr" runat="server"  dataID='<%#Eval("ID")%>'>
                                                            <td width="18%" align="center">
                                                                <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                            <td width="82%">
                                                                <asp:HyperLink ID="myNewTypelink" runat="server" Target="Main" NavigateUrl='<%#"News_List.aspx?Name="+System.Web.HttpUtility.UrlEncode(Eval("cTypeName").ToString(),System.Text.Encoding.UTF8)+"&TypeId="+Eval("ID").ToString()%>'><%#Eval("cTypeName").ToString() %>   </asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        </table></FooterTemplate>
                                                </asp:Repeater>
                                            </td>
                                        </tr>

                                       <%if (GetBigTypeLimit("INFO_"))
                                           {%>
                                       <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                                内容管理</td>
                                        </tr>  
                                        <%} %>

                                       <tr><td></td><td>
                                        <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                        
                                                              
                                                            
                                                            <asp:Repeater ID="myAboutType" runat=server>
                                                            <ItemTemplate>
                                                                <tr id="myInfoTr" runat="server"  dataID='<%#Eval("ID")%>'>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <asp:HyperLink ID="myNewTypelink" runat="server" Target="Main" NavigateUrl='<%#"Info_Edit.aspx?id="+Eval("ID").ToString()%>'><%#int.Parse(Eval("sort").ToString()) >100 ? "&nbsp;|-"+Eval("cMemo").ToString():Eval("cMemo").ToString() %>   </asp:HyperLink>
                                                                 </td>
                                                            </tr></ItemTemplate>
                                                            </asp:Repeater>
                                                            </table>
                                       
                                       </td></tr>
                                         
                                        <%if (GetBigTypeLimit("SYS_")) {%>
                                        <tr>
                                            <td align="center">
                                                <img src="images/index1_54.gif" width="15" height="11" /></td>
                                            <td>
                                               系统管理</td>
                                        </tr>
                                        <%} %>  

                                       <tr><td></td><td>
                                        <table width="100%" border="0" cellspacing="5" cellpadding="0">
                                                           <!--
                                                              <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="ADPic.aspx?type=1&name=首页浮动广告" target="Main">首页浮动广告</a></td>
                                                            </tr>-->
                                                            
                                                        <% if (GetNewsTypeLimit("SYS_TUOPIAO"))
                                                            { %>
                                                            <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="Vote.aspx" target="Main">投票管理</a></td>
                                                            </tr> 
                                                        <%} %>

                                                        <% if (GetNewsTypeLimit("SYS_BOTTOMSLIDER"))
                                                            { %>
                                                            <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="BottomSliderList.aspx" target="Main">底部轮播</a></td>
                                                            </tr> 
                                                        <%} %>

                                                            <!--
                                                            <tr>
                                                                <td width="18%" align="center">
                                                                    <img src="images/index1_68.gif" width="11" height="14" /></td>
                                                                <td width="82%">
                                                                    <a href="Water.aspx" target="Main">水印管理</a></td>
                                                            </tr> 
                                            -->
                                                            </table>
                                       
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
                                                                    <a href="Logout.aspx" target="_parent">退出系统</a></td>
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

