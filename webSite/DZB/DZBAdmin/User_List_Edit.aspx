<%@ page language="C#" autoeventwireup="true" inherits="LDAdmin_User_List_Edit, App_Web_lekpraw3" %>
 

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
</head>
 <body>
    <form id="form1" runat="server">
      <table width="100%" border="0" cellspacing="10" cellpadding="0">
        <tr>
          <td width="70%" valign="top">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="8" height="8"><img src="images/index1_28.gif" width="8" height="39" /></td>
                <td width="99%" background="images/index1_40.gif">
                  <table border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td>
                        <table width="90" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="5"><img src="images/index1_35.gif" width="5" height="39" /></td>
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>编辑用户</strong></a></td>
                            <td width="5"><img src="images/index1_38.gif" width="5" height="39" /></td>
                          </tr>
                        </table>
                      </td>
             
                    </tr>
                  </table>
                </td>
                <td width="8" height="8"><img src="images/index1_43.gif" width="8" height="39" /></td>
              </tr>
              <tr>
                <td background="images/index1_45.gif"></td>
                <td bgcolor="#FFFFFF" style="height:490px; vertical-align:top;">
                  <table width="100%" border="0" cellspacing="10" cellpadding="0">
                    <tr>
                      <td>
                        <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#C4E7FB">
                          <tr>
                            <td>
                              <table width="100%" border="0" cellpadding="0" cellspacing="5" bgcolor="#FFFFFF">
                                <tr>
                                  <td>
                                  </td>
                                </tr>
                              </table>
                            </td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                    <tr>
                      <td>
                          &nbsp;
                          <table id="Table3" bgcolor="#C4E7FB" border="0" cellpadding="4" cellspacing="1" width="100%">
                              <tr>
                                  <td bgcolor="#ffffff" colspan="1" rowspan="1" style="height: 27px; background-color: #f8f8f8">
                                      <span id="myNewsTypeText">用户账号</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cAccount" runat="server" MaxLength="25" Width="225px"></asp:TextBox>
                                      *（25字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      <span id="cTitleText">登陆密码</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cPass" runat="server" MaxLength="25" Width="225px"></asp:TextBox>
                                      *（25字内，空为不修改原密码）<input id="cOldPass" runat="server" name="cOldPass" type="hidden" /></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      用户名称：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cName" runat="server" MaxLength="25"  
                                          Width="225px"></asp:TextBox>
                                      *（25字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      <span id="cLittleTitleText">是否有效</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:DropDownList ID="bValid" runat="server">
                                          <asp:ListItem Value="">请选择</asp:ListItem>
                                          <asp:ListItem Value="True">有效</asp:ListItem>
                                          <asp:ListItem Value="False">无效</asp:ListItem>
                                      </asp:DropDownList>
                                      *（请选择）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" colspan="2"  >    <table id="Table1" bgcolor="#C4E7FB" border="0" cellpadding="4" cellspacing="1" width="100%">
                                      <tr>
                                          <td bgcolor="#f8f8f8" colspan="2" style="height: 28px;width:25%">
                                              <span id="Span1">权限设置</span></td>
                                          <td bgcolor="#f8f8f8">
                                              勾选你要设置的权限 （账号需要重新登录后生效）</td>
                                      </tr>
                                      <tr>
                                          <td bgcolor="#f8f8f8" rowspan="3"  >
                                              <span id="Span2">系统设置</span></td>
                                          <td bgcolor="#ffffff">
                                              账号管理</td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="SYS_Users" runat="server" Text="选择" /></td>
                                      </tr>
                                      <tr>
                                          <td bgcolor="#ffffff">
                                              修改密码</td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="SYS_ChangePass" runat="server" Text="选择" /></td>
                                      </tr>
                                      <tr>
                                          <td bgcolor="#ffffff">
                                              操作日志</td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="SYS_LogHandle" runat="server" Text="选择" /></td>
                                      </tr>
                                      <tr>
                                          <td bgcolor="#f8f8f8" >
                                              留言管理</td>
                                          
                                          <td bgcolor="#ffffff">
                                              <a href="Guest_List.aspx" target="Main">依申请公开列表</a></td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="Boss_GuestList" runat="server" Text="选择" /></td>
                                      </tr>
                                      
                                      <tr>
                                          <td bgcolor="#f8f8f8" rowspan="2" id="News_Count" runat=server >
                                              新闻管理</td>
                                          <td bgcolor="#ffffff">
                                              全部信息</td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="News_All" runat="server" Text="选择" /></td>
                                      </tr>
                                      <asp:Repeater ID="myNew_List"   runat=server>
                                      <ItemTemplate>
                                       <tr>
                                          <td bgcolor="#ffffff">
                                              <%#Eval("cTypeName").ToString()%></td>
                                          <td bgcolor="#ffffff">
                                          
                                           
                                           <asp:Literal ID="myNTCheck" runat=server></asp:Literal>
                                          </td>
                                      </tr>
                                      </ItemTemplate>
                                      </asp:Repeater>
                                     
                                  
                                      <tr>
                                          <td bgcolor="#f8f8f8" style="height: 28px" rowspan="2">
                                              内容管理</td>
                                          <td bgcolor="#ffffff">
                                              信息公开指南</td>
                                          <td bgcolor="#ffffff">
                                              <asp:CheckBox ID="Info_1" runat="server" Text="选择" /></td>
                                      </tr>
                                      <tr>
                                          
                                          <td bgcolor="#ffffff">
                                              &nbsp;</td>
                                          <td bgcolor="#ffffff">&nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td bgcolor="#f8f8f8" style="height: 28px">
                                              &nbsp;</td>
                                          <td bgcolor="#ffffff">
                                              &nbsp;</td>
                                          <td bgcolor="#ffffff">
                                              &nbsp;</td>
                                      </tr>
                                  </table>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      最后登陆时间：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:Literal ID="dLastTime" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      最后登陆IP：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:Literal ID="cLastIp" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      最后登陆次数：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:Literal ID="iLoginCount" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8">
                                      创建时间：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:Literal ID="dCreateTime" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 27px; background-color: #f8f8f8;">
                                  </td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" 编辑 " />&nbsp;
                                      <input onclick="history.go(-1);" type="button" value="返回" /></td>
                              </tr>
                          </table>
                       
                      </td>
                    </tr>
                    <tr>
                      <td>
                        <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#E1E5E8">
                          <tr>
                            <td>
                              <table width="100%" border="0" cellpadding="0" cellspacing="5" bgcolor="#FDFDFF">
                                <tr>
                                  <td>&nbsp;</td>
                                </tr>
                              </table>
                            </td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                    <tr>
                      <td>&nbsp;<a href="#"></a>&nbsp;<a href="#"></a><a href="#" class="font1">&nbsp;</a><a href="#"></a></td>
                    </tr>
                  </table>
				  
				 
                </td>
                <td background="images/index1_47.gif"></td>
              </tr>
              <tr>
                <td width="8" height="8"><img src="images/index1_91.gif" width="8" height="8" /></td>
                <td background="images/index1_92.gif"></td>
                <td width="8" height="8"><img src="images/index1_93.gif" width="8" height="8" /></td>
              </tr>
            </table>
          </td>
        </tr>
      </table>
          
          
          <script language=javascript>
$(document).ready(function(){
$("#Button1").click(function(){
//判断用户名是否为空
if($("#cAccount").val().length==0){
alert("请输入登录账号!");
$("#cAccount").focus();
return false;
}
//判断密码是否为空
 //if($("#cPass").val().length==0){
//alert("请输入登录密码!");
//$("#cPass").focus();
//return false;
//}
//判断用户名称是否为空
 if($("#cName").val().length==0){
 alert("请输入用户名称!");
 $("#cName").focus();
 return false;
 }
 //判断账号有效是否为空
 if($("#bValid").val().length==0){
 alert("请输入账号有效!");
 $("#bValid").focus();
 return false;
 }
return true;
});

//将焦点设到用户名
$("#cAccount").focus();
});

</script>
    </form>
</body>
</html>
