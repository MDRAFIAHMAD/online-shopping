<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/my pages/main.Master" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="1516px">
        <asp:Panel ID="Panel7" runat="server" BackColor="#999999" Height="30px" 
            HorizontalAlign="Center">
            <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="White" 
                Text="CART"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel10" runat="server" Direction="RightToLeft" Height="27px" 
            Width="871px">
            <asp:Button ID="Button1" runat="server" Text="CLEAR CART" />
            <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BorderStyle="Solid" BorderWidth="1px" 
            Height="165px" style="margin-left: 50px" Width="820px">
            <br />
            &nbsp;<asp:Label ID="Label13" runat="server" Text="PRODUCT NAME" Width="200px"></asp:Label>
            <asp:Label ID="Label14" runat="server" Text="QUANTITY" Width="100px"></asp:Label>
            <asp:Label ID="Label15" runat="server" Text="PRICE (IN INR)" Width="100px"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Label ID="Label16" runat="server" Width="200px"></asp:Label>
            <asp:Label ID="Label17" runat="server" Width="100px"></asp:Label>
            <asp:Label ID="Label33" runat="server" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:Label ID="Label19" runat="server" Width="200px"></asp:Label>
            <asp:Label ID="Label20" runat="server" Width="100px"></asp:Label>
            <asp:Label ID="Label34" runat="server" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:Label ID="Label22" runat="server" Width="200px"></asp:Label>
            <asp:Label ID="Label23" runat="server" Width="100px"></asp:Label>
            <asp:Label ID="Label35" runat="server" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:Label ID="Label25" runat="server" Width="200px"></asp:Label>
            <asp:Label ID="Label26" runat="server" Width="100px"></asp:Label>
            <asp:Label ID="Label36" runat="server" Width="100px"></asp:Label>
            <br />
            &nbsp;<asp:Label ID="Label28" runat="server" Width="200px"></asp:Label>
            <asp:Label ID="Label29" runat="server" Width="100px"></asp:Label>
            <asp:Label ID="Label37" runat="server" Width="100px"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel9" runat="server" BorderStyle="Solid" BorderWidth="1px" 
            Height="30px" style="margin-left: 50px" Width="820px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            GRAND TOTAL :
            <asp:Label ID="Label38" runat="server" Width="70px"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel11" runat="server" Height="30px" HorizontalAlign="Center">
            <asp:Button ID="Button2" runat="server" BackColor="#FFFF66" 
                Text="PROCEED TO CHECKOUT" />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" BackColor="#FFFF99" Height="715px" 
            style="margin-left: 110px" Width="700px" Visible="False">
            <asp:Panel ID="Panel6" runat="server" BackColor="#999999" Height="30px" 
                HorizontalAlign="Center">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="White" 
                    Text="PAYMENT"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                Height="24px" HorizontalAlign="Center">
                <asp:Label ID="Label2" runat="server" Text="General Details"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Name* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="E-Mail* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Address* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="50px" TextMode="MultiLine" 
                Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="City* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="State* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="PIN Code* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox5" runat="server" MaxLength="6" Width="250px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Mobile No.* :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" MaxLength="10" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Panel ID="Panel5" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                Height="24px" HorizontalAlign="Center">
                <asp:Label ID="Label9" runat="server" Text="Payment Method"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" Text="COD" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" 
                Text="accept all terms and conditions*" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" BorderStyle="Solid" 
                BorderWidth="1px" Height="35px" ImageUrl="~/images/place.jpg" Width="135px" />
        </asp:Panel>
    </asp:Panel>
    <br />
</asp:Content>
