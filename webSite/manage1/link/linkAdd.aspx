<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linkAdd.aspx.cs" Inherits="manage_link_linkAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../../css/css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="txt" style="width: 393px; height: 1px">
            <tr>
                <td style="width: 90px">
                    上传Logo：</td>
                <td style="width: 255px">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="312px" /></td>
                <td style="width: 3px">
                    </td>
            </tr>
            <tr>
                <td style="width: 90px">
                    站点名称：</td>
                <td style="width: 255px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="305px"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td style="width: 90px">
                    链接地址：</td>
                <td style="width: 255px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="304px"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td style="width: 90px">
                </td>
                <td align="center" style="width: 255px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添　加" />
                    <asp:Button ID="Button2" runat="server" Text="重　置" /></td>
                <td style="width: 3px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
