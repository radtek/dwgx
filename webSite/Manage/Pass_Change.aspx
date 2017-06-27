<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pass_Change.aspx.cs" Inherits="Manage_Pass_Change" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="../js/jquery-3.1.1.min.js"></script>
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>修改密码</strong></a></td>
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
                                  <td bgcolor="#ffffff" colspan="1" rowspan="1" style="height: 27px">
                                      <span id="myNewsTypeText">用户账号</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:Literal ID="cAccount" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" colspan="1" rowspan="1" style="height: 22px">
                                      旧 密 码：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cOldPass" runat="server" TextMode ="Password" MaxLength="25" Width="225px"></asp:TextBox>
                                      *（25字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 22px">
                                      <span id="cTitleText">新 密 码</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cNewPass" TextMode="Password" runat="server" MaxLength="25" Width="225px"></asp:TextBox>
                                      *（25字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 22px">
                                      <span id="cTitlePwd">确认密码</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cConfirmPass" TextMode="Password" runat="server" MaxLength="25" Width="225px"></asp:TextBox>
                                      *（25字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      </td>
                                  <td bgcolor="#ffffff">
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                  </td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" 修改密码 " />&nbsp;
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
 
//判断密码是否为空
 if($("#cOldPass").val().length==0){
alert("请输入旧密码!");
$("#cOldPass").focus();
return false;
}
//判断密码是否为空
 if($("#cNewPass").val().length==0){
alert("请输入新密码!");
$("#cNewPass").focus();
return false;
 }

 //判断确认密码是否为空
 if ($("#cConfirmPass").val().length == 0) {
     alert("请确认新密码!");
     $("#cNewPass").focus();
     return false;
 }

 if ($("#cNewPass").val() != $("#cConfirmPass").val()) {
     alert("两次密码输入不一致!");
     $("#cConfirmPass").focus();
     return false;
 }

 })

  
return true;
});

//将焦点设到用户名
$("#cAccount").focus();
});

</script>
    </form>
</body>
</html>
