<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
<style type="text/css">
 
.Font_B  span
{
	font-weight:bold;
	color:Blue;
}
</style>


<script type="text/javascript">
    $(document).ready(function () {
        $("#index_a_list").Scroll({ line: 2, speed: 500, timer: 3000, up: "index_a_up", down: "index_a_next" });
        $("#index_f_list").Scroll({ line: 2, speed: 500, timer: 3000, up: "index_f_up", down: "index_f_next" });
    });
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
                <area onmouseover="cvi_tip._show(event);" onmousemove="cvi_tip._move(event);" onmouseout="cvi_tip._hide(event);" shape="rect" coords="<%# Eval("cMap") %>" tooltip="<%# Eval("cTitle") %>" href="News_View.aspx?id=<%# Eval("id") %>&TID=<%=TID %>"/>
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
				<span class="fl qikan_menu">大旺通讯电子报 - <asp:Literal ID="myCurrClass" 
                    runat="server"></asp:Literal>
                </span>
                
                &nbsp;<span class="fr qikan_next black_link"><asp:HyperLink ID="myUpClass" Text="<上一期" runat=server></asp:HyperLink>&nbsp; &nbsp; <asp:HyperLink ID="myDownClass" runat=server Text="下一期 >"></asp:HyperLink></span>
                <a href="ReView.aspx">往期回顾</a></div> </div>
            
            <div class="index_article_box">
            	<div class="article_box_title"><span><asp:Literal ID="myTT" 
                    runat="server" Text="A1版：国内新闻"></asp:Literal> - 新闻列表</span></div>
                <div id="index_a_up"></div>
                <div id="index_a_list" class="black_link">
                	<ul>
                    <asp:Repeater ID="myNewsList" runat=server>
                    <ItemTemplate>
                    <li><a href="News_View.aspx?id=<%#Eval("id") %>&TID=<%=TID %>" ><%#Eval("cTitle") %></a></li>
                    </ItemTemplate>
                    </asp:Repeater>

                    </ul>
                </div>
                <div id="index_a_next"></div>
            </div>
            <div class="index_forum_box">
            	<div class="article_box_title"><span>版面导航</span></div>
                <div id="index_f_up"></div>
                <div id="index_f_list"  class="black_link">
                <ul>
<asp:Repeater ID="myNewsType" runat=server>
<ItemTemplate>
<li class="<%#CurrType(TID,Eval("ID")) %>"><a href='?TID=<%#Eval("ID") %>'><span><%#Eval("cTypeName") %></span></a></li>
</ItemTemplate></asp:Repeater>
                 </ul>
                </div>
                <div id="index_f_next"></div>
            </div>
            
        </div>
    </div>
 

 
    <uc1:Bottom ID="Bottom1" runat="server" />
 

 
    </form>
</body>
</html>
