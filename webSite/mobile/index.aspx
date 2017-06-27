<%@ Page Language="C#" MasterPageFile="~/mobile/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="mobile_index" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

<!-- focus -->
<div id="focus" class="focus">
    <div class="hd"><!--begin 3121167-0-1--><ul></ul><!--end 3121167-0-1-->
    </div>

    <div class="bd"><!--begin 3121168-143376-1-->
        <ul>
            <asp:Repeater ID="scrollAd" runat="server" >
            <ItemTemplate>
               <li><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>" target="_blank"><img src="<%#"/uploads/" + Eval("cPicPath").ToString()%>" width="600" height="410" alt=<%#Eval("cTitle").ToString()%> /></a>
                  <p><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>" target="_blank"><%#Eval("cTitle").ToString()%></a></p>
               </li>
            </ItemTemplate>
        </asp:Repeater>


        </ul><!--end 3121168-143376-1-->
    </div>
</div>

<!-- focus end-->

<!--大旺新闻 top-news-list -->
<div class="top-news-list"><!--begin 3121169-143377-1-->
    <ul>
        <asp:Repeater ID="rptDwNews" runat="server" >
            <ItemTemplate>
              <tr>
                 <li><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),48,"...")%></a></li>
              </tr>
            </ItemTemplate>
        </asp:Repeater>

    </ul><!--end 3121169-143377-1-->
<!--begin 3121170-143377-1--><!--end 3121170-143377-1-->
</div>

<!-- top-news-list end-->
<!-- 广告 -->
<div id="adimg"><a href="javascript:void(0)http://gbh.dayoo.com" target="_blank"><img src="images/banner.png" width="100%"/></a> <span onClick="document.getElementById('adimg').style.display='none';">&#160;</span></div>

<!-- 广告 end-->

<div id="section_tab_1" class="section">
<div class="hd">
<ul>


<li><a href="javascript:void(0)javascript:void(0)" target="_self">通知</a></li>

<li><a href="javascript:void(0)javascript:void(0)" target="_self">政策</a></li>

<li><a href="javascript:void(0)javascript:void(0)" target="_self">专题</a></li>
<li><a href="javascript:void(0)javascript:void(0)" target="_self">年报</a></li>
</ul>
</div>

<div class="bd">
<div>
    
<!--通知  begin 3121171-143378-1-->

<asp:Repeater ID="rptNotice" runat="server" >
    <ItemTemplate>
        <div class="news-card">
        

        <div class="txt-area">
        <div class="news-title"><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),55,"...")%></a></div>

        <div class="news-date"><%#DateTime.Parse(Eval("dCreateTime").ToString()).ToString("yyyy-MM-dd hh:mm")%></div>
        </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
<!--end 3121171-143378-1-->


<!--begin 3121172-143378-1--><a class="list-more-btn" href="class.aspx?typeId=3">更多资讯<i></i></a><!--end 3121172-143378-1-->
</div>

<div>
    <!--政策 begin 3121173-143379-1-->
    <asp:Repeater ID="rptPolicy" runat="server" >
        <ItemTemplate>
            <div class="news-card">
            

            <div class="txt-area">
            <div class="news-title"><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),55,"...")%></a></div>

            <div class="news-date"><%#DateTime.Parse(Eval("dCreateTime").ToString()).ToString("yyyy-MM-dd hh:mm")%></div>
            </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
<!--end 3121173-143379-1-->
<!--begin 3121174-143379-1--><a class="list-more-btn" href="class.aspx?typeId=30">更多资讯<i></i></a><!--end 3121174-143379-1-->
</div>

<div>
    <!--专题 begin 3121175-143475-1-->
    <asp:Repeater ID="rptSpecial" runat="server" >
        <ItemTemplate>
            <div class="news-card">
           

            <div class="txt-area">
            <div class="news-title"><a href="class.aspx?TypeId=<%#Eval("ID").ToString()%>"><%#Eval("cTypeName").ToString()%></a></div>

           <div class="news-date"><%#DateTime.Parse(Eval("dCreateTime").ToString()).ToString("yyyy-MM-dd hh:mm")%></div>
            </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>    
<!--end 3121175-143475-1-->
<!--begin 3121176-143475-1--><a class="list-more-btn" href="speciaTypelList.aspx?TypeId=5">更多资讯<i></i></a><!--end 3121176-143475-1-->
</div>

<div><!--begin 3121177-143605-1-->
    <asp:Repeater ID="rptAnualReport" runat="server" >
        <ItemTemplate>
            <div class="news-card">
            

            <div class="txt-area">
            <div class="news-title"><a href="NewDetail.aspx?id=<%#Eval("ID").ToString()%>"><%#CommonClass.GetString(Eval("cTitle").ToString(),55,"...")%></a></div>

            <div class="news-date"><%#DateTime.Parse(Eval("dCreateTime").ToString()).ToString("yyyy-MM-dd hh:mm")%></div>
            </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>  
    
    <!--end 3121177-143605-1-->
<!--begin 3121178-143605-1--><a class="list-more-btn" href="class.aspx?typeId=28">更多资讯<i></i></a><!--end 3121178-143605-1-->
</div>
</div>
</div>

</asp:Content>