<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jsontest.aspx.cs" Inherits="mobile_jsontest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery-2.1.1.js"></script>
    <script>
        var page = 0;

        $(document).ready(function () {
            $("#p1").click(function () {
                page++
                $("#h11").text(page);

                // 拼接HTML
                var result = '';
                $.ajax({
                    type: 'GET',
                    url: 'CLassPageHandle.ashx?pageIndex=' + page,
                    dataType: 'json',
                    success: function (data) {
                        var arrLen = data.ds.length;
                        if (arrLen > 0) {
                            for (var i = 0; i < arrLen; i++) {
                                result += '<p><a href="#"><span class="title">' + data.ds[i].cTitle + '</span></a></p>';
                            }
                            // 如果没有数据
                        } else {
                            alert(data.ds.length);
                        }

                        // 插入数据到页面，放到最后面
                        $('#info').append(data.ds.length);
                        // 每次数据插入，必须重置

                        //                    // 为了测试，延迟1秒加载
                        //                    setTimeout(function(){
                        //                        // 插入数据到页面，放到最后面
                        //                        $('#articles ul').append(result);
                        //                        // 每次数据插入，必须重置
                        //                        me.resetload();
                        //                    },1000);
                    },
                    error: function (xhr, type) {
                        alert("ajax error;"+type);
                    }
                });
            });
        })
        
    </script>
</head>
<body>
    <p id="p1">加载更多</p>
    <form id="form1" runat="server">
    <div id="info">
        <p id="h11">aaa</p>
    </div>
    </form>
</body>
</html>
