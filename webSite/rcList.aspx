<%@ Page Language="C#" MasterPageFile="~/MasterPageDwgx.master" AutoEventWireup="true" CodeFile="rcList.aspx.cs" Inherits="rcList" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    <section class="container features">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td colspan="3" class="top3lk_ohter1">当前位置：<a href="index.aspx">网站首页</a> > 求职招聘</td>
            </tr>
            <tr>

                <td width="97%" class="top2lki_title">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">


                        <tr>
                            <td colspan="3" class="top21tt" style="line-height: 3">
                                <table class="jobList" width="99%">
                                    <thead>
                                        <tr>
                                            <th width="30%" class="wid1">职位信息</th>
                                            <th width="19%" class="wid2">薪资水平</th>
                                            <th width="11%" class="wid3">工作地点</th>
                                            <th width="10%" class="wid4">学历</th>
                                            <th width="9%" class="wid5">专业要求</th>
                                            <th width="11%" class="wid6">招聘人数</th>
                                            <th width="10%" class="wid7">更新时间</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Repeater ID="rptRc" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <div class="ml20"><a target="_blank" href="rc_detaile.aspx?jobId=<%#Eval("id").ToString()%>" title="<%#Eval("jobName").ToString()%>"><%#Eval("jobName").ToString()%></a></div>
                                                    </td>
                                                    <td>
                                                        <div><span><%#Eval("salary").ToString()%></span></div>
                                                    </td>
                                                    <td>
                                                        <div><%#Eval("jobAddr").ToString()%></div>
                                                    </td>
                                                    <td>
                                                        <div><%#Eval("rofs").ToString()%></div>
                                                    </td>
                                                    <td>
                                                        <div><%#Eval("major").ToString()%></div>
                                                    </td>
                                                    <td>
                                                        <div><%#Eval("amount").ToString()%>人</div>
                                                    </td>
                                                    <td>
                                                        <div class="mr20"><%#DateTime.Parse(Eval("updateTime").ToString()).ToString("yyyy-MM-dd")%></div>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>                                            
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>

            </tr>



        </table>

       <%-- 以下是分页--%>
        <%if (recordCount > 20)
            {%>
        <tr>
            <td></td>
            <td>
                <table width="100%" border="0" cellpadding="0" cellspacing="5" bgcolor="#FDFDFF">
                    <br />
                    <tr>
                        <td class="top25B_text">&nbsp;<asp:HyperLink ID="First" runat="server" NavigateUrl="~/Manage/News_List.aspx?page">首页</asp:HyperLink>
                            &nbsp; &nbsp;
                                     
                            <asp:HyperLink ID="lnkPrev" runat="server">上一页</asp:HyperLink>
                            &nbsp; &nbsp;
                                     
                            <asp:HyperLink ID="lnkNext" runat="server">下一页</asp:HyperLink>
                            &nbsp; &nbsp;
                                     
                            <asp:HyperLink ID="Last" runat="server" NavigateUrl="~/Manage/News_List.aspx?page=">尾页</asp:HyperLink>
                            &nbsp; &nbsp;当前页码：
                                     
                            <asp:Literal ID="lblCurrentPage" runat="server"></asp:Literal>／<asp:Literal ID="PageCount"
                                runat="server"></asp:Literal>页 &nbsp;&nbsp; 记录总数：<asp:Literal ID="myCount" runat="server"></asp:Literal>
                            条</td>
                    </tr>
                </table>
            </td>
        </tr>
        <%}%>
    </section>
    <br />

</asp:Content>
