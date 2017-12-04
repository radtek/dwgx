//检查表单是否为空！
function chkForm(ElmArr) {
    var objArr = ElmArr.split('|');
    for (var i = 0; i < objArr.length; i++) {
        //如果为空值
        if ($("#" + objArr[i]).val().length == 0) {
            //如果有tips属性
            if (typeof ($("#" + objArr[i]).attr("tips")) != "undefined") {
                alert("" + $("#" + objArr[i]).attr("tips") + "项不能为空！");

            } else {
                alert("请输入该项!");
            }
            $("#" + objArr[i]).focus();
            return false;
        }
    }

    return true;
}


function OpenFlowWindow(id) {
    window.open("RepairFlow.aspx?id=" + id, "score", "width=950px,height=600px");
}
function OpenFlowViewWindow(id) {
    window.open("RepairFlowView.aspx?id=" + id, "scoreview", "width=950px,height=600px,Top=20,left=30;");
}
 function DelFlowViewWindow(url){
     if (window.confirm('确定要删除该条记录吗？')) {
         location.href = url;
     } else {
         return false;
        
     }
 }

 function DelRepairListWindow(url) {
     if (window.confirm('确定要删除该条记录吗？')) {
         location.href = url;
     } else {
         return false;

     }
 }