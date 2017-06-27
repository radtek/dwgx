<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="a1" style="text-align:center">
        <script type="text/javascript" src="/ckplayer/ckplayer.js" charset="utf-8"></script>
        <script type="text/javascript">
            var flashvars={
                f: 'http://192.168.1.116:8086/userfiles/20170324%E5%9B%BD%E8%AF%AD%E6%96%B0%E9%97%BB(1).mp4',
                c:0,
                p:1
            };
            var params={bgcolor:'#FFF',allowFullScreen:true,allowScriptAccess:'always',wmode:'transparent'};
            CKobject.embedSWF('/ckplayer/ckplayer.swf','a1','ckplayer_a1','300','200',flashvars,params);
        </script>
        ddsfdfdfdfdfdsf
            </div>
    </form>
</body>
</html>
