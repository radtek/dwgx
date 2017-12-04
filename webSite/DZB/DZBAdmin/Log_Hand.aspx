<%@ page language="C#" autoeventwireup="true" inherits="LDAdmin_Log_Hand, App_Web_lekpraw3" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
       <style>
       
    
       </style>
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>操作日志</strong></a></td>
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
                        
                          <asp:Repeater ID="myDataList" runat=server>
                          <HeaderTemplate><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#BBD3EB">
                          <tr>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                              序号
                            </td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF" style="display:none">
                                Sql文本</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                操作员</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                操作IP</td>
                           
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  操作时间</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#FFFFFF" height="27">
                                  操作备注</td>
                          </tr></HeaderTemplate>
                          <ItemTemplate>  <tr>
                            <td height="26" align="center"  class="Table_BG<%# Container.ItemIndex % 2 %>">
                              <label>
                             <%#Eval("ID").ToString() %>
                              </label>
                            </td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>"  style="display:none"  ><div align=left title=" <%# Eval("cSqlText").ToString() %> "> &nbsp; 
                                <%#myChar.getStrLength(Eval("cSqlText").ToString(),80,"...") %> </div></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%#Eval("AdminName").ToString() %></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%#Eval("cIP").ToString()%></td>
                           
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" >
                             <%#Eval("dCreateTime").ToString()%>
                              </td>
                              <td class="Table_BG<%# Container.ItemIndex % 2 %>">
                                  <%#Eval("cMemo").ToString() %>
                              </td>
                           
                          </tr></ItemTemplate>
                          <FooterTemplate> 
                   
                        </table></FooterTemplate>
                          </asp:Repeater>
                    
                          
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
                                    <td align="right">
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
                                        条</td>
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
    $(function() {
    //全选
	$("input[name='KAll']").click(function() {
	var allChecked=this.checked;
 
	  //alert(  allChecked); 
	 $('input:checkbox').each(function(){
        
      this.checked =allChecked;
      });

	
	});
	 
	//alert($("#Check1").get(0).checked);
});
    
	function DeleteIt(objId){
	if(window.confirm("确定要删除该账号吗？")){
	
	$("#Check"+objId).get(0).checked=true;
	  //$("#DeleteButton").click(this);
	$("#DeleteButton").click();
	return true;
	}
	else{
	return false;
	}
	}
	 
	 
	 //查找
	 //查找
	 function FindData(){
	 location.href="?Page=<%=myChar.RequestQueryString("Page") %>&findText="+$("#findText").val()+"&cType="+$("#cType").val() ;
	 }
        </script>
    </form>
</body>
</html>
