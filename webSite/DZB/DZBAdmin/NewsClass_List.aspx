<%@ page language="C#" autoeventwireup="true" inherits="DZBAdmin_NewsClass_List, App_Web_lekpraw3" %>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
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
                <td><img src="images/index1_28.gif"    /></td>
                <td width="99%" background="images/index1_40.gif">
                   </td>
                <td ><img src="images/index1_43.gif"  /></td>
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
                                      <table width=100% border=0>
                                          <tr>
                                              <td>
                                              <a href="NewsClass_Edit.aspx">
                                                  <img src="images/BTN_Class_Add.jpg"    alt="添加期刊" 
                                                      border=0 /></a>
                                                  <asp:ImageButton ID="ImageButton2" ImageUrl="images/BTN_Class_DEL.jpg" 
                                                      runat="server" OnClick="ImageButton2_Click" ToolTip="删除期刊" 
                                                      onclientclick="return window.confirm('将同时删除该期刊下的版面和文章，确认要删除已选期刊吗？');" /></td>
                                              <td>
                                              </td>
                                              <td align="right">
                                              </td>
                                          </tr>
                                      </table>
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
                              <label>
                              <input type="checkbox" name="KAll" id="KAll"   />
                              </label>
                            </td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                期别</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                出版日期</td>
                           
                               <td align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                创建时间</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  操作</td>
                          </tr></HeaderTemplate>
                          <ItemTemplate>  <tr>
                            <td height="26" align="center" bgcolor="#FFFFFF">
                              <label>
                              <input type="checkbox" name="checkbox" value="<%#Eval("ID").ToString() %>" />
                              </label>
                            </td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>"  ><a href="NewsClass_Edit.aspx?ID=<%#Eval("ID").ToString() %>">
                                <%#Eval("cClassName").ToString()%></a></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%#System.Convert.ToDateTime(Eval("dOutTime")).ToShortDateString() %></td>
 
                                <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%#Eval("dCreateTime").ToString() %></td>
                              <td  class="Table_BG<%# Container.ItemIndex % 2 %>" >
                               <input onclick="location.href='NewsType_List.aspx?CID=<%#Eval("ID").ToString() %>';"
                                  style="height: 20px" type="button" value="版面管理" /> 
                              |
                              <input onclick="location.href='NewsClass_Edit.aspx?ID=<%#Eval("ID").ToString() %>';"
                                  style="height: 20px" type="button" value="编辑" /> 
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
                                  <td>
                                      <table bgcolor="#FDFDFF" border="0" cellpadding="0" cellspacing="5" 
                                          width="100%">
                                          <tr>
                                              <td align="right">
                                                  &nbsp;<asp:HyperLink ID="First" runat="server">首页</asp:HyperLink>
                                                  &nbsp; &nbsp;
                                                  <asp:HyperLink ID="lnkPrev" runat="server">上一页</asp:HyperLink>
                                                  &nbsp; &nbsp;
                                                  <asp:HyperLink ID="lnkNext" runat="server">下一页</asp:HyperLink>
                                                  &nbsp; &nbsp;
                                                  <asp:HyperLink ID="Last" runat="server">尾页</asp:HyperLink>
                                                  &nbsp; &nbsp;当前页码： 
                                                  <asp:Literal ID="lblCurrentPage" runat="server"></asp:Literal>
                                                  ／<asp:Literal ID="PageCount" runat="server"></asp:Literal>
                                                  页 &nbsp;&nbsp; 记录总数：<asp:Literal ID="myCount" runat="server"></asp:Literal>
                                                  条</td>
                                          </tr>
                                         
                                      </table>
                                    </td>
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
	if(window.confirm("确定要删除该部门吗？")){
	
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
	 function FindData(){
	 location.href="?p=<%=myChar.RequestQueryString("p") %>&findName="+$("#findName").val()+"&iAdminId="+$("#AdminList").val()+"&SortName="+$("#SortName").val()+"&SortSequence="+$("#SortSequence").val();
	 }
        </script>
    </form>
</body>
</html>

