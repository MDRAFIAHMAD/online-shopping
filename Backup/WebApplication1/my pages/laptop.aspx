<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/my pages/main.Master" CodeBehind="laptop.aspx.vb" Inherits="WebApplication1.laptop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="margin-left:-7px; margin-right:-7px"><table border="1" width="100%"  >
<tr >
    <td height="400" width="130" valign="top">
    <center> <u>Filter By Price</u></center><br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
            <asp:ListItem>High To Low </asp:ListItem>
            <asp:ListItem>Low To High</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <br />
        </td>
    <td height="400" valign="top">
    <div>
    <asp:ImageButton ID="ImageButton21" runat="server" Height="107px" Width="111px" />
    <asp:ImageButton ID="ImageButton22" runat="server" Height="107px" Width="111px" />
    <asp:ImageButton ID="ImageButton23" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton24" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton25" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton26" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton27" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton28" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton29" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton30" runat="server" Height="107px" Width="111px" />

    </div>
    <div>
           <asp:Label ID="Label21" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label> 
            <asp:Label ID="Label22" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label23" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label24" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label25" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label26" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label27" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label28" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label29" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label30" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>
    </div>
    <div>
        <asp:Button ID="Button21" runat="server" Text="BUY NOW" Width="100px"  
            Font-Size="Smaller" />
        &nbsp;
        <asp:Button ID="Button22" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button23" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button24" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button25" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button26" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button27" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button28" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button29" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button30" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>

    </div>
    <br />
    <br />
    <div>
    <asp:ImageButton ID="ImageButton31" runat="server" Height="107px" Width="111px" />
    <asp:ImageButton ID="ImageButton32" runat="server" Height="107px" Width="111px" />
    <asp:ImageButton ID="ImageButton33" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton34" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton35" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton36" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton37" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton38" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton39" runat="server" Height="107px" Width="111px" />
      <asp:ImageButton ID="ImageButton40" runat="server" Height="107px" Width="111px" />

    </div>
    <div>
        <asp:Label ID="Label31" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>
            <asp:Label ID="Label32" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label33" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label34" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label35" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label36" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label37" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label38" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label39" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>&nbsp;
            <asp:Label ID="Label40" runat="server" Text="" Height="30px" 
            Width="110px"></asp:Label>

    </div>
    <div>
        <asp:Button ID="Button31" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>
        &nbsp;
        <asp:Button ID="Button32" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button33" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button34" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button35" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button36" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button37" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button38" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button39" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button40" runat="server" Text="BUY NOW" Width="100px" 
            Font-Size="Smaller"/>

    </div>
    </td>
    </tr></table>
    </div>

</asp:Content>
