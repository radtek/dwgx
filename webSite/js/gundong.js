// JavaScript Document

<!--
function fLoginFormSubmit()
{
}

var nTime = 120;
var nFocus= 0;
var bFlag = false;
var aLiTab , aDivTab;
function fAutoSwitch(){
	var n = nFocus + 1;
	if(n >=3){
		n = 0;
	}
	if(!bFlag){
		aLiTab[n].onmouseover();
		bFlag = false;
	}
}
window.onload = function(){
	var $ = function($){
		return document.getElementById($);
	};
	aLiTab = $("oUlTab").getElementsByTagName("li");
	aDivTab = [$("oDivTab1") , $("oDivTab2") , $("oDivTab3") , $("oDivTab4")];
	for(var i=0;i<aLiTab.length;i++){
		(function(i){
			var t = aLiTab[i];
			t.onmouseover = function(){
				if(nFocus != i){
					aLiTab[nFocus].className = "";
					aDivTab[nFocus].style.display = "none";
					nFocus = i;
					aLiTab[nFocus].className = "on";
					aDivTab[nFocus].style.display = "";
				}
				bFlag = true;
			};
			t.onmouseout = function(){
				bFlag = false;
			};
		})(i);
	}
	setInterval("fAutoSwitch()",nTime * 1000);
	var oParam = {};
	var sParam = location.search.substr(1);sParam = sParam.replace(/\&amp\;/gi,"&");
	var aParam = sParam.split(/[=\&]/);
	var i , l;
	for(i=0,l=aParam.length;i<l;i+=2){
		oParam[aParam[i]] = aParam[i+1];
	}	
};

//-->
  
      //弹出窗口
function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
} 



//显示大图
function showPic(sUrl){ 
 var x,y,width,height; 
 x = event.clientX; 
 y = event.clientY; 
 width = 50
 height = 50
 
 document.getElementById("picLayer").style.left = x; 
 document.getElementById("picLayer").style.top = y; 
  document.getElementById("picLayer").style.width = "width";  
   document.getElementById("picLayer").style.height = "height"; 
 document.getElementById("picLayer").innerHTML = "<img src=\"" + sUrl + "\">"; 
 document.getElementById("picLayer").style.display = "block"; 
} 

//隐藏大图
function hiddenPic(){ 
 document.getElementById("picLayer").innerHTML = ""; 
 document.getElementById("picLayer").style.display = "none"; 
} 


