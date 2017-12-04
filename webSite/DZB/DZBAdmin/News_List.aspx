<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_List.aspx.cs" Inherits="LDAdmin_News_List" %>

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
                        <table width="120" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="5"><img src="images/index1_35.gif" width="5" height="39" /></td>
                            <td align="center" background="images/index1_36.gif">
                                <a href="#" class="font3"><strong><asp:Literal ID="myTitle" runat="server">全部信息</asp:Literal></strong></a></td>
                            <td width="5"><img src="images/index1_38.gif" width="5" height="39" /></td>
                          </tr>
                        </table>
                      </td>
                      
                      <asp:Repeater ID="myNewsTypeList" runat=server>
                      <ItemTemplate>
                      <td>
                        <table width="120" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td width="5"><img src="images/index1_29.gif" width="5" height="39" /></td>
                            <td align="center" background="images/index1_30.gif"><a href="?TypeId=<%#Eval("ID")%>" class="font2"><strong><%#Eval("cTypeName")%></strong></a></td>
                            <td width="5"><img src="images/index1_33.gif" width="5" height="39" /></td>
                          </tr>
                        </table>
                      </td></ItemTemplate>
                      </asp:Repeater>
            
                     
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
                                      <table width=100% border=0>
                                          <tr>
                                              <td style="width: 113px">
                                              <a href="News_Add.aspx?CId=<%=myChar.RequestQueryString("CID") %>&TId=<%=myChar.RequestQueryString("TID") %>"><img src="images/BTN_News_Add.jpg"  border="0" alt="添加新闻" id="IMG1" /></a></td>
                                              <td style="width: 113px">
                                                  <asp:ImageButton ID="ImageButton2" ImageUrl="images/BTN_News_Delete.jpg" runat="server" OnClick="ImageButton2_Click" ToolTip="删除新闻" /></td>
                                              <td align="center" style="width: 30%">
                                              <asp:DropDownList ID="myNewsClass" runat="server" onchange="FindData();">
                                                  <asp:ListItem Value="">期刊列表</asp:ListItem>
                                                  </asp:DropDownList>

                                                  &nbsp;<asp:DropDownList ID="myNewsType" runat="server" onchange="FindData();">
                                                  <asp:ListItem Value="">版面列表</asp:ListItem>
                                                  </asp:DropDownList></td>
                                              <td align="right" style="width: 90px">
                                                  关键字：</td>
                                              <td align="left" style="width: 5%">
                                                  <asp:TextBox ID="findText" runat="server" MaxLength="100"></asp:TextBox></td>
                                              <td align="left">
                                                  &nbsp;<input id="Button1" type="button" value=" 搜 索 " onclick="FindData();" /></td>
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
                                文章标题 </td>
                                   <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                所属期刊</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                所属版面</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                浏览次数</td>
                            <td align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                创建时间</td>
                               
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  操作</td>
                          </tr></HeaderTemplate>
                          <ItemTemplate>      <tr>
                            <td height="26" align="center" bgcolor="#FFFFFF">
                              <label>
                              <input type="checkbox" name="checkbox" value="<%#Eval("ID").ToString() %>" />
                              </label>
                            </td>
                          
                               
                             <td  class="Table_BG<%# Container.ItemIndex % 2 %>" style="text-align:left;" >&nbsp;<a href="News_Edit.aspx?Id=<%#Eval("ID").ToString() %>&CId=<%=myChar.RequestQueryString("CId") %>&TId=<%=myChar.RequestQueryString("TId") %>"><%# NewsTitleStyle(DataBinder.Eval(Container.DataItem, "cTitleColor").ToString(), "宋体", DataBinder.Eval(Container.DataItem, "cTitleSize").ToString(), DataBinder.Eval(Container.DataItem, "cTitleB").ToString(), DataBinder.Eval(Container.DataItem, "cTitleU").ToString(), DataBinder.Eval(Container.DataItem, "cTitle").ToString(), DataBinder.Eval(Container.DataItem, "cTitleShow").ToString(), NTStyle.Index )%></a><%#NewsTitleStyleIsNew(DataBinder.Eval(Container.DataItem, "dCreateTime"))%></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%# Eval("cClassName").ToString()%></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%# Eval("cTypeName").ToString()%></td>
                               <td  class="Table_BG<%# Container.ItemIndex % 2 %>"  ><%#Eval("iViewCount").ToString()%></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><%#Eval("dCreateTime").ToString() %></td>
                           
                              
                              <td  class="Table_BG<%# Container.ItemIndex % 2 %>" >
                              
                              <input type=button value="编辑" onclick="location.href='News_Edit.aspx?Id=<%#Eval("ID").ToString() %>&CId=<%=myChar.RequestQueryString("CId") %>&TId=<%=myChar.RequestQueryString("TId") %>';"  style=" height:20px" /> 
                              </td>
                          </tr></ItemTemplate>
                          <FooterTemplate> 
                   
                        </table></FooterTemplate>
                          </asp:Repeater>
                    
                          
                      </td>
                    </tr>
                    <tr>
                      <td>
                          <table width="100%" border="0" cellpadding="0" cellspacing="5" bgcolor="#FDFDFF">
                                <tr>
                                  <td align="right">&nbsp;<asp:HyperLink ID="First" runat="server">首页</asp:HyperLink>
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
	if(window.confirm("确定要删除该新闻吗？")){
	
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
	 location.href="?Page=<%=myChar.RequestQueryString("Page") %>&findText="+$("#findText").val()+"&TId="+$("#myNewsType").val() +"&CId="+$("#myNewsClass").val();
	 }
        </script>
    </form>
</body>
</html>
