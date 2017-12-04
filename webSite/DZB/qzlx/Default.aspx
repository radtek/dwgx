<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="qzlx_Default" %>

<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>

<%@ Register src="Bottom.ascx" tagname="Bottom" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>肇庆国家高新区群众路线网</title>
    <link href="Css/Base.css" rel="stylesheet" type="text/css" />
<link href="Css/style.css" rel="stylesheet" type="text/css" />
       <script language="javascript" src="Js/jquery-1.3.1.min.js"></script>
       <script language=javascript src="js/Init.js"></script>
         <script type="text/javascript" src="Js/MSClass.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
</head>
<body>
    <form id="form1" runat="server">
  <uc1:Top ID="Top1" runat="server" />
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td><table width="999" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td   align="left" valign="top"><div class="Border" style="height:295px" ><table border="0" cellpadding="0" cellspacing="0"  ><tr><td><a href="News_List.aspx?tid=1" target=_blank><img src="images/index_13.jpg" width=663 border=0 /></a></td></tr>
          <tr>
            <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
              <tr>
                  <td width="300"><script type="text/javascript">
<!--

                       <asp:Literal ID="myNews0PicJs" runat=server></asp:Literal>



                                      var focus_width = 300
                                      var focus_height = 228
                                      var text_height = 35
                                      var swf_height = focus_height + text_height
                                      var j = 0;
                                      for (i = 1; i <= cc; i++) {
                                          xb = order[i];
                                          if ((imgUrl[xb] != '') && (imgLink[xb] != '')) {
                                              if (j != 0) {
                                                  pics = pics + '|';
                                                  links = links + '|';
                                                  texts = texts + '|';
                                              }
                                              pics = pics + imgUrl[xb];
                                              links = links + imgLink[xb];
                                              texts = texts + imgText[xb];
                                              j++;
                                          }
                                      }
                                      document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + focus_width + '" height="' + swf_height + '">');
                                      document.write('<param name="allowScriptAccess" value="sameDomain"><param name="movie" value="images/pixviewer.swf"><param name="quality" value="high"><param name="bgcolor" value="#ffffff">');
                                      document.write('<param name="menu" value="false"><param name=wmode value="opaque">');
                                      document.write('<param name="FlashVars" value="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '">');
                                      document.write('<embed src="images/pixviewer.swf" wmode="opaque" FlashVars="pics=' + pics + '&links=' + links + '&texts=' + texts + '&borderwidth=' + focus_width + '&borderheight=' + focus_height + '&textheight=' + text_height + '" menu="false" bgcolor="#dfdfdf" quality="high" width="' + focus_width + '" height="' + focus_height + '" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />'); document.write('</object>');
//-->
                                                                </script>
                      
                  </td>
                  <td valign="top">  
                  <asp:Repeater ID="myNews0List" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="3" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),18) %></a></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater>
                  
                  </td>
                </tr>
        </table></td>
          </tr>
        </table>
        </div></td>
        <td  valign="top" width="10"> </td>
        <td  style="text-align:right; " valign="top" width="327"><div class="Border" style="height:295px" ><table border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td><a href="News_List.aspx?tid=2" target=_blank><img src="images/index_15.jpg" border=0 /></a></td>
          </tr>
          <tr>
            <td bgcolor="#FFFFFF">
            
              <asp:Repeater ID="myNews1List" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="4" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),18) %></a></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater>
            
            </td>
          </tr>
        </table></div></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="5">&nbsp;</td>
  </tr>
  <tr>
    <td><table width="999" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td  align="left" valign="top"><div class="Border"  style="width:327px;height:260px;">
          <table border="0" cellpadding="0" cellspacing="0"  >
            <tr>
              <td><a href="News_List.aspx?tid=3" target=_blank><img src="images/index_18.jpg" border=0 /></a></td>
            </tr>
            <tr>
              <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
                <tr>
                  <td width="360"> <asp:Repeater ID="myNews2List" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="4" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),18) %></a></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater></td>
                  <td>&nbsp;</td>
                </tr>
              </table></td>
            </tr>
          </table>
        </div></td>
        <td align="right" style="text-align:right"  valign="top"  ><div class="Border"  style="width:327px;height:260px;">
          <table border="0" cellpadding="0" cellspacing="0" >
            <tr>
              <td><a href="News_List.aspx?tid=4" target=_blank><img src="images/index_20.jpg" border=0 /></a></td>
            </tr>
            <tr>
              <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
                <tr>
                  <td width="360"> <asp:Repeater ID="myNews3List" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="4" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),18) %></a></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater></td>
                  <td>&nbsp;</td>
                </tr>
              </table></td>
            </tr>
          </table>
        </div></td>
        <td  style="text-align:right;" valign="top" width="327"  ><div class="Border"  style="height:260px;" >
          <table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td><a href="News_List.aspx?tid=5" target=_blank><img src="images/index_21.jpg" border=0 /></a></td>
            </tr>
            <tr>
              <td bgcolor="#FFFFFF"> <asp:Repeater ID="myNews4List" runat=server>
                  <HeaderTemplate><table border="0" width="100%" cellpadding="4" cellspacing="3"></HeaderTemplate>
                  <ItemTemplate><tr><td width="10"><img src="images/dot2.gif" align="absmiddle" /></td><td><a href="News_View.aspx?id=<%#Eval("id").ToString() %>" target=_blank class=Font_14><%#myChar.getStrLength(Eval("cTitle").ToString(),18) %></a></td></tr></ItemTemplate>
                  <FooterTemplate></table></FooterTemplate>
                  </asp:Repeater></td>
            </tr>
          </table>
        </div></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td align="center" style="text-align:center">
    
    

    <table width="999" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td  align="left" valign="top"><div class="Border"  >
      <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><a href="News_List.aspx?tid=6" target=_blank><img src="images/index_25.jpg" border=0 /></a></td>
        </tr>
        <tr>
          <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="2" cellpadding="2">
            <tr>
              <td  >
              <div style="padding:5px; margin 0px auto" > <div id="scroll">
 
               <asp:Repeater ID="myPicList0" runat=server>
									                                     <HeaderTemplate> <table border="0" cellpadding="2" cellspacing="2" width="100%" height="100%"> <tr></HeaderTemplate>
                                            <ItemTemplate>
                                              <td style="text-align:center"><a href="/UploadFile/News/<%#Eval("cPicPath") %>" target=_blank><img src="/UploadFile/News/<%#Eval("cPicPath") %>" border=0   width=200 height=150 alt="<%#Eval("cTitle") %>" style="padding:5px" /> <br /><%#Eval("cTitle")%></a> </td>
                                            </ItemTemplate>
                                           <FooterTemplate></tr> </table></FooterTemplate> </asp:Repeater>

              </div>
<script>

    new Marquee(
     "scroll",  //容器ID<br />  
      2,  //向上滚动(0向上 1向下 2向左 3向右)<br />  
      2,  //滚动的步长<br />  
      976,  //容器可视宽度<br />  
      185,  //容器可视高度<br />  
     200,  //定时器 数值越小，滚动的速度越快(1000=1秒,建议不小于20)<br />  
      0,  //间歇停顿时间(0为不停顿,1000=1秒)<br />  
      1000,  //开始时的等待时间(0为不等待,1000=1秒)<br />  
      160//间歇滚动间距(可选)<br />  
      );

    //alert(document.getElementById("Top1_Menu0Class").style.left);
 
  </script></div>

              
              </td>
              </tr>
          </table></td>
        </tr>
      </table>
    </div></td>
     
      </tr>
    </table>
    
    
    
    
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
  </table>
    

    <uc2:Bottom ID="Bottom1" runat="server" />
    

    </form>
</body>
</html>
