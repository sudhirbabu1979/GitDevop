<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="helloworld.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Student Data Entry</h3>
        <asp:Panel ID="pnlStudentForm" runat="server">
            <table>
                <tr>
                    <td><asp:Label ID="lblName" runat="server" Text="Name:" AssociatedControlID="txtName" /></td>
                    <td><asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAge" runat="server" Text="Age:" AssociatedControlID="txtAge" /></td>
                    <td><asp:TextBox ID="txtAge" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail" /></td>
                    <td><asp:TextBox ID="txtEmail" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        </asp:Panel>
    </main>
</asp:Content>