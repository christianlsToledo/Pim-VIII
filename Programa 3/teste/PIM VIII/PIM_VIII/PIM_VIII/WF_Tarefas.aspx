
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_Tarefas.aspx.cs" Inherits="PIM_VIII.WF_Tarefas" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 72px;
            margin-top: 39px;
        }
        .auto-style2 {
            width: 172px;
        }
        .auto-style3 {
            width: 608px;
        }
        .auto-style5 {
            margin-top: 242px;
        }
        .auto-style6 {
            margin-left: 800px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            f<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Logo Unip.jpg" />
            <br />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WF_Tabela_Grid.aspx">Consultar Tarefas</asp:HyperLink>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="L_Titulo" runat="server" Text="Título da Tarefa"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="L_Descricao" runat="server" Text="Descrição da Tarefa"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="L_Data" runat="server" Text="Informe a Data Limite"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="Titulo" runat="server" DataSourceID="SqlDataSource1" DataTextField="Tipos_das_Tarefas" DataValueField="Tipos_das_Tarefas" OnSelectedIndexChanged="Titulo_SelectedIndexChanged">
                    </asp:DropDownList>
                    <ajaxToolkit:DropDownExtender ID="Titulo_DropDownExtender" runat="server" BehaviorID="DropDownList1_DropDownExtender" DynamicServicePath="" TargetControlID="Titulo">
                    </ajaxToolkit:DropDownExtender>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="Descr" runat="server" Height="16px" Width="607px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Data" runat="server" OnTextChanged="TextBox2_TextChanged1"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="Data_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="Data">
                    </ajaxToolkit:CalendarExtender>
                </td>
            </tr>
        </table>
        <div class="auto-style6">
            <asp:Button ID="BT_ADD_Tarefa" runat="server" OnClick="Cadastrar" Text="Adicionar Tarefa" />
        </div>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style5" Height="219px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Panel ID="Panel2" runat="server" Height="20px" Width="200px">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_PIM_VIIICon %>" ProviderName="<%$ ConnectionStrings:BD_PIM_VIIICon.ProviderName %>" SelectCommand="SELECT [Tipos das Tarefas] AS Tipos_das_Tarefas FROM [Tabela2]"></asp:SqlDataSource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
