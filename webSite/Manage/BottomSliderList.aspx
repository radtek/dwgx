<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BottomSliderList.aspx.cs" Inherits="Manage_BottomSliderList" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="../js/jquery-3.1.1.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
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
                                              <td width="250">
                                              <a href="BottomSliderAdd.aspx">
                                                  <img src="images/BTN_Type_Add.jpg"    alt="添加" 
                                                      border=0 /></a>
                                                  <asp:ImageButton ID="ImageButton2" ImageUrl="images/BTN_Type_Delete.jpg" 
                                                      runat="server" OnClick="ImageButton2_Click" ToolTip="删除" 
                                                       /></td>
                                              <td>
                                                  &nbsp;</td>
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
                        
                          <asp:Repeater ID="myDataList" runat=server OnItemCommand="myDataList_ItemCommand">
                          <HeaderTemplate><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#BBD3EB">
                          <tr>
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                              <label>
                              <input type="checkbox" name="KAll" id="KAll"   />
                              </label>
                            </td>
                           
                            <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                图片地址</td>
                             <td height="27" align="center" background="images/index1_72.gif" bgcolor="#FFFFFF">
                                跳转地址</td>
                              <td align="center" background="images/index1_72.gif" bgcolor="#ffffff">
                                  操作</td>
                          </tr></HeaderTemplate>
                          <ItemTemplate>  <tr>
                            <td height="26" align="center" bgcolor="#FFFFFF">
                              <label>
                              <input type="checkbox" name="checkbox" value="<%#Eval("id").ToString() %>" />
                              </label>
                            </td>
                           
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><a href="<%#BCW.Common.Utils.GetUsIP() +"../../../uploads/bottomSlider/"+Eval("cPath") %>" target="_blank"><%# Eval("cPath")%></a></td>
                            <td  class="Table_BG<%# Container.ItemIndex % 2 %>" ><a href="<%#Eval("cUrl") %>" target="_blank"><%# Eval("cUrl")%></a></td>
                              <td  class="Table_BG<%# Container.ItemIndex % 2 %>" align="center">
                                  <a href="<%#BCW.Common.Utils.GetUsIP() +"../../../uploads/bottomSlider/"+Eval("cPath") %>" target="_blank">查看图片</a>
                              </td>
                          </tr></ItemTemplate>
                          <FooterTemplate> 
                   
                        </table></FooterTemplate>
                          </asp:Repeater>
                    
                          
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
    
    $("#ImageButton2").click(function () {

        _str = "";

        $('input[name="checkbox"]:checked').each(function () {
            _str +=this.value + ",";	        
        });

        if (_str.trim() == "") {
            alert("请至少选择一条信息");
            return false;
        }


        if (window.confirm("确定要删除相关的专栏数据吗？")) {

            $.ajax({
                //要用post方式      
                type: "Post",
                //方法所在页面和方法名      
                url: "BottomSliderList.aspx/DeleteSpecialData",
                data: "{str:'" + _str + "'}",
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


	function DeleteIt(objId){
	if(window.confirm("确定要删除该Data吗？")){
	
	$("#Check"+objId).get(0).checked=true;
	  //$("#DeleteButton").click(this);
	$("#DeleteButton").click();
	return true;
	}
	else{
	return false;
	}
	}
	 
        </script>
    </form>
</body>
</html>
