<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KonverteraTemperaturer.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Konvertera Temperaturer</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <h1>Konvertera Temperaturer</h1>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary" HeaderText="Fel inträffade. Åtgärda felen och försök igen." CssClass="error" runat="server" />

        <div>
            <p>Starttemperatur:</p>
            <asp:TextBox ID="StartTempTextBox" runat="server" autofocus="autofocus"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="error" runat="server" ControlToValidate="StartTempTextBox" ErrorMessage="Fyll i starttemperaturen." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" CssClass="error" runat="server" ErrorMessage="Start temperaturen måste vara ett heltal" ControlToValidate="StartTempTextBox" Type="Integer" Operator="DataTypeCheck" Display="Dynamic" Text="*"></asp:CompareValidator>
        </div>

        <div>
            <p>Sluttemperatur:</p>
            <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="error" runat="server" ControlToValidate="EndTempTextBox" ErrorMessage="Fyll i sluttemperaturen." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" CssClass="error" runat="server" ControlToValidate="EndTempTextBox" ErrorMessage="Slut tempen måste vara ett heltal som är större än start tempen." Operator="GreaterThan" Type="Integer" ControlToCompare="StartTempTextBox" Display="Dynamic" Text="*"></asp:CompareValidator>
        </div>

        <div>
            <p>Temperatursteg:</p>
            <asp:TextBox ID="IncreaseTempTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="error" runat="server" ControlToValidate="IncreaseTempTextBox" ErrorMessage="Fyll i ett temperatursteg." Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator3" CssClass="error" runat="server" ControlToValidate="IncreaseTempTextBox" ErrorMessage="Temperatursteget måste vara ett heltal inom 1-100." MaximumValue="100" MinimumValue="1" Type="Integer" Display="Dynamic" Text="*"></asp:RangeValidator>
        </div>

        <asp:Label ID="RadioLabel" runat="server" Text="Typ av konventering"></asp:Label>
       
         <div>
             <asp:RadioButton ID="ConvertCelRadio" runat="server" CssClass="chkbox" GroupName="ConvertType" Text="Celsius till Fahrenheit" Checked="true" />
             <asp:RadioButton ID="ConvertFarRadio" runat="server" CssClass="chkbox" GroupName="ConvertType" Text="Fahrenheit till Celsius" />
        </div>
       
        <div>
            <asp:Button ID="TempButton" runat="server" Text="Konvertera" OnClick="TempButton_Click" style="height: 26px" />
        </div>
        

    </div>
    </form>

    <asp:Table ID="ResultTable" runat="server" Visible="false">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell ID="First">°C</asp:TableHeaderCell>
            <asp:TableHeaderCell ID="Second">°F</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>

</body>
</html>
