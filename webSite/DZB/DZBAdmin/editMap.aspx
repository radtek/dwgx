<%@ page language="C#" autoeventwireup="true" inherits="DZBAdmin_editMap, App_Web_lekpraw3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=GB2312" />
    <link href="css/map.css" rel="stylesheet" type="text/css" />
<script language="javascript" src="/Js/jquery-1.3.1.min.js"></script>
<script src="artDialog/jquery.artDialog.source.js?skin=default"></script>
<script src="artDialog/iframeTools.source.js"></script>
<script language="JavaScript" type="text/javascript" src="js/dragresize.js"></script>
 
 
<script>
    (function () {
        var parent = art.dialog.parent,
        // 父页面window对象
    api = art.dialog.open.api;
        if (!api) return;
        api.button({
            name: '确定',
            callback: function () {
                var origin = artDialog.open.origin;
                var aValue = document.getElementById('coordinate').value;
                var input = origin.document.getElementById('cMap');
                input.value = aValue;
                input.select();
                art.dialog.close();

                return true;
            },
            focus: true
        },
    {
        name: '取消',
        callback: function () {
            return true;
        }
    });
        window.onload = function () {
            var pos = $(".drsElement").position();
            var coord = pos.left + "," + pos.top + "," + $("#cheng").width() + "," + $("#cheng").height();
            $("#coordinate").val(coord);
        };

    })();
</script>
<script type="text/javascript">


    var dragresize = new DragResize('dragresize',
 { minWidth: 50, minHeight: 50, minLeft: 0, minTop: 0, maxLeft: 430, maxTop: 600 });
    dragresize.isElement = function (elm) {
        if (elm.className && elm.className.indexOf('drsElement') > -1) return true;
    };
    dragresize.isHandle = function (elm) {
        if (elm.className && elm.className.indexOf('drsMoveHandle') > -1) return true;
    };
    dragresize.ondragfocus = function () { };
    dragresize.ondragstart = function (isResize) { };
    dragresize.ondragmove = function (isResize) { };
    dragresize.ondragend = function (isResize) {
        var pos = $(".drsElement").position();
        var coord = pos.left + "," + pos.top + "," + $("#cheng").width() + "," + $("#cheng").height();

        var mapCoord = pos.left + "," + pos.top + "," + (pos.left + $("#cheng").width()) + "," + (pos.top + $("#cheng").height());

        $("#coordinate").val(mapCoord);
    };
    dragresize.ondragblur = function () { };
    dragresize.apply(document);
</script>
 

</head>
<body>
    <form id="form1" runat="server">
<input name="coordinate" id="coordinate" type="hidden" />
<div id="box">
    <asp:Image ID="cPic" runat="server" Height="600px" Width="430px" />
<div id="cheng" class="drsElement drsMoveHandle" style=" position:absolute;left: 150px; top: 280px; width: 100px; height: 100px; color:#FFF; background-image:url(js/loading_background.png); text-align: center">
1、请点击调整大小并移动<br/>
2、点击确定回调锚点坐标
</div>
</div>
 

    </form>
</body>
</html>
