<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberEdit.aspx.cs" Inherits="Manage_MemberEdit" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="../js/jquery-3.1.1.min.js"></script>
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
                            <td align="center" background="images/index1_36.gif"><a href="#" class="font3"><strong>帐号管理</strong></a></td>
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
                                      <table width=100% border=0>
                                          <tr>
                                              <td>
                                              <a href="MemberAdd.aspx"><img src="images/BTN_ADD.jpg"    alt="添加账号" border=0 /></a>
                                                  <asp:ImageButton ID="ImageButton1" ImageUrl="images/BTN_EDIT.jpg" runat="server" OnClick="ImageButton1_Click" ToolTip="将密码重设为：1234" />
                                                  <asp:ImageButton ID="ImageButton2" ImageUrl="images/BTN_DELETE.jpg" runat="server" OnClick="ImageButton2_Click" ToolTip="删除账号" /></td>
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
                                用户账号</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                账号名称</td>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                是否有效</td>
                            <td align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                创建时间</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  最后登录时间</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  登录IP</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  登录次数</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  操作</td>
                          </tr></HeaderTemplate>
                          <ItemTemplate>  <tr>
                            <td height="26" align="center" bgcolor="#FFFFFF">
                              <label>
                              <input id="chkData" type="checkbox" name="checkbox" value="<%#Eval("id").ToString() %>" />
                              </label>
                            </td>
                            <td  class="Table_BG0"  ><a href="MemberInfoEdit.aspx?ID=<%#Eval("id").ToString() %>"><%#Eval("name").ToString()%></a></td>
                            <td  class="Table_BG0" ><%#Eval("nickName").ToString() %></td>
                            <td  class="Table_BG0" ><%#Eval("isValid").ToString()=="True"?"有效":"无效" %></td>
                            <td  class="Table_BG0" ><%#Eval("addDate") %></td>
                            <td  class="Table_BG0" ><%#Eval("lastLoginTime") %></td>
                            <td  class="Table_BG0" ><%#Eval("lastLoginIP") %></td>
                            <td  class="Table_BG0" ><%#Eval("loginCount") %></td>
                              
                              <td  class="Table_BG0" >                            
                              
                              <input onclick="location.href='MemberInfoEdit.aspx?ID=<%#Eval("ID").ToString() %>';"
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
                                  <td>&nbsp;<img src="images/index1_78.gif" width="16" height="12" align="absmiddle" />&nbsp;有效&nbsp;&nbsp;<img src="images/index1_75.gif" width="16" height="15" align="absmiddle" />&nbsp;无效</td>
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

	$("#ImageButton2").click(function () {
               
	    _str = "";

	   
	    $('input[name="checkbox"]:checked').each(function () {
	        _str +=this.value + ",";	        
	    });

	    if (_str.trim() == "") {
	        alert("请至少选择一个用户");
	        return false;
	    }

        
	    if (window.confirm("确定要删除该账号吗？")) {
            
	        $.ajax({
	            //要用post方式      
	            type: "Post",
	            //方法所在页面和方法名 
	            url: "MemberEdit.aspx/Delete",
	            data: "{str:'"+_str+"'}",
	            contentType: "application/json; charset=GB2312",
	            dataType: "json",
	            success: function (data) {
	                location.reload(true);
	            },
	            error: function (err) {
	                location.reload(true);
	            }
	        });
	        return false;
	    }
	    else {
	        return false;
	    }
	});

	$("#ImageButton1").click(function () {

	    _str = "";


	    $('input[name="checkbox"]:checked').each(function () {
	        _str += this.value + ",";
	    });

	    if (_str.trim() == "") {
	        alert("请至少选择一个用户");
	        return false;
	    }


	    if (window.confirm("确定要将选定帐号密码重置为：1234？")) {

	        $.ajax({
	            //要用post方式      
	            type: "Post",
	            //方法所在页面和方法名      
	            url: "MemberEdit.aspx/ResetPwd",
	            data: "{str:'" + _str + "'}",
	            contentType: "application/json; charset=GB2312",
	            dataType: "json",
	            success: function (data) {
	                location.reload(true);
	                alert(data.d);
	            },
	            error: function (err) {
	                alert(err);
	            }
	        });
	        return true;
	    }
	    else {
	        return false;
	    }
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
	 function FindData(){
	// location.href="?p=asp:p&findName="+$("#findName").val()+"&iAdminId="+$("#AdminList").val()+"&SortName="+$("#SortName").val()+"&SortSequence="+$("#SortSequence").val();
	 }
        </script>
    </form>
</body>
</html>
