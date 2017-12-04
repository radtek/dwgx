<%@ page language="C#" autoeventwireup="true" inherits="IOAdmin_Info_Edit, App_Web_lekpraw3" %>


<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
       <script language=javascript src="js/Init.js"></script>
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>编辑信息</strong></a></td>
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
                                  <td align="center">
                                      <asp:Label ID="cTitle" runat="server" Text="Label"></asp:Label>
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
                                  <td bgcolor="#ffffff">
                                      <!--<iframe id="eWebEditor1" frameborder="0"
                        height="350" scrolling="no" src="ewebeditor1/ewebeditor.asp?id=myContent&style=s_coolblue"
                        width="550" style="width: 592px"></iframe>-->
                                      <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="480px" ToolbarSet=""
                                          Width="100%">
                                          &nbsp;</FCKeditorV2:FCKeditor>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px" align="center">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return  chkForm('myNewsType|cTitle|dCreateTime');"
                                          Text=" 修 改 " />&nbsp;
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
         <script language="javascript">
  
	 
 
        </script>
        <OBJECT id="dlgHelper"  height="0px" width="0px" classid="clsid:3050f819-98b5-11cf-bb82-00aa00bdce0b">
			</OBJECT>
    </form>
</body>
</html>
