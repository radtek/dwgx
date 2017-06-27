<%@ Page Language="C#"  MasterPageFile="~/mobile/MasterPage.master" AutoEventWireup="true" CodeFile="speciaTypelList.aspx.cs" Inherits="mobile_speciaTypelList" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

<script>     

    var page = 1;
    $(document).ready(function () {
              

        $("#loadMore").click(function () {
            page++

            // 拼接HTML
            var result = '';
            $.ajax({
                type: 'GET',
                url: 'SpeciaPageHandle.ashx?TypeId=' +<%=reqTypeId%> +'&pageIndex=' + page,
                dataType: 'json',
                success: function (data) {
                    var arrLen = data.ds.length;
                    if (arrLen > 0) {
                        for (var i = 0; i < arrLen; i++) {
                            result += '<div class="news-card">';
                            result += '<div class="txt-area" >';
                            result += '<div class="news-title"><a href="class.aspx?TypeId=' + data.ds[i].ID + '">' + data.ds[i].cTypeName + '</a></div>';
                            result += '<div class="news-date">' + data.ds[i].dCreateTime + '</div>';
                            result += '</div>';
                            result += '</div>';
                        }
                        // 如果没有数据
                    } else {
                        $("loadMore").text("没有更多数据了");
                    }

                    // 插入数据到页面，放到最后面
                    $('#section_tab_1').append(result);
                },
                error: function (xhr, type) {
                    $('#loadMore').text("没有更多数据了");
                }
            });
        });
    })
             
</script>

<div id="section_tab_1" class="section">


<asp:Repeater ID="rptNews" runat="server" >
    <ItemTemplate>
        <div class="news-card">     
        <div class="txt-area" >
        <div class="news-title"><a href="class.aspx?TypeId=<%#Eval("ID").ToString()%>"><%#Eval("cTypeName").ToString()%></a></div>
        <div class="news-date"><%#DateTime.Parse(Eval("dCreateTime").ToString()).ToString("yyyy-MM-dd hh:mm")%></div>
        </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
</div>
<a class="list-more-btn" id="loadMore">加载更多<i></i></a>

</asp:Content>