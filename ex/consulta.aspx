<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="ex.consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <p>
        consulta entre dos fechas</p>
    <p>
        desde
        <asp:TextBox ID="finicio" runat="server"></asp:TextBox>
&nbsp;&nbsp; hasta
        <asp:TextBox ID="ffin" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="consultar" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
</form>
</asp:Content>
