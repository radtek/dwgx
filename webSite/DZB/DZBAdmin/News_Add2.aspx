<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_Add2.aspx.cs" Inherits="LDAdmin_News_Add2" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
       <script language=javascript src="js/Init.js"></script>
       <script src="artDialog/jquery.artDialog.source.js?skin=default"></script>
<script src="artDialog/iframeTools.source.js"></script>

       <script language=javascript>
       function CheckType(obj){
        if(obj.value==16){
            document.getElementById("myVideoShow").style.display="";
        }else{
         document.getElementById("myVideoShow").style.display="none";
        }
       
       }
       </script>

             <script language=javascript>

           function validation() {
               if (document.editForm.newsId.value == "") {
                   alert("请选择所属期刊！");
                   return false;
               }
               if (document.editForm.forumId.value == "") {
                   alert("请选择所属版面！");
                   return false;
               }
               if (document.editForm.title.value == "") {
                   alert("标题不能为空！");
                   return false;
               }
               if (document.editForm.coordinate.value == "") {
                   alert("文章锚点不能为空！");
                   return false;
               }
               if (document.editForm.content.value == "") {
                   alert("内容不能为空！");
                   return false;
               }
               return true;
           }

           function chsel() {
               newsId = $("#myNewsType").val();
               $.ajax({
                   type: "get", //可选get
                   url: "ajaxGetForum.asp", //这里是接收数据的PHP程序
                   data: 'newsId=' + newsId, //传给PHP的数据，多个参数用&连接
                   dataType: "text", //服务器返回的数据类型 可选XML ,Json jsonp script html text等
                   success: function (msg) {
                       $("#selectForum").html(msg);
                   },
                   error: function () {
                   }
               })
           }

           function editMap() {
        
               var forumId = document.getElementById("myNewsType").value;
              // alert(forumId);
               if (forumId == 0 || forumId == "") {
                   alert("请先选择所属版面");
               } else {
                   art.dialog.open('editMap.aspx?TId=' + forumId, { title: '编辑锚点', width: 430, height: 600 });
               }
           }
 
</script>
 

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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>添加新闻</strong></a></td>
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
                                  <td bgcolor="#ffffff" colspan="1" rowspan="1">
                                      新闻类别：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:DropDownList ID="myNewsType" runat="server"  
                                          Width="120px">
                                          <asp:ListItem Value="">请选择</asp:ListItem>
                                      </asp:DropDownList>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      <span id="cTitleText">新闻标题</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cTitle" runat="server" MaxLength="100" Width="355px"></asp:TextBox>
                                      &nbsp;*（100字内）</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      标题设置：</td>
                                  <td bgcolor="#ffffff">
                                      <span id="cTitleColorText">颜色</span>：<asp:TextBox ID="cTitleColor" runat="server" Width="57px"></asp:TextBox>
                                      <input id="Button2" onclick="doForeColor($('cTitleColor'));" type="button" value="选择颜色" />
                                      &nbsp;&nbsp;
                                      <asp:DropDownList ID="cTitleSize" runat="server">
                                      </asp:DropDownList>&nbsp;
                                      <asp:CheckBox ID="cTitleB" runat="server" Text="加粗" />
                                      &nbsp;<asp:CheckBox ID="cTitleU" runat="server" Text="下划线" />&nbsp;
                                      <asp:CheckBox ID="cTitleShow0" runat="server" Text="首页" />&nbsp;<asp:CheckBox
                                          ID="cTitleShow3" runat="server" Text="推荐" />&nbsp;<asp:CheckBox ID="cTitleShow1"
                                              runat="server" Text="列表页" />&nbsp;<asp:CheckBox ID="cTitleShow2" runat="server"
                                                  Text="内容页" />
                                  </td>
                              </tr>
                              <tr style="display:none">
                                  <td bgcolor="#ffffff">
                                      是否公告：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:CheckBox ID="iPut" runat="server" Text="是" />
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      新闻图片：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:FileUpload ID="FileUpload1" runat="server" Width="320px" />
&nbsp;（支持JPG、PNG或GIF格式图片）</td>
                              </tr>
                              <tr style="display:none">
                                  <td bgcolor="#ffffff">
                                      上传视频：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:FileUpload ID="FileUpload2" runat="server" Width="320px" />
&nbsp;（支持FLV、SWF、AVI或WMA格式）</td>
                              </tr>
                              <tr style="display:none">
                                  <td bgcolor="#ffffff" style="height: 28px">
                                      最新：</td>
                                  <td bgcolor="#ffffff" style="height: 28px">
                                      <asp:CheckBox ID="cIsNew0" runat="server" Text="首页" />
                                      <asp:CheckBox ID="cIsNew1" runat="server" Text="推荐" />
                                      <asp:CheckBox ID="cIsNew2" runat="server" Text="列表页" />
                                      <asp:CheckBox ID="cIsNew3" runat="server" Text="内容页" />
                                      （在相应位置显示<img src="/images/new.gif" />图标）</td>
                              </tr>
                              <tr  >
                                  <td bgcolor="#ffffff" style="height: 28px">
                                      发布时间：</td>
                                  <td bgcolor="#ffffff" style="height: 28px">
                                      <asp:TextBox ID="dCreateTime" runat="server"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      信息内容：</td>
                                  <td bgcolor="#ffffff">
                                     
                                      <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="420px" ToolbarSet=""  Width="100%"> </FCKeditorV2:FCKeditor>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                  </td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return  chkForm('myNewsType|cTitle|dCreateTime');"
                                          Text=" 确 定 " />&nbsp;
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
                      <td>&nbsp;</td>
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
