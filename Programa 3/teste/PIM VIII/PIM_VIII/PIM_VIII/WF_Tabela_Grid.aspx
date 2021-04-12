<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_Tabela_Grid.aspx.cs" Inherits="PIM_VIII.WF_Tabela_Grid" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 84px;
        }
    </style>
</head>
<body style="height: 50px">
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Logo Unip.jpg" />
            <br />
            <br />
            <asp:HyperLink ID="cadastrarTarefa" runat="server" NavigateUrl="~/WF_Tarefas.aspx" ForeColor="#003399">Cadastrar Nova Tarefa</asp:HyperLink>
            <br />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Height="462px">
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Código" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged2" Width="703px">
                <Columns>
                    <asp:BoundField DataField="Código" HeaderText="Código" InsertVisible="False" ReadOnly="True" SortExpression="Código" />
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                    <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                    <asp:BoundField DataField="Data" HeaderText="Data" SortExpression="Data" />
                    <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_PIM_VIIICon %>" DeleteCommand="DELETE FROM [Tabela1] WHERE [Código] = ?" InsertCommand="INSERT INTO [Tabela1] ([Código], [Descricao], [Data], [Status], [Titulo]) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:BD_PIM_VIIICon.ProviderName %>" SelectCommand="SELECT [Código], [Descricao], [Data], [Status], [Titulo] FROM [Tabela1]" UpdateCommand="UPDATE [Tabela1] SET [Descricao] = ?, [Data] = ?, [Status] = ?, [Titulo] = ? WHERE [Código] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="original_Código" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Código" Type="Int32" />
                    <asp:Parameter Name="Descricao" Type="String" />
                    <asp:Parameter Name="Data" Type="DateTime" />
                    <asp:Parameter Name="Status" Type="Boolean" />
                    <asp:Parameter Name="Titulo" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Descricao" Type="String" />
                    <asp:Parameter Name="Data" Type="DateTime" />
                    <asp:Parameter Name="Status" Type="Boolean" />
                    <asp:Parameter Name="Titulo" Type="String" />
                    <asp:Parameter Name="original_Código" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <%--<asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" DataKeyNames="Código" DataSourceID="SqlDataSource3" ForeColor="Black" Height="119px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="843px" AllowPaging="True" CellSpacing="2">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Código" HeaderText="Código" InsertVisible="False" ReadOnly="True" SortExpression="Código" />
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                    <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                    <asp:BoundField DataField="Data" HeaderText="Data" SortExpression="Data" />
                    <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:BoundField DataField="Campo1" HeaderText="Campo1" SortExpression="Campo1" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>--%>
        </asp:Panel>
    </form>
</body>
</html>
