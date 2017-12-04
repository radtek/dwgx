<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News_View.aspx.cs" Inherits="News_View" %>

<%@ Register src="UC/Bottom.ascx" tagname="Bottom" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <title>大旺通讯电子报 </title>
<meta name="keywords" content="大旺通讯电子报" />
<meta name="description" content="大旺通讯电子报" />
<link href="images/style.css" rel="stylesheet" type="text/css" />
<script src="js/jquery-1.4.2.min.js" type="text/javascript"></script>
<script src="js/jq_scroll.js" type="text/javascript"></script>
<script src="js/tip_tool.js" type="text/javascript"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('.i_a_box').hover(function () {
            $(this).addClass("i_a_box_hover");
        }, function () {
            $(this).removeClass("i_a_box_hover");
        });
    });

    function doZoom(size) {
        var zoom = document.all ? document.all['Zoom'] : document.getElementById('Zoom');
        zoom.style.fontSize = size + 'px';
    }
 
</script>

</head>
<body>
    <form id="form1" runat="server">
   <DIV id="main_cont">
<div class="main_left">
    	<div id="forum_pic_box">
        	<div class="f_p_h">
            	<div class="f_p_p"><img  id="myPic" runat=server width="430" height="600" usemap="#imgmap"/></div>
				<map id="imgmap" name="imgmap"> 
                
            	  <asp:Repeater ID="myMap" runat=server>
                <ItemTemplate>
                <area onmouseover="cvi_tip._show(event);" onmousemove="cvi_tip._move(event);" onmouseout="cvi_tip._hide(event);" shape="rect" coords="<%# Eval("cMap") %>" tooltip="<%# Eval("cTitle") %>" href="News_View.aspx?id=<%# Eval("id") %>&TID=<%=myChar.RequestQueryString("TID") %>"/>
                </ItemTemplate></asp:Repeater>
</map> 
            </div>
        </div>
                    <div class="qi_menu black_link">
            	<span class="fl"><asp:HyperLink ID="myUpType" Text="<上一版" runat=server></asp:HyperLink>&nbsp; &nbsp; <asp:HyperLink ID="myDownType" runat=server Text="下一版 >"></asp:HyperLink></span>
                
            </div>
    </div>
    <div class="main_right">
    	<div id="header">
        	<div class="logo"></div>
            <div class="header_nav">
				<span class="fl">
					<ul class="paper_menu black_link">
                    	<li><a href="Default.aspx">返回首页</li>
                        <li><a href="Default.aspx?TID=<%=myChar.RequestQueryString("TID") %>">返回版面</li>
                        <li><a href="#">版面导航</a>
                        	<ul>
                          <asp:Repeater ID="myNewsType" runat=server>
<ItemTemplate>
<li><a href='Default.aspx?TID=<%#Eval("ID") %>'><%#Eval("cTypeName") %></a></li>
</ItemTemplate></asp:Repeater>
 
                            </ul>
                        </li> 
                        <li><a href="ReView.aspx">往期回顾</a></li>
                    </ul>
                </span>
                <span class="fr"></span>
            </div>
        </div>
                    	
 
            <div class="paper_article_cont">
				<h1 class="a_title"><asp:Literal ID="cTitle" runat=server></asp:Literal></h1>
                <div class="a_info black_link">时间：<asp:Literal ID="dCreateTime" runat=server></asp:Literal>&nbsp; &nbsp;字体【<a href="javascript:doZoom(12)">小</a> <a href="javascript:doZoom(14)">中</a> <a href="javascript:doZoom(16)">大</a>】      
                </div>
                <div class="a_content" id="Zoom">
                <asp:Literal ID="cContent" runat=server></asp:Literal>
	</div>
            </div>
            
            
            <div class="a_menu black_link">
            <asp:HyperLink ID="myUpNews" Text="" runat=server></asp:HyperLink>&nbsp; &nbsp; <asp:HyperLink ID="myDownNews" runat=server Text=""></asp:HyperLink>
            </div>
            
    </div>
    
</DIV>
 


    <uc1:Bottom ID="Bottom1" runat="server" />
 


    </form>
</body>
</html>
