<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Add Your favicon here -->
    <!--<link rel="icon" href="img/favicon.ico">-->

    <title>肇庆国家高新区 - 肇庆国家高新技术产业开发区欢迎您！</title>
  
<!--<link rel="stylesheet" href="css/style_add.css" type="text/css" />-->

<!--加入统计信息 begin-->
<script language="JavaScript">var _trackDataType = "web";var _trackData = _trackData || [];</script>
<script type="text/javascript" charset="utf-8" id="kpyfx_js_id_10003317" src="//fxsjcj.kaipuyun.cn/count/10003317/10003317.js"></script>
<!--加入统计信息 end-->

 <script src="js/jquery-2.0.3.min.js" type="text/javascript"></script>	

<script src="js/gundong.js" type="text/javascript"></script>
<script src="js/openUrlDialog.js" type="text/javascript"></script>	
    	
<script type="text/javascript">

$(document).ready(function(){
    
	$(".side ul li").hover(function(){

		$(this).find(".sidebox").stop().animate({"width":"124px"},200).css({"opacity":"1","filter":"Alpha(opacity=100)","background":"#3D7ED2"})	

	},function(){

		$(this).find(".sidebox").stop().animate({"width":"54px"},200).css({"opacity":"0.8","filter":"Alpha(opacity=80)","background":"#3D7ED2"})	

	});


    //获取政声数据
	$.ajax{

	}


    
});



//回到顶部

function goTop(){

	$('html,body').animate({'scrollTop':0},600);

}

</script>
<script>
    var jq=jQuery.noConflict();

//跳转手机版

var TRS = {};
var isPc=0;
isPc= document.URL;
if(isPc.indexOf("?a=m")<0){

TRS.debug = false;
if (TRS.debug){
    !!console && console.log("common init start!");
}
//判断访问者的终端类型
TRS.getClientType = function(){
    var type = new Array("Android","iPhone","Windows Phone","iPod","BlackBerry","MeeGo","SymbianOS",'iPad');
    var info = navigator.userAgent;
 //  alert(info);
    for(var i=0; i<type.length; i++){
        if(info.indexOf(type[i])>0){
            return "Mobile";
        }
    }
    return "PC";
}

//判断手机终端类型
TRS.getMobileType = function(){
    var type = new Array("Android","iPhone");
    var info = navigator.userAgent;
    for(var i=0; i<type.length; i++){
        if(info.indexOf(type[i])>0){
            return type[i];
        }
    }
}


// 跳转逻辑 2014-11-13
var url = document.URL,
    clientType = TRS.getClientType();

if(clientType == 'Mobile'){
    //如果跳转到移动主张，这里就写主站的访问地址，例如：location.href="wap.zqgx.gov.cn";
    //location.href = url.split(".html")[0]+'/mobile/index.html';
    location.href="wap.zqgx.gov.cn"; 
}else if(clientType == 'PC'){
}

}else{
jQuery(document).ready(function(){
 jQuery(".rnav").remove();})

}
</script>
    
<style type="text/css">

#tinybox{position:absolute; display:none; padding:0px;  z-index:2000;}
/*#tinybox{position:absolute; display:none; padding:10px; background:#ffffff url(image/preload.gif) no-repeat 50% 50%; border:10px solid #e3e3e3; z-index:2000;}
*/
#tinymask{position:absolute; display:none; top:0; left:0; height:100%; width:100%; background:#000; z-index:1500;}

</style>

<script type="text/javascript" src="js/tinybox.js"></script>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Animation CSS -->
    <link href="css/animate.min.css" rel="stylesheet">

    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


    <!-- Bottom slider -->
    <script src="js/min/jquery-v1.10.2.min.js"></script>
    <script src="js/min/modernizr-custom-v2.7.1.min.js"></script>
    <script src="js/min/jquery-finger-v0.1.0.min.js"></script>
    <script src="js/min/flickerplate.min.js"></script>
    <link href="css/flickerplate.css" rel="stylesheet" type="text/css">

    <!-- Custom styles for this template -->
    <link href="css/style.css" rel="stylesheet">

    <script>
    $(function(){
        $('.flicker-example').flickerplate(
        {
            auto_flick                 : true,
            auto_flick_delay       : 8,
            flick_animation        : 'transform-slide'
        });
    });
    </script>



</head>

<body id="page-top">


<!--<div class="headzq">-->
<section id="featuresa" class="container servicesa">

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="91" class="headzq_logo"><img src="images/logo.png" width="81" height="120"></td>
    <td width="323" class="headzq_logo_text" >肇庆国家高新区
      <p class="headzq_logo_text_x">zhaoqing  HI-TECH INDUSTRIAL DEVELOPMENT ZONE</p></td>
    <td width="200" class="top-date">
        <script language=JavaScript>
            var d, s = "";
            var x = new Array("星期日", "星期一", "星期二","星期三","星期四", "星期五","星期六");
            d = new Date();
            s+=d.getFullYear()+"年"+(d.getMonth() + 1)+"月"+d.getDate()+"日　";
            s+=x[d.getDay()];
            document.writeln(s);
         </script>
    </td>
    <td width="525" class="headzq_right"><table width="100%" height="66" border="0" cellpadding="0" cellspacing="0">

      <tr>
        <td width="9%"><a href="mailto:zqgxqld@163.com"><img src="images/timg 2.jpg" width="40" height="40"></a></td>
        <td width="23%" class="headzq_right_text">领导信箱zqgxqld@163.com</td>
        <td width="9%"><a href="javascript:void(0)" onclick="OpenUrl('http://wz.zhaoqing.gov.cn/wzpt')"><img src="images/timg_ad.jpg" width="40" height="40"></a></td>
        <td width="25%" class="headzq_right_text">在线访谈wz.zhaoqing.gov.cn/wzpt</td>
        <td width="9%"><a href="VoteList.aspx?toolTip=问卷调查" target="_blank"><img src="images/timg.jpg" width="40" height="40"><a></td>
        <td width="25%" class="headzq_right_text">问卷调查www.zqgx.gov.cn/survey</td>
      </tr>

    </table></td>
  </tr>
  </table>
</section>
<!--</div>-->
<!--<div class="headzq_1">-->
<div    class="navy-sectionss testimonialsss">
<section id="featuresa" class="container servicesa" >
<table width="100%" border="0" cellspacing="0" cellpadding="0" height="30">
  <tr>
    <td width="8%"><a href="index.aspx">网站首页</a></td>
    <td width="8%"><a href="newTypeRedirect.ashx?TypeId=2&ToolTip=新闻资讯">新闻资讯</a></td>
    <td width="8%"><a href="#qqjj">区情简介</a></td>
    <td width="8%"><a href="#zsyz">招商引资</a></td>
    <td width="8%"><a href="#zcyz">招才引智</a></td>
    <td width="8%"><a href="#team">政务公开</a></td>
    <td width="20%"  ><form name="form1" runat="server" class="headzq_1_seach">
      <label>
         <input name="textfield" type="text" id="findText" runat="server" value="请输入关键字" size="20" maxlength="20"  class="input_1"  onfocus="if(this.value=='请输入关键字'){this.value=''}" onBlur="if(this.value==''){this.value='请输入关键字'}"  onkeypress="qkeypress()"  autocomplete="off" >
      </label>
      <img onClick="FindData()" src="images/seach.jpg" width="53" height="24">
     <!-- <input name="" type="button"  class="btn2">-->
    </form>
    </td>
  </tr>
</table>
</section>
</div>
<!--</div>-->

<!--<div class="navbar-wrapper">

</div>-->
<div id="inSlider" class="carousel slide carousel-fade" data-ride="carousel">

<div class="carousel-inner" role="listbox">
        <div class="item active">
            <div class="container">
                <div class="carousel-caption blank">
                    <h1>以建设“创新引领、集聚集约，国内一流的国家级高新区”为统领加快推进实施发展“366”工程项目 </h1>
                       
           
   
                    </p>
                </div>

            </div>

            <div class="header-back one"></div>

        </div>
       
   
</div>


<section id="features" class="container services">
   <table width="100%" border="0" cellspacing="0" cellpadding="0" align="">
  <tr>
    <td> <a class="ml20" style="cursor:pointer" id="dwChat"><h2 align="center"><img src="images/weixin.png" width="100" height="100"></h2>
            <p class="featuresh2" style="cursor:pointer;color:#2F79B9" >大旺发布微信公众号</p>
            <p  class="featuresh2"><img src="images/dian.jpg" width="180" height="1"></p></a></td>
    <td> <h2 align="center"><a href="DZB/Default.aspx" target="_blank"><img src="images/book.png" width="100" height="100"></a></h2>
            <p class="featuresh2"><a href="DZB/Default.aspx" target="_blank">大旺通讯电子报</a></p>
           <p  class="featuresh2"><img src="images/dian.jpg" width="180" height="1"></p></td>
    <td> <h2 align="center"><a href="newTypeRedirect.ashx?TypeId=45&ToolTip=高新区电视台"><img src="images/tv.jpg"   width="100" height="100"></a></h2>
            <p class="featuresh2"><a href="newTypeRedirect.ashx?TypeId=45&ToolTip=高新区电视台">高新区电视台</a></p>
           <p  class="featuresh2"><img src="images/dian.jpg" width="180" height="1"></p></td>
    <td> <h2 align="center"><a href="/newTypeRedirect.ashx?TypeId=5&ToolTip=专题专栏"><img src="images/pro.jpg"  width="100" height="100"></a></h2>
            <p class="featuresh2"><a href="/newTypeRedirect.ashx?TypeId=5&ToolTip=专题专栏">专题专栏</a></p>
           <p  class="featuresh2"><img src="images/dian.jpg" width="180" height="1"></p></td>
    <td> <h2 align="center"><a href="javascript:void(0)" onclick="OpenUrl('http://61.146.213.218:9000/portal/website/index.action?areacode=441285')"><img src="images/timg.png"  width="100" height="100"></a></h2>
            <p class="featuresh2"><a href="javascript:void(0)" onclick="OpenUrl('http://61.146.213.218:9000/portal/website/index.action?areacode=441285')">广东省网站办事大厅</a></p>
           <p  class="featuresh2"><img src="images/dian.jpg" width="180" height="1"></p></td>
  </tr>
</table>
</section>

<section  class="container features">
   <table width="100%" border="0" cellspacing="0" cellpadding="0"  class="top20"  >
  <tr valign="top">
   <!-- <td width="55%"> <img src="images/WechatIMG2.jpg" width="600" height="410"></td>-->
    <td width="55%" > <!--UL标签class属性必需，图片alt属性值即标题文字-->

<div class="yx-rotaion">

	<ul class="rotaion_list">

    <asp:Repeater ID="scrollAd" runat="server" >
        <ItemTemplate>
            <li><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>" target="_blank"><img src="<%#"/uploads/" + Eval("cPicPath").ToString()%>" width="600" height="410" alt=<%#Eval("cTitle").ToString()%> /></a></li>
        </ItemTemplate>
    </asp:Repeater>


	</ul>

</div>



<script type="text/javascript" src="js/jquery.min.js"></script>

<script type="text/javascript" src="js/jquery.yx_rotaion.js"></script>

<script type="text/javascript">

$(".yx-rotaion").yx_rotaion({auto:true});

</script></td>
    <td width="45%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td  class="biaotilogo"><div class="top20_text13"><asp:Label ID="No1NewDay" runat="server">28</asp:Label></div><div class="top20_text14"><asp:Label ID="No1NewYearMonth" runat="server">28</asp:Label></div></td>
    <td ><asp:HyperLink  ID="No1NewTitle" runat="server" class="biaotilogo_text"></asp:HyperLink></td>
  </tr>
  <tr>
    <td colspan="2" class="biaotilogo_text1"><asp:Label ID="No1NewContent" runat="server"></asp:Label><font color="#996600"><asp:HyperLink runat="server" ID="No1NewDetail">[详细]</asp:HyperLink></font> </td>
    </tr>

  <tr>
    <td colspan="2"  class="top20" ><table width="100%" border="0" cellspacing="0" cellpadding="0">

    <asp:Repeater ID="rptDwNews" runat="server" >
        <ItemTemplate>
          <tr>
            <td class="top20_text"><%#DateTime.Parse(Eval("dCreateTime").ToString().Substring(0,9)).ToString("yyyy-MM-dd")%>  | </td>
            <td><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),48,"...")%></a></td>
          </tr>
        </ItemTemplate>
    </asp:Repeater>


  
</table>
</td>
    </tr>
</table>
</td>
  </tr>
</table>
</section>



<section id="team" class="gray-section team">
    <div class="container">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="3"  height="100"  class="biaotilogo_text1w">政务公开<div class="biaotilogo_text2w" ><img src="img/line2018.jpg" width="8.6%" height="4"></div></td>
    </tr>
  <tr>
    <td width="46%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="14%" rowspan="6"  valign="top"   ><div class="headzq_right_textf">
          <p class="headzq_right_textff">基本</p>
          <p class="headzq_right_textff">信息</p>
          <p class="headzq_right_textff">公开</p>
        </div>
      <!--  <div class="headzq_right_textfa"></div>-->        </td>
        <td width="12%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=20&ToolTip=领导之窗" ForeColor="White"><img src="img/lindao.png" width="60" height="60"></asp:HyperLink></td>
        <td width="9%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="http://zwgk.zqgx.gov.cn/" ForeColor="White" Target="_blank"><img src="img/bumenxin.png" width="60" height="60"></asp:HyperLink></td>
        <td width="9%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=10&ToolTip=新闻发布会" ForeColor="White"><img src="img/news.png" width="60" height="60"></asp:HyperLink></td>
        <td width="9%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=11&ToolTip=规划统计" ForeColor="White"><img src="img/caizhenjijin.png" width="60" height="60"></asp:HyperLink></td>
       
        <td width="13%" align="center">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=64&ToolTip=区中小企业信息" ForeColor="White"><img src="img/zxqy.png" width="60" height="60"></asp:HyperLink></td>
      </tr>
      
      <tr>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=20&ToolTip=领导之窗" ForeColor="White">领导之窗</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="http://zwgk.zqgx.gov.cn/" ForeColor="White" Target="_blank">部门信息</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=10&ToolTip=新闻发布会" ForeColor="White">新闻发布会</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=11&ToolTip=规划统计" ForeColor="White">规划统计</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=64&ToolTip=区中小企业信息" ForeColor="White">区中小企业信息</asp:HyperLink></td>
      </tr>
      <tr>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=27&ToolTip=人事信息" ForeColor="White"><img src="img/renshi.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=28&ToolTip=公开年报" ForeColor="White"><img src="img/niaobao.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=29&ToolTip=民生工程" ForeColor="White"><img src="img/mingsheng.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=30&ToolTip=政策文件" ForeColor="White"><img src="img/zhenche.png" width="60" height="60"></asp:HyperLink></td>
        <td align="center">&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=75&ToolTip=行政服务中心" ForeColor="White"><img src="img/xzzx.png" width="60" height="60"></asp:HyperLink></td>
      </tr>
      <tr>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=27&ToolTip=人事信息" ForeColor="White">人事信息</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=28&ToolTip=公开年报" ForeColor="White">公开年报</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=29&ToolTip=民生工程" ForeColor="White">民生工程</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=30&ToolTip=政策文件" ForeColor="White">政策文件</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=75&ToolTip=行政服务中心" ForeColor="White">行政服务中心</asp:HyperLink></td>
      </tr>

    </table></td>
    <td width="2%">&nbsp;</td>
    <td width="52%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="14%" rowspan="5" valign="top"><div class="headzq_right_textf">
          <p class="headzq_right_textff">重点</p>
          <p class="headzq_right_textff">信息</p>
          <p class="headzq_right_textff">公开</p>
        </div></td>
        <td width="12%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=31&ToolTip=财政预算决算" ForeColor="White"><img src="img/caizhenjijin1.png" width="60" height="60"></asp:HyperLink></td>
        <td width="6%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=32&ToolTip=环境保护" ForeColor="White"><img src="img/huangbao.png" width="60" height="60"></asp:HyperLink></td>
        <td width="6%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=33&ToolTip=安全生产" ForeColor="White"><img src="img/anquna.png" width="60" height="60"></asp:HyperLink></td>
        <td width="6%">&nbsp;</td>
        <td width="13%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=34&ToolTip=扶贫工作" ForeColor="White"><img src="img/fuping.png" width="60" height="60"></asp:HyperLink></td>
        <td width="6%">&nbsp;</td>
        <td width="8%" align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=35&ToolTip=社保就业" ForeColor="White"><img src="img/shebaojie.png" width="60" height="60"></asp:HyperLink></td>
       
        <td width="8%" align="center">&nbsp;</td>
        <td width="8%" align="center"></td>
      </tr>
      <tr>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=31&ToolTip=财政预算决算" ForeColor="White">财政预算决算</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=32&ToolTip=环境保护" ForeColor="White">环境保护</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=33&ToolTip=安全生产" ForeColor="White">安全生产</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=34&ToolTip=扶贫工作" ForeColor="White">扶贫工作</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=35&ToolTip=社保就业" ForeColor="White">社保就业</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"></td>
      </tr>
      <tr>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=36&ToolTip=征地拆迁" ForeColor="White"><img src="img/zhedi.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=37&ToolTip=科教文卫" ForeColor="White"><img src="img/kejiao.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=38&ToolTip=公共资源" ForeColor="White"><img src="img/gonsxiy.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=39&ToolTip=保障性住房" ForeColor="White"><img src="img/baozhang.png" width="60" height="60"></asp:HyperLink></td>
        <td>&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=40&ToolTip=重点项目" ForeColor="White"><img src="img/zhongdda.png" width="60" height="60"></asp:HyperLink></td>
        <td align="center">&nbsp;</td>
        <td align="center"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=134&ToolTip=警务信息" ForeColor="White"><img src="img/jwxx.png" width="60" height="60"></asp:HyperLink></td>
      </tr>
      <tr>
         <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=36&ToolTip=征地拆迁" ForeColor="White">征地拆迁</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=37&ToolTip=科教文卫" ForeColor="White">科教文卫</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=38&ToolTip=公共资源" ForeColor="White">公共资源</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=39&ToolTip=保障性住房" ForeColor="White">保障性住房</asp:HyperLink></td>
        <td>&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=40&ToolTip=重点项目" ForeColor="White">重点项目</asp:HyperLink></td>
        <td class="top2018">&nbsp;</td>
        <td class="top2018"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=134&ToolTip=警务信息" ForeColor="White">警务信息</asp:HyperLink></td>
      </tr>
    </table></td>
  </tr>
</table>
    </div>
</section>


<section  class="container features">
   <table width="100%" border="0" cellspacing="0" cellpadding="0"  class="top20"  >
  <tr valign="top">
    <td width="44%">
     <div class="ent_c">
			       <div class="bq">
					      <ul id="oUlTab">
                            <li class="on" ><a href="/newTypeRedirect.ashx?TypeId=3&ToolTip=通知公告">通知公告</a></li>
	                         <li ><a href="javascript:void(0)" onclick="OpenUrl('http://www.gd.gov.cn/ywdt/')">政声传递</a></li>
		                     <li ><a href="javascript:void(0)" onclick="OpenUrl('http://wsbs.zhaoqing.gov.cn/portal/website/online/online!findCompletedApprove.action?areacode=441285')">办件结果</a></li>
                          </ul>
                    </div>
                    <div class="img-ios-all"><img src="images/line.jpg" width="100%" height="1"></div>

					  <!---多窗口操作--->
					  <div class="bq_d" id="oDivTab1">
					      <div class="bq_n"><div class="c4"><table width="100%" border="0" cellspacing="0" cellpadding="0" >
            
          <asp:Repeater ID="rptNotice" runat="server" >
              <ItemTemplate>
                 <tr>
                    
                    <td><img src="img/arrow_small_black.gif" width="10" height="10"><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),40,"...")%></a> </td>
                    <td class="top25_text">[ <%#DateTime.Parse(Eval("dCreateTime").ToString().Substring(0,9)).ToString("yyyy-MM-dd")%>]</td>
                  </tr>
              </ItemTemplate>
          </asp:Repeater>


        </table></div>
						  </div>						 
					 </div>

					 <div class="bq_d" id="oDivTab2" style="display:none">
					      <div class="bq_n"><div class="c4">

                              <!--政声传递-->
                                <script type="text/javascript">
	                                $(function(){
	                                       $.ajax({
	       	                                       url : 'http://app.gd.gov.cn/xxts/pushinfo_json.php',
	       	                                       dataType : "jsonp",
	       	                                       jsonp : "pushInfoJsonpCallBack",
	       	                                       jsonpCallback:"pushInfoJsonpCallBack",
	       	                                       success : function(data) {
				                                 $.each(data,function(i,json){
				                                       if(i<=14){
					                                     var descTitle="";
					                                     if(json.title.length<15){
                                                                                      descTitle=json.title;
                                                                             }else{
	                                                                              descTitle=json.title.substr(0,20)+"...";							
                                                                             }
					                                     $("#zscd").append("<tr><td><img src='img/arrow_small_black.gif' width='10' height='10'><a target='_blank'  href='"+json.link+"'>"+descTitle+"</a> </td><td class='top25_text'>[ "+json.pubDate+"]</td></tr>");
					                                }
				                                  })
			                                },
			                                error:function(){
				                                var htmlCont="<li><a herf='#'>站外链接加载出错,请重新加载!</a></li>"
			                                    $("#zscd").append(htmlCont);
				                                return;
			                                }
		                                });
	                                });
                                </script>

                              <table id="zscd" width="100%" border="0" cellspacing="0" cellpadding="0" >

                             </table>

             
                            </div>
						  </div>						 
					 </div>

         			<div class="bq_d" id="oDivTab3"style="display:none" >
					      <div class="bq_n">
                              <div class="c4">
                                  <iframe name="content_frame"   marginwidth=0 marginheight=0 width=100% height=210 src="http://wsbs.zhaoqing.gov.cn/portal/website/online/online!findCompletedApprove.action?areacode=441285" frameborder=0></iframe>
					          </div>
						  </div>						 
					 </div>
								                              
					 </div>

		    </td>
    <td width="56%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td colspan="5"><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top20">
              <tr>
                <td width="3" class="top24_bg">&nbsp;</td>
                <td width="72" class="top2091" id="qqjj">区情简介</td>
                <td width="444"><img src="images/line.jpg" width="100%" height="1"></td>
                <td width="40"><img src="images/line.jpg" width="100%" height="1"></td>
              </tr>
            </table></td>
            </tr>
          <tr>

            </tr>
        </table></td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top209">
  <tr>
               <td width="150" height="136"  class="top21_bg" ><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=10&ToolTip=高新概况" ForeColor="White"><img src="images/cypj_ico1.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=10&ToolTip=高新概况" ForeColor="White">高新概况</asp:HyperLink></p></td>
            <td width="16">&nbsp;</td>
            <td width="176" class="top22_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=11&ToolTip=地理位置" ForeColor="White"><img src="img/dili.png" width="34" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=11&ToolTip=地理位置" ForeColor="White">地理位置</asp:HyperLink></p></td>
            <td width="15">&nbsp;</td>
            <td class="top23_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=12&ToolTip=产业基础" ForeColor="White"><img src="img/Bank.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=12&ToolTip=产业基础" ForeColor="White">产业基础</asp:HyperLink></p></td>
  </tr>
</table>
</td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top2011">
              <tr>
                <td width="3" class="top24_bg">&nbsp;</td>
                <td width="72" class="top2091" id="zsyz">招商引资</td>
                <td width="444"><img src="images/line.jpg" width="100%" height="1"></td>
                <td width="40"><img src="images/line.jpg" width="100%" height="1"></td>
              </tr>
            </table></td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top209">
  <tr>
               <td width="127" height="136"  class="top25_bg" ><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=13&ToolTip=投资环境" ForeColor="White"><img src="img/HUANJING.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/Info.aspx?id=13&ToolTip=投资环境" ForeColor="White">投资环境</asp:HyperLink></p></td>
            <td width="31">&nbsp;</td>
            <td width="127" class="top26_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=52&ToolTip=优惠政策" ForeColor="White"><img src="img/youhuizc.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=52&ToolTip=优惠政策" ForeColor="White">优惠政策</asp:HyperLink></p></td>
            <td width="27">&nbsp;</td>
            <td width="127" class="top27_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=53&ToolTip=招商项目" ForeColor="White"><img src="img/zhangsehn.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=53&ToolTip=招商项目" ForeColor="White">招商项目</asp:HyperLink></p></td>
            <td width="25" >&nbsp;</td>
            <td width="142" class="top28_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=54&ToolTip=投资流程" ForeColor="White"><img src="img/liucheng.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=54&ToolTip=投资流程" ForeColor="White">投资流程</asp:HyperLink></p></td>
  </tr>
</table></td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top2011">
              <tr>
                <td width="3" class="top24_bg">&nbsp;</td>
                <td width="72" class="top2091" id="zcyz">招才引智</td>
                <td width="444"><img src="images/line.jpg" width="100%" height="1"></td>
                <td width="40"><img src="images/line.jpg" width="100%" height="1"></td>
              </tr>
            </table></td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0" class="top209">
  <tr>
               <td width="150" height="136"  class="top21_bg" ><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=55&ToolTip=人才政策" ForeColor="White"><img src="img/recaisds.png" width="40" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=55&ToolTip=人才政策" ForeColor="White">人才政策</asp:HyperLink></p></td>
            <td width="16">&nbsp;</td>
            <td width="176" class="top22_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/rcList.aspx" ForeColor="White"><img src="img/peixun.png" width="54" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/rcList.aspx" ForeColor="White">就业培训</asp:HyperLink></p></td>
            <td width="15">&nbsp;</td>
            <td class="top23_bg"><p class="top21I_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=57&ToolTip=人才计划" ForeColor="White"><img src="img/User.png" width="46" height="46"></asp:HyperLink></p>
                 <p  class="top21k_bg"><asp:HyperLink runat="server" NavigateUrl="~/newTypeRedirect.ashx?TypeId=57&ToolTip=人才计划" ForeColor="White">人才计划</asp:HyperLink></p></td>
  </tr>
</table></td>
      </tr>
    </table></td>
  </tr>
</table>
<br/>
</section>

<!--<section id="contact">
       <div class="flicker-example">
        <ul>        
            <li data-background="img/flicker-1.jpg">
                <div class="flick-title">
                    Flickerplate Is Working
                </div>
                <div class="flick-sub-text">
                    Heaven forbid this package you downloaded is broken. That wouldn't be
                    embarrassing at all.
                </div>
            </li>
            <li data-background="img/flicker-2.jpg">
                <div class="flick-title">
                    Editable via Javascript or CSS
                </div>
                <div class="flick-sub-text">
                    Take a look at the extensive documentation to see how you can change the
                    settings in multiple ways.
                </div>
            </li>
            <li data-background= "img/flicker-3.jpg">
                <div class="flick-title">
                    Touch Enabled Through the Hammer.js Library
                </div>
                <div class="flick-sub-text">
                    Hammer.js is a great touch library that has been included as part of the
                    Flickerplate package.
                </div>
            </li>
        </ul>
    </div>
</section>
-->
    
    <!--Required libraries-->
    <script src="js/min/jquery-v1.10.2.min.js" type="text/javascript"></script>
    <script src="js/min/modernizr-custom-v2.7.1.min.js" type="text/javascript"></script>
    <script src="js/min/hammer-v2.0.3.min.js" type="text/javascript"></script>

<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/superslide.2.1.js"></script>
<link href="css/fullSlide.css" rel="stylesheet" />

<div class="fullSlide">
	<div class="bd">
		<ul>

            <asp:Repeater ID="bottomAd" runat="server">
                <ItemTemplate>
                    <li _src="url(uploads/bottomSlider/<%#Eval("cPath").ToString()%>)"><a href="javascript:void(0)" onclick="var cUrl='<%#Eval("cUrl").ToString()%>'; if (cUrl.indexOf('http')>=0 || cUrl.indexOf('www')>=0) {OpenUrl(cUrl);}"></a></li>
			        
			        </li>
                </ItemTemplate>

            </asp:Repeater>
			
		</ul>
	</div>
	
	<span class="prev"></span>
	<span class="next"></span>
</div><!--fullSlide end-->

<div class="h-wtbz">

    <%--<p>    
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqgxjjjc.gov.cn/')" style="margin: 0 10px;"  >区纪检监察网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.job0758.com.cn/V3/')" style="margin: 0 10px;">区人才网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhtmse.com/gd/index.asp')" style="margin: 0 10px;">区中小企业网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzepb.gov.cn/')" style="margin: 0 10px;">区环保局门户网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.padw.gov.cn/')"  style="margin: 0 10px;">肇庆平安大旺</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzst.gov.cn/')" style="margin: 0 10px;">区科技信息网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.gxld.gov.cn/')" style="margin: 0 10px;">区劳动和社会保障局</a>
                    
            <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzsafety.gov.cn/')"  style="margin: 0 10px;">区安全监管网</a>
              
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqdwedu.com/webschool/News/')"  style="margin: 0 10px;">区教育信息网</a>
    </p>--%>
</div>
  
  
<script type="text/javascript">
$(".fullSlide").hover(function(){
    $(this).find(".prev,.next").stop(true, true).fadeTo("show", 0.5)
},
function(){
    $(this).find(".prev,.next").fadeOut()
});
$(".fullSlide").slide({
    titCell: ".hd ul",
    mainCell: ".bd ul",
    effect: "fold",
    autoPlay: true,
    autoPage: true,
    trigger: "click",
    startFun: function(i) {
        var curLi = jQuery(".fullSlide .bd li").eq(i);
        if ( !! curLi.attr("_src")) {
            curLi.css("background-image", curLi.attr("_src")).removeAttr("_src")
        }
    }
});
</script>

    
<section id="contact" class="gray-section1 contact">        
<div class="headzq">

<table width="100%" border="0" cellspacing="0" cellpadding="0" height="200">
  <tr>
    
    <td width="561" >
    <p class="headzq_logo_text211" >肇庆高新网版权所有，未经书面授权禁止使用。粤ICP备09172506 &nbsp; 网站标识码:4412910009 </p>
<p class="headzq_logo_text211" >主办单位：肇庆国家高新技术产业开发区</p>
<p class="headzq_logo_text211" >技术开发：肇庆国家高新技术产业开发区肇庆高新采编中心 </p>
<p class="headzq_logo_text211" >地 址：高新区政德大街劳动力大楼（行政服务中心）四楼西翼</p>
    
    </td>
    <td width="48"  ><img src="images/tadi.jpg" width="1" height="80%"></td>
    <td width="530" >
   
      <table width="100%" height="66" border="0" cellpadding="0" cellspacing="0" align="right">
        <tr>
          
          <td width="9%"><img src="images/2wm.png" width="100" height="100"></td>
            <td width="9%"><a href="javascript:void(0)" onclick="OpenUrl('http://bszs.conac.cn/sitename?method=show&id=33B99A8643E24B72E053022819AC32CC')"><img src="images/red.png" width="80" height="80"></a></td>
          
          <td width="9%"><a href="javascript:void(0)" onclick="OpenUrl('http://121.43.68.40/exposure/jiucuo.html?site_code=4412910008&url=http%3A%2F%2Fwww.zqgx.gov.cn%2F')"><img src="images/jiucuo.png" width="110" height="55"></a></td>
          <td width="9%" class="headzq_right_text"><a href="javascript:void(0)" onclick="OpenUrl('http://210.76.65.188/newwebsite/main.jsp?id=4412&adir=&wy=1')"><img src="images/jblong.jpg" width="226" height="93"></a></td>
        </tr>
        
      </table></td>
  </tr>
  </table>

</div>

</section>

<!--<script src="js/jquery-2.1.1.js"></script>-->
<script src="js/pace.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/classie.js"></script>
<script src="js/cbpAnimatedHeader.js"></script>
<script src="js/wow.min.js"></script>
<script src="js/inspinia.js"></script>
  
<div class="side">

	<ul>


		<li><a class="ml20"  id="click_test1"><div class="sidebox"><img src="img/weixin.png">官方微信</div></a></li>

		<li><a class="ml20"  id="click_test2"><div class="sidebox"><img src="img/mobie.png">手机版</div></a></li>

		<li><a class="ml20"  id="click_test3" ><div class="sidebox"><img src="img/tengxun.png">电子报</div></a></li>

		<li style="border:none;"><a href="javascript:goTop();" class="sidetop"><img src="img/side_icon05.png"></a></li>

	</ul>

</div>
<script type="text/javascript">

        
        var content1 = "<img width='290' height='290' src='images/2wm.png' />";//弹出图片

        T$('click_test1').onclick = function () { TINY.box.show(content1, 0, 0, 0, 1) }
        T$('dwChat').onclick = function () { TINY.box.show(content1, 0, 0, 0, 1) }
		
        var content2 = "<img width='290' height='290' src='images/2wm.png' />";//弹出图片

        T$('click_test2').onclick = function () { TINY.box.show(content2, 0, 0, 0, 1) }

        var content3 = "<img width='290' height='290' src='images/DZB.png' />";//弹出图片

        T$('click_test3').onclick = function () {window.location.href="/DZB/Default.aspx"; }
        

    	 //查找
        function FindData() {
            location.href = "./class.aspx?seekStr=" + $("#findText").val()+"&ToolTip=搜索结果";
	  //  location.href = "News_List.aspx?seekStr="+$("#findText").val();
	 }
        </script>

    </script>
</body>
</html>
