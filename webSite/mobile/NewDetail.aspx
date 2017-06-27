<%@ Page Language="C#" MasterPageFile="~/mobile/MasterPage.master" AutoEventWireup="true" CodeFile="NewDetail.aspx.cs" Inherits="mobile_NewDetail" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

<link rel="stylesheet" href="css/article.css?v201605101205">
<link rel="stylesheet" media="screen and (max-width:768px)" href="css/article.responsive.css?v201605101205">

<!-- ad-area-wrap end-->
<!-- dy-layout -->
<div class="dy-layout"><!-- dy-hd -->
<!-- dy-hd end-->
<!-- dy-bd -->
<div class="dy-bd"><!-- dy-content -->
<div class="dy-content"><!-- crumbs -->
<!-- crumbs end-->
<!-- dy-article -->
<div class="dy-article">
<div class="article-hd"><h1> <asp:Label ID="cTitle" runat="server"></asp:Label></h1>
<div class="article-hd-info">
<div class="article-time-source"><asp:Label ID="newSource" runat="server"></asp:Label>
</div>


</div>
</div>

<div class="content"><div id="text_content"> 
<asp:Label ID="cContent" runat="server"></asp:Label>
</div>
</div>

</asp:Content>
