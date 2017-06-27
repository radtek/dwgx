<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linkEdit.aspx.cs" Inherits="manage_link_lindEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../../css/css.css" rel="stylesheet" type="text/css" />
</head>
<body class="txt">
    <form id="form1" runat="server">
    <div>
        <table style="width: 331px; height: 133px">
            <tr>
                <td style="width: 70px">
                </td>
                <td style="width: 93px">
                </td>
                <td style="width: 144px">
                </td>
            </tr>
            <tr>
                <td style="width: 70px">
                </td>
                <td style="width: 93px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="8px"
                        OnRowDeleting="GridView1_RowDeleting" Width="358px">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="linkName" HeaderText="站点名称" />
                            <asp:BoundField DataField="linkAddress" HeaderText="链接地址" />
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td style="width: 144px">
                </td>
            </tr>
            <tr>
                <td style="width: 70px">
                </td>
                <td style="width: 93px">
                </td>
                <td style="width: 144px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
