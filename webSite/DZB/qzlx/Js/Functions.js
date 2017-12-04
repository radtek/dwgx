// JScript 文件

//检查表单是否为空！
 function chkForm(ElmArr){
 var objArr=ElmArr.split('|');
for(var i=0;i<objArr.length;i++){
//如果为空值
if($("#"+objArr[i]).val().length==0){
 //如果有tips属性
 if(typeof($("#"+objArr[i]).attr("tips"))!="undefined"){
alert(""+$("#"+objArr[i]).attr("tips")+"项不能为空！");

}else{
alert("请输入该项!");
}
$("#"+objArr[i]).focus();
return false;
}
}

 return true;
 }
 
 
 
 //左边菜单点击效果
 function leftMenuClick(){
 $("a").click( function () {
   
    //$(this).hide(); 
    $(".Menu_ClickLink").removeClass("Menu_ClickLink");
    $(this).addClass("Menu_ClickLink");
      //return false;
    }
  
    ); 
    
    $(".Menu_ClickLink").get(0).click();

}

function WinOpenEnterprise(){
    window.open('/Inc/EnterpriseList.aspx', 'EnterpriseList', 'height=500,width=900,top=0,left=0,toolbar=no,menubar=no,scrollbars=yes, resizable=no,location=no, status=no');
}


function WinOpen(url,name,w,h) {
    window.open(url, name, 'height='+h+',width='+w+',top=0,left=0,toolbar=no,menubar=no,scrollbars=yes, resizable=yes,location=no, status=no');
}

function WinOpenProjectList(id) {
    window.open('/Client/Project_List.aspx?id='+id, 'Event_List'+id, 'height=500,width=900,top=0,left=0,toolbar=no,menubar=no,scrollbars=yes, resizable=no,location=no, status=no');
}
 
 //取得城市列表
function getCityList(ProvinceObj,CityObj,selectCityId){
$.ajax({
type:"GET",
url:"/Tools/getCityList.aspx?provinceId="+ProvinceObj.value,
beforeSend: function(){
			//ShowLoading();
		},
		success: function(data){
		//var xmlDoc = loadXML(false,data);//这时的data只是普通的字条串，经过这步后的xmlDoc才是xml对象了
		   // alert($(data).find("Table cCityName").eq(0).text());
		   var optionHTML="<option value=''>城市</option>";
		    $(data).find("Table").each(function(){
		    var cCityName=$(this).find("cCityName").text();
		    var cityId=$(this).find("cityId").text();
		    var iProvinceId=$(this).find("iProvinceId").text();
		    if(selectCityId==cityId){
		      optionHTML=optionHTML+"<option value='"+cityId+"' selected>"+cCityName+"</option>";
		    }else{
		  optionHTML=optionHTML+"<option value='"+cityId+"'>"+cCityName+"</option>";
		  }
		    });
		       $("#"+CityObj).html(optionHTML);
		},
		complete: function(XMLHttpRequest, textStatus){
			//HideLoading();
			 
		},
		error: function(){
			//请求出错处理
			alert("城市列表获取出错，请刷新再试！");
		}

});
}

//取得地区列表
function getZoneList(CityObj,ZoneObj,selectZoneId){
$.ajax({
type:"GET",
url:"/Tools/getZoneList.aspx?cityId="+CityObj.value,
beforeSend: function(){
			//ShowLoading();
		},
		success: function(data){
		//var xmlDoc = loadXML(false,data);//这时的data只是普通的字条串，经过这步后的xmlDoc才是xml对象了
		   var optionHTML="<option value=''>地区</option>";
		    $(data).find("Table").each(function(){
		    var cZoneName=$(this).find("cZoneName").text();
		    var zoneId=$(this).find("zoneId").text();
		    var iCityId=$(this).find("iCityId").text();
		    if(selectZoneId==zoneId){
		      optionHTML=optionHTML+"<option value='"+zoneId+"' selected>"+cZoneName+"</option>";
		    }else{
		  optionHTML=optionHTML+"<option value='"+zoneId+"'>"+cZoneName+"</option>";
		  }
		    });
		       $("#"+ZoneObj).html(optionHTML);
		},
		complete: function(XMLHttpRequest, textStatus){
			//HideLoading();
			 
		},
		error: function(){
			//请求出错处理
			alert("地区列表获取出错，请刷新再试！");
		}

});
}
 
 
 


/**

* 封装装载XML的方法,并返回XML文档的根元素节点。

* @param flag true时参数xml表示xml文档的名称；false时参数xml是一个字符串，其内容是一个xml文档

* @param xml 根据flag参数的不同表示xml文档的名称或一个xml文档的字符串表示

*/

function loadXML(flag,xml){

var xmlDoc;

//针对IE浏览器

if(window.ActiveXObject){

var aVersions = ["MSXML2.DOMDocument.6.0","MSXML2.DOMDocument.5.0","MSXML2.DOMDocument.4.0","MSXML2.DOMDocument.3.0","MSXML2.DOMDocument","Microsoft.XmlDom"];

for (var i = 0; i < aVersions.length; i++) {

try {

//建立xml对象

xmlDoc = new ActiveXObject(aVersions[i]);

break;

} catch (oError) {

}

}

if(xmlDoc != null){

    //同步方式加载XML数据

xmlDoc.async = false;

//根据XML文档名称装载

if(flag == true){

        xmlDoc.load(xml);

} else{

        //根据表示XML文档的字符串装载

        xmlDoc.loadXML(xml);

}

//返回XML文档的根元素节点。

return xmlDoc.documentElement;

}

} else{

//针对非IE浏览器

    if(document.implementation && document.implementation.createDocument){

      /*

       第一个参数表示XML文档使用的namespace的URL地址

       第二个参数表示要被建立的XML文档的根节点名称

       第三个参数是一个DOCTYPE类型对象，表示的是要建立的XML文档中DOCTYPE部分的定义，通常我们直接使用null

       这里我们要装载一个已有的XML文档，所以首先建立一个空文档，因此使用下面的方式

      */

      xmlDoc = document.implementation.createDocument("","",null);

      if(xmlDoc != null){

       //根据XML文档名称装载

        if(flag == true){

          //同步方式加载XML数据

xmlDoc.async = false;

          xmlDoc.load(xml);

        } else{

          //根据表示XML文档的字符串装载

          var oParser = new DOMParser();

          xmlDoc = oParser.parseFromString(xml,"text/xml");

        }

        //返回XML文档的根元素节点。

        return xmlDoc.documentElement;

      }

    }

}

  return null;

}



 
 
 function doForeColor(o){
			var sInitColor = null;
		  	 if (sInitColor == null) 
			var sColor =document.getElementById("dlgHelper").ChooseColorDlg();
			else
			var sColor = dlgHelper.ChooseColorDlg(sInitColor);
			//alert(sColor);
			if(sColor==0)return false;
			sColor = sColor.toString(16)
			if (sColor.length < 6) {
		  	var sTempString = "000000".substring(0,6-sColor.length);
		 	sColor = sTempString.concat(sColor);
		}
			o.value="#"+sColor;
			}
 