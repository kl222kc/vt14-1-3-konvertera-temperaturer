<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KonverteraTemperaturer.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Konvertera Temperaturer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ValidationSummary ID="ValidationSummary" runat="server" />

        <div>
            <asp:TextBox ID="StartTempTextBox" runat="server" autofocus="autofocus"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="StartTempTextBox" ErrorMessage="Fyll i starttemperaturen." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Start temperaturen måste vara ett heltal" ControlToValidate="StartTempTextBox" Type="Integer" Operator="DataTypeCheck" Display="Dynamic" Text="*"></asp:CompareValidator>
        </div>

        <div>
            <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EndTempTextBox" ErrorMessage="Fyll i sluttemperaturen." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="EndTempTextBox" ErrorMessage="Slut tempen måste vara ett heltal som är större än start tempen." Operator="GreaterThan" Type="Integer" ControlToCompare="StartTempTextBox" Display="Dynamic" Text="*"></asp:CompareValidator>
        </div>

        <div>
            <asp:TextBox ID="IncreaseTempTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="IncreaseTempTextBox" ErrorMessage="Fyll i ett temperatursteg." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="IncreaseTempTextBox" ErrorMessage="Temperatursteget måste vara ett heltal inom 1-100." MaximumValue="100" MinimumValue="1" Type="Integer" Display="Dynamic" Text="*"></asp:RangeValidator>
        </div>

        <asp:Button ID="TempButton" runat="server" Text="Button" OnClick="TempButton_Click" style="height: 26px" />
    </div>
    </form>

    <asp:Table ID="ResultTable" runat="server"></asp:Table>

</body>
</html>
