<%@ Page Title="" Language="C#" MasterPageFile="~/RpnCalculator.Master" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="RpnCalculator.CalculatorUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h1>RPN Calculator</h1>
    <div>
        <asp:Repeater ID="StackViewer" ItemType="System.String" runat="server">
            <HeaderTemplate>
                    <table border="1">
                        <tr>
                            <td><b>Text</b></td>
                        </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td> <%# Item %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

    </div>
    <div>
        <asp:Label ID="Message" runat="server" />
    </div>
    <section>
        <asp:TextBox ID="NumberInput" runat="server" />
        <asp:Button ID="Enter" Text="Enter" OnClick="HandleEnter" runat="server" />
        <asp:requiredfieldvalidator runat="server"
            controltovalidate="NumberInput"
            display="Dynamic"
            enableclientscript="false" />
    </section>
    <fieldset>
        <legend>Math Operations</legend>
        <asp:Button ID="Add" Text="+" OnClick="HandleAdd" runat="server" /> 
        <asp:Button ID="Minus" Text="-" OnClick="HandleMinus" runat="server" /> 
        <asp:Button ID="Multiply" Text="*" OnClick="HandleMultiply" runat="server" /> 
        <asp:Button ID="Divide" Text="/" OnClick="HandleDivide" runat="server" /> 
        <asp:Button ID="Negate" Text="+/-" OnClick="HandleNegate" runat="server" /> 
    </fieldset>
    <fieldset>
        <legend>Stack Operations</legend>
        <asp:Button ID="Drop" Text="Drop" OnClick="HandleDrop" runat="server" />
    </fieldset>
</asp:Content>
