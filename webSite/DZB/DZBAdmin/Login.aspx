<%@ page language="C#" autoeventwireup="true" inherits="IOAdmin_Login, App_Web_lekpraw3" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=GB2312" />
<title>��¼ϵͳ</title>
<style type="text/css">
<!--
*{overflow:hidden; font-size:9pt;}
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-image: url(images/bg.gif);
	background-repeat: repeat-x;
}
-->
</style>
<script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
 
</head>

<body>
<form id="Form1" runat=server>
<table width="100%"  height="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td height="561" style="background:url(images/lbg.gif)"><table width="940" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="238" style="background:url(images/login01.jpg)">&nbsp;</td>
          </tr>
          <tr>
            <td height="190"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="208" height="190" style="background:url(images/login02.jpg)">&nbsp;</td>
                <td width="518" style="background:url(images/login03.jpg)"><table width="320" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td width="40" height="50"><img src="images/user.gif" width="30" height="30"></td>
                    <td width="38" height="50">�û�</td>
                    <td width="242" height="50"><input type="text" name="cAccount" id="cAccount" style="width:164px; height:32px; line-height:34px; background:url(images/inputbg.gif) repeat-x; border:solid 1px #d1d1d1; font-size:9pt; font-family:Verdana, Geneva, sans-serif;" maxlength="50"></td>
                  </tr>
                  <tr>
                    <td height="50"><img src="images/password.gif" width="28" height="32"></td>
                    <td height="50">����</td>
                    <td height="50"><input type="password" name="cPass" id="cPass" style="width:164px; height:32px; line-height:34px; background:url(images/inputbg.gif) repeat-x; border:solid 1px #d1d1d1; font-size:9pt; " maxlength="50"></td>
                  </tr>
                  <tr>
                    <td height="40">&nbsp;</td>
                    <td height="40">&nbsp;</td>
                    <td height="60">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/login.gif" OnClick="ImageButton1_Click"   /></td>
                  </tr>
                </table></td>
                <td width="214" style="background:url(images/login04.jpg)" >&nbsp;</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td height="133" style="background:url(images/login05.jpg)">&nbsp;</td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
</table></form>
<script language=javascript>
$(document).ready(function(){
$("#ImageButton1").click(function(){
//�ж��û����Ƿ�Ϊ��
if($("#cAccount").val().length==0){
alert("�������¼�˺�!");
$("#cAccount").focus();
return false;
}
//�ж������Ƿ�Ϊ��
 if($("#cPass").val().length==0){
alert("�������¼����!");
$("#cPass").focus();
return false;
}
//�ж���֤���Ƿ�Ϊ��
 //if($("#Code").val().length==0){
//alert("��������֤��!");
//$("#Code").focus();
//return false;
//}
return true;
});

//�������赽�û���
$("#cAccount").focus();
});



</script>

<script>
    if (self.location != top.location) {
        top.location.href = 'Login.aspx';
    }
</script>

</body>
</html>
