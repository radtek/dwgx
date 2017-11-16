<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VoteChart.aspx.cs" Inherits="VoteChart" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
<script src="js/openUrlDialog.js" type="text/javascript"></script>

<script type="text/javascript">

$(document).ready(function(){



	$(".side ul li").hover(function(){

		$(this).find(".sidebox").stop().animate({"width":"124px"},200).css({"opacity":"1","filter":"Alpha(opacity=100)","background":"#3D7ED2"})	

	},function(){

		$(this).find(".sidebox").stop().animate({"width":"54px"},200).css({"opacity":"0.8","filter":"Alpha(opacity=80)","background":"#3D7ED2"})	

	});

	

});



//回到顶部

function goTop(){

	$('html,body').animate({'scrollTop':0},600);

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

    <!-- Custom styles for this template -->
    <link href="css/style.css" rel="stylesheet">


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
    <td width="8%"><a href="index.aspx#qqjj">区情简介</a></td>
    <td width="8%"><a href="index.aspx#zsyz">招商引资</a></td>
    <td width="8%"><a href="index.aspx#zcyz">招才引智</a></td>
    <td width="8%"><a href="index.aspx#team">政务公开</a></td>
    <td width="20%"  ><form name="form1" runat="server" class="headzq_1_seach">
      <label>
         <input name="textfield" type="text" id="findText" runat="server" value="请输入关键字" size="20" maxlength="20"  class="input_1"  onfocus="if(this.value=='请输入关键字'){this.value=''}" onBlur="if(this.value==''){this.value='请输入关键字'}"  onkeypress="qkeypress()"  autocomplete="off" >
      </label>
      <img onclick="FindData()" src="images/seach.jpg" width="53" height="24">
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
    
<section  class="container features">
    <form id="formVote" action="#" onsubmit="return CheckData(this);">
   <table width="100%" border="0" cellspacing="0" cellpadding="0">
     <tr>
    <td colspan="3" class="top3lk_ohter1">当前位置：<a href="index.aspx">网站首页</a> >问卷调查</td>
  </tr>
  <tr>
    <th width="8%" scope="row">&nbsp;</th>
    <td width="84%" class="top2lki_title"align="center"><table width="100%" border="0" cellspacing="0" cellpadding="0">


      <tr>
        <td colspan="3" class="top21tt" style="text-align:center">
            <asp:Chart ID="chartVote" runat="server" Width="600px">
                <series>
                    <asp:Series Name="Series1" ChartType="Bar">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                        <AxisY>
                            <MajorGrid LineWidth="0" />
                        </AxisY>
                        <AxisX>
                            <MajorGrid LineWidth="0" />
                        </AxisX>
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
          </td>
        </tr>
    </table></td>
    <td width="8%">&nbsp;</td>
  </tr>
        </tr>
        <tr><td colspan="2" class="top21tt" style="text-align:center"><Button ID="btnCommit" onclick="window.close();" value="262" />&nbsp;&nbsp;关闭&nbsp;&nbsp;
            </td></tr>

  </table></form>
</section>
    <br/>

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

    <p>    
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqgxjjjc.gov.cn/')" style="margin: 0 10px;"  >区纪检监察网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.job0758.com.cn/V3/')" style="margin: 0 10px;">区人才网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhtmse.com/gd/index.asp')" style="margin: 0 10px;">区中小企业网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzepb.gov.cn/')" style="margin: 0 10px;">区环保局门户网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.padw.gov.cn/')"  style="margin: 0 10px;">肇庆平安大旺</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzst.gov.cn/')" style="margin: 0 10px;">区科技信息网</a>
                    
                
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.gxld.gov.cn/')" style="margin: 0 10px;">区劳动和社会保障局</a>
                    
            <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqhzsafety.gov.cn/')"  style="margin: 0 10px;">区安全监管网</a>
              
        <a href="javascript:void(0)" onclick="OpenUrl('http://www.zqdwedu.com/webschool/News/')"  style="margin: 0 10px;">区教育信息网</a>
    </p>
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

        T$('click_test1').onclick = function(){TINY.box.show(content1,0,0,0,1)}
		
        var content2 = "<img width='290' height='290' src='images/2wm.png' />";//弹出图片

        T$('click_test2').onclick = function () { TINY.box.show(content2, 0, 0, 0, 1) }

        var content3 = "<img width='290' height='290' src='images/DZB.png' />";//弹出图片

        T$('click_test3').onclick = function () { window.location.href = "/DZB/Default.aspx"; }

       
        //查找
        function FindData() {
            location.href = "./class.aspx?seekStr=" + $("#findText").val() + "&ToolTip=搜索结果";
            //  location.href = "News_List.aspx?seekStr="+$("#findText").val();
        }


    </script>
</body>
</html>


