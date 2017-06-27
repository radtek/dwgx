<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BottomSliderAdd.aspx.cs" Inherits="Manage_BottomSliderAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
     <link href="Css/style.css" rel="stylesheet" type="text/css" />
     <script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
      <script language="javascript" src="/Js/json.js"></script>
       <style type="text/css">
#authTable {
height:100%; width:100%;
padding:10px;
}
 
 
</style>
<script language="javascript" type="text/javascript">
    function CheckData(frm) {
        if (frm.cRoleName.value == '') {
            alert("请输入角色名称");
            frm.cRoleName.focus();
            return false;
        }
        //权限
        var auth = [];
        var obj = document.getElementById("tabAuth");

        for (var i = 1; i < obj.rows.length; i++)//从1开始,首行为标题
        {
            var checkbox = obj.rows[i].cells[0].getElementsByTagName("INPUT")[0];
            if (!checkbox.checked) continue; //没选中的不提交
            var ctrls = obj.rows[i].cells[1].childNodes;
            var value2 = [];
            for (var j = 0; j < ctrls.length; j++)
                if (ctrls[j].tagName == "INPUT" || ctrls[j].tagName == "SELECT" || ctrls[j].tagName == "TEXTAREA") {
                    //if(typeof ctrls[j].checked != "undefined")
                    if (ctrls[j].tagName == "INPUT" && ctrls[j].type == "checkbox")
                        value2.push(ctrls[j].id + "=" + (ctrls[j].checked ? "1" : "0"));
                    else
                        value2.push(ctrls[j].id + "=" + ctrls[j].value);
                }
            //auth[auth.length] = {name:checkbox.id, checked:(checkbox.checked?1:0), value:(value2.length?value2.join(";"):"")};//没选中的不提交
            auth[auth.length] = { name: checkbox.id, permvalue: (value2.length ? value2.join(";") : "") };
        }
        document.getElementById("AuthValue").value = auth.toJSONString();
        if (auth.length == 0 && !confirm("角色没有授予任何权限，确实要提交吗？")) return false;

        //alert(document.getElementById("AuthValue").value);
        return true;
    }
    function switchView(index) {
        document.getElementById("Users").style.display = (index == 0 ? "block" : "none");
        document.getElementById("authTable").style.display = (index == 1 ? "block" : "none");
        // document.getElementById("tdTabSheet").style.backgroundPositionY = (index == 0 ? "0px" : "29px");
    }
    function InitCtrol(value) {
        var data = value.split(";")
        for (var i = 0; i < data.length; i++) {
            var key = data[i].substr(0, data[i].indexOf("="));
            var val = data[i].substr(data[i].indexOf("=") + 1, data[i].length);
            var obj = document.getElementById(key);
            if (!obj) continue;

            //if(typeof obj.checked != "undefined")
            if (obj.tagName == "INPUT" && obj.type == "checkbox")
                obj.checked = (val == 1 ? true : false);
            else
                obj.value = val;
        }
    }
    function AuthSelectAll(e) {
        var obj = document.getElementById("tabAuth");
        if (!obj) return;
        if (obj.getElementsByTagName) {
            var checkboxes = obj.getElementsByTagName("INPUT");
            for (var i = 0; i < checkboxes.length; i++)
                if (checkboxes[i].type == "checkbox") checkboxes[i].checked = e.checked;
        }
        else
            alert("浏览器不支持此功能");
    }
    window.onload = function () { }
</script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return CheckData(this);">
 
                                                  <input
                                                      type="hidden" id="usersValue" runat="server" />
 
  <input type=hidden id="AuthValue" runat="server" />
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
                                                  <asp:Label ID="myTitle" runat="server" Font-Bold="True" Text="管理底部轮播图"></asp:Label>
                                              </td>
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
                        
                          <table id="Table3" bgcolor="#C4E7FB" border="0" cellpadding="4" cellspacing="1" width="100%">
                             <tr>
                                  <td colspan="1" rowspan="1" bgColor="#f8f8f8">
                                      跳转地址：</td>
                                  <td bgcolor="#ffffff">

                                      <asp:TextBox ID="edtUrl" runat="server" Width="350px"></asp:TextBox>
                                     </td>
                              </tr>
                              <tr>
                                  <td colspan="1" rowspan="1" bgColor="#f8f8f8">
                                      请选择图片：</td>
                                  <td bgcolor="#ffffff">

                                      <asp:FileUpload ID="upFile" runat="server" />
                                     </td>
                              </tr>
                              <tr>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                  </td>
                                  <td bgcolor="#ffffff" style="height: 21px">
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" 上传 " OnClientClick="" />&nbsp;
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
	 

        </script>
    </form>
</body>
</html>
