<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PimVIII._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <table style="width: 100%; height: 300px;">
        <tr>
            <td style="height: 93px">Nova tarefa:&nbsp;&nbsp;
                <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>&nbsp;Descricao:&nbsp;&nbsp;

                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>&nbsp; Entrega:&nbsp;

                <asp:TextBox ID="txtdataEntrega" runat="server"></asp:TextBox>&nbsp;&nbsp;

                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="Cadastrar_Click" />
                <br />
            </td>
            
        </tr>
        <tr>
            <td>
                &nbsp;</td>
           
        </tr>
        <tr>
            <td>&nbsp;</td>
         
        </tr>
    </table>

   

</asp:Content>
