<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PimVIII.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Lista de cadastrados</h2>
    <h3>
        <asp:GridView ID="ListaCadastrados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="ListaCadastrados_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="idTarefa" DataSourceID="ListaCadastrados1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="idTarefa" HeaderText="idTarefa" InsertVisible="False" ReadOnly="True" SortExpression="idTarefa" />
                <asp:BoundField DataField="nomeTarefa" HeaderText="nomeTarefa" SortExpression="nomeTarefa" />
                <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                <asp:BoundField DataField="dataEntrega" HeaderText="dataEntrega" SortExpression="dataEntrega" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="ListaCadastrados1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\tblTarefas.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [idTarefa], [nomeTarefa], [Descricao], [dataEntrega], [status] FROM [tarefa]"></asp:SqlDataSource>
    </h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>
