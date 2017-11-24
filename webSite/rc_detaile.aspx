<%@ Page Language="C#" MasterPageFile="~/MasterPageDwgx.master" AutoEventWireup="true" CodeFile="rc_detaile.aspx.cs" Inherits="rc_detaile" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <section class="container features">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td colspan="3" class="top3lk_ohter1">当前位置：<a href="index.aspx">网站首页</a> > 求职招聘 </td>
            </tr>
            <tr>
                <td width="97%" class="top2lki_title">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">


                        <tr>
                            <td colspan="3" class="top21tt">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0" onselectstart="return false" oncontextmenu="return false">
                                    <tr>
                                        <td colspan="4" class="font02"><font style="font-size: 14px; font-weight: bold"><asp:Label runat="server" id="comnpanyId"></asp:Label></font></td>
                                    </tr>
                                    <tr>
                                        <td width="9%">招聘职位：</td>
                                        <td width="39%" class="font02"><font style="font-size: 14px; font-weight: bold"><asp:Label runat="server" id="jobName"></asp:Label></font></td>
                                        <td width="9%">用工形式：</td>
                                        <td width="43%">
                                            <asp:label runat="server" id="jobType"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>招聘人数：</td>
                                        <td>
                                            <asp:label runat="server" id="amount"></asp:label>
                                        </td>
                                        <td>性别要求：</td>
                                        <td>
                                            <asp:label runat="server" id="sex"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>年龄要求：</td>
                                        <td>
                                            <asp:label runat="server" id="age"></asp:label>
                                        </td>
                                        <td>学历要求：</td>
                                        <td>
                                            <asp:label runat="server" id="rofs"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>专业要求：</td>
                                        <td>
                                            <asp:label runat="server" id="major"></asp:label>
                                        </td>
                                        <td>用人对象：</td>
                                        <td>
                                            <asp:label runat="server" id="jobobject"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>职称要求：</td>
                                        <td>
                                            <asp:label runat="server" id="titleRequire"></asp:label>
                                        </td>
                                        <td>身高要求：</td>
                                        <td>
                                            <asp:label runat="server" id="statureRequire"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>地域要求：</td>
                                        <td>
                                            <asp:label runat="server" id="areaRequire"></asp:label>
                                        </td>
                                        <td>证书要求：</td>
                                        <td>
                                            <asp:label runat="server" id="certificatesRequire"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>发布时间：</td>
                                        <td>
                                            <asp:label runat="server" id="createTime"></asp:label>
                                        </td>
                                        <td>有效时间：</td>
                                        <td>
                                            <asp:label runat="server" id="significantInterval"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>工作地点：</td>
                                        <td>
                                            <asp:label runat="server" id="jobAddr"></asp:label>
                                        </td>
                                        <td>待遇要求：</td>
                                        <td>
                                            <asp:label runat="server" id="salary"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>公司地址：</td>
                                        <td>
                                            <asp:label runat="server" id="compnyAddr"></asp:label>
                                        </td>
                                        <td>联联电话：</td>
                                        <td>
                                            <asp:label runat="server" id="phone"></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td valign="top">其它要求：</td>
                                        <td colspan="3" align="left" valign="top">
                                            <asp:label runat="server" id="others"></asp:label>
                                        </td>
                                    </tr>


                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </section>
    <br />
</asp:Content>
