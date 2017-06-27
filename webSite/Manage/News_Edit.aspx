<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_Edit.aspx.cs" Inherits="Manage_News_Edit" %>
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
           function CheckType(obj) {
               if (obj.value == 16) {
                   document.getElementById("myVideoShow").style.display = "";
               } else {
                   document.getElementById("myVideoShow").style.display = "none";
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
    <form id="form1" runat="server" enctype="multipart/form-data">
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>编辑新闻</strong></a></td>
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
                                  <td bgcolor="#ffffff">
                                      新闻<span id="cTitleText">标题</span>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cTitle" runat="server" MaxLength="100" Width="355px"></asp:TextBox>
                                      *（100字内）</td>
                              </tr> <tr>
                                  <td bgcolor="#ffffff">
                                      来&nbsp;&nbsp;&nbsp; 源：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cLittleTitle" runat="server" MaxLength="100" Width="147px"></asp:TextBox>
                                      &nbsp; （100字内）</td>
                              </tr> <tr>
                                  <td bgcolor="#ffffff">
                                      跳转地址：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="cUrl" runat="server" MaxLength="300" Width="351px"></asp:TextBox>
                                      &nbsp; （300字内，输入内容则跳转地址）</td>
                              </tr>
                             <!--
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
                                    <!--  <asp:CheckBox ID="cTitleShow0" runat="server" Text="首页" />&nbsp;<asp:CheckBox
                                          ID="cTitleShow3" runat="server" Text="推荐" />&nbsp;<asp:CheckBox ID="cTitleShow1"
                                              runat="server" Text="列表页" />&nbsp;<asp:CheckBox ID="cTitleShow2" runat="server"
                                                  Text="内容页" />
                                  </td>
                              </tr>-->
                             <tr style="display:">
                                  <td bgcolor="#ffffff">
                                      是否头条新闻：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:CheckBox ID="isPut" runat="server" Text="是" />
                                  </td>
                              </tr>

                              <!--如果是高新电视台，则可以指定新闻图片-->
                              <%if (newsTypeId == 45){%>
                              <tr style="display:">
                                  <td bgcolor="#ffffff">
                                      视频新闻图片：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:FileUpload ID="upLoadVideoImg" runat="server" Width="330px" Height="19px" />&nbsp;<asp:HyperLink ID="cVideoImgPath" runat="server" Target="_blank">HyperLink</asp:HyperLink>
                                      &nbsp;&nbsp;&nbsp;&nbsp;
                                      <asp:HyperLink ID="deleVideoPic" runat="server" Text="删除图片"></asp:HyperLink>
                                  </td>
                              </tr>
                              <%} %>

                                <tr style="display:">
                                  <td bgcolor="#ffffff">
                                      是否滚动图片：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:CheckBox ID="isScrollPic" runat="server" Text="是" /> &nbsp;&nbsp;&nbsp;&nbsp;
                                       
                                  &nbsp;&nbsp; <asp:FileUpload ID="FileUpload3" runat="server" Width="276px" />
                                      <asp:HyperLink ID="cPutPicPath" runat="server" Target="_blank">HyperLink</asp:HyperLink>
                                  &nbsp;&nbsp;&nbsp;&nbsp;
                                      <asp:HyperLink ID="delePic" runat="server" Text="删除图片"></asp:HyperLink>
                                  </td>
                              </tr>
                             
                              <tr >
                                  <td bgcolor="#ffffff">
                                      新闻视频：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:FileUpload ID="videoUpLoad" runat="server" Width="320px" />
&nbsp;<asp:HyperLink ID="cVideoPath" runat="server" Target="_blank">HyperLink</asp:HyperLink>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      <font id="dCreateTimeText" face="宋体">发布时间</font>：</td>
                                  <td bgcolor="#ffffff">
                                      <asp:TextBox ID="dCreateTime" runat="server"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff">
                                      新闻内容：</td>
                                  <td bgcolor="#ffffff">
                                      <!--<iframe id="eWebEditor1" frameborder="0"
                        height="350" scrolling="no" src="ewebeditor1/ewebeditor.asp?id=myContent&style=s_coolblue"
                        width="550" style="width: 592px"></iframe>-->
                                      <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="380px" ToolbarSet=""
                                          Width="100%">
                                          &nbsp;</FCKeditorV2:FCKeditor>
                                  </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      浏览次数：</td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Literal ID="iViewCount" runat="server"></asp:Literal></td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                  </td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return  chkForm('myNewsType|myTheme|cTitle|dCreateTime');"
                                          Text=" 修 改 " style="height: 21px" />&nbsp;
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
