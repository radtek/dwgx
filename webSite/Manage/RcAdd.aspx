<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RcAdd.aspx.cs" Inherits="Manage_RcInfo_Add" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
          <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="../js/jquery-3.1.1.min.js"></script>
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
                     var edtCompanyName = $("#edtCompanyName").val();
                     var edtJobName = $("#edtJobName").val();

                     if (edtCompanyName == null || edtCompanyName == "")
                     {
                         alert("公司名称不能为空");
                         return false;
                     }

                     if (edtJobName == null || edtJobName == "") {
                         alert("招聘职位不能为空");
                         return false;
                     }

                     var patrn = /^\d*$/;
                     if (!patrn.exec($("#edtAmount").val()) || $("#edtAmount").val() == "") {
                         alert("招聘人数格式不正确");
                         return false;
                     }

                     if (!patrn.exec($("#edtAge").val()) || $("#edtAge").val() == "") {
                         alert("年龄要求格式不正确");
                         return false;
                     }

                     if ($("#edtSalary").val() == null || $("#edtSalary").val() == "") {
                         alert("待遇要求格式不正确");
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
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            height: 21px;
            width:auto;
            text-align:center;
        }
        .auto-style3 {
            width: 80px;
        }
        .auto-style5 {
            width: 80px;
            height: 29px;
        }
        .auto-style6 {
            width: 300px;
            height: 29px;
        }
        .auto-style7 {
            height: 34px;
        }
    </style>
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>新增招聘</strong></a></td>
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
                          &nbsp;
                         <table id="Table3" bgcolor="#C4E7FB" border="0" cellpadding="4" cellspacing="1" width="100%">
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      公司名称：</td>
                                  <td bgcolor="#ffffff" class="auto-style1" colspan="3">
                                      <asp:TextBox ID="edtCompanyName" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      *（必填）</td>
                                 
                              </tr> <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      招聘职位：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtJobName" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      *（必填）&nbsp;</td>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      用工形式：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtJobType" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr> <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      招聘人数：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtAmount" runat="server" MaxLength="300" Width="230px"></asp:TextBox>
                                      *（必填）</td>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      性别要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:DropDownlIST ID="edtSex" runat="server" MaxLength="300" Width="230px">
                                          <asp:ListItem Value="0">男</asp:ListItem>
                                          <asp:ListItem Value="1">女</asp:ListItem>
                                          <asp:ListItem Value="2">不限</asp:ListItem>
                                      </asp:DropDownlIST>
                                      </td>
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
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      年龄要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtAge" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                                      <td bgcolor="#ffffff" class="auto-style3">
                                      学历要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtRofs" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>

                              <!--如果是高新电视台，则可以指定新闻图片-->
                          
                              <tr style="display:">
                                  <td bgcolor="#ffffff" class="auto-style5">
                                      专业要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style6">
                                      <asp:TextBox ID="edtMajor" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                                      <td bgcolor="#ffffff" class="auto-style5">
                                      用人对象：</td>
                                  <td bgcolor="#ffffff" class="auto-style6">
                                      <asp:TextBox ID="edtJobobject" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>                          

                                <tr style="display:">
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      职称要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtTitleRequire" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                                      <td bgcolor="#ffffff" class="auto-style3">
                                      身高要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtStatureRequire" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>
                             
                              <tr >
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      地域要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtAreaRequire" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                                      <td bgcolor="#ffffff" class="auto-style3">
                                      证书要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtCertificatesRequire" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      有效时间：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtSignificantInterval" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                                      <td bgcolor="#ffffff" class="auto-style3">
                                      工作地点：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtJobAddr" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      待遇要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtSalary" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      </td>
                                      <td bgcolor="#ffffff" class="auto-style3">
                                      公司地址：</td>
                                  <td bgcolor="#ffffff" class="auto-style1">
                                      <asp:TextBox ID="edtCompnyAddr" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      联系电话：</td>
                                  <td bgcolor="#ffffff" class="auto-style1" colspan="3">
                                      <asp:TextBox ID="edtPhone" runat="server" MaxLength="100" Width="230px"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style3">
                                      其它要求：</td>
                                  <td bgcolor="#ffffff" class="auto-style1" colspan="3">
                                      <asp:TextBox ID="edtOthers" runat="server" MaxLength="800" Width="661px" Height="100px" TextMode="MultiLine"></asp:TextBox>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" class="auto-style2" colspan="4">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return validation();"
                                          Text=" 保 存 " style="height: 21px" />&nbsp;
                                      <input onclick="history.go(-1);" type="button" value="取消" /></td>
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
