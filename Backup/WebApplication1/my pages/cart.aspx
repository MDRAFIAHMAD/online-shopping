<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/my pages/main.Master" CodeBehind="cart.aspx.vb" Inherits="WebApplication1.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style7
        {
            width: 413px;
        }
        .style8
        {
            width: 524px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <CENTER>
        <U style="font-family: &quot;Franklin Gothic Heavy&quot;; font-size: x-large; text-decoration: underline blink; font-weight: bold; font-style: normal; font-variant: normal; text-transform: capitalize; color: #33CC33">
        PRODUCT DETAILS</U></CENTER><br /><br />
         <br />
    <table>
    <tr>
    <td class="style7" valign="top" 
            
            
            style="font-family: Algerian; font-size: large; font-weight: normal; font-style: normal; color: #008080;">Product Name : <asp:Label ID="Label1" 
            runat="server" Text="Label" Font-Bold="True" Font-Size="Medium" Height="30px" 
            Width="156px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br /><br /> 
        Price :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="Label2" runat="server" 
            Text="Label" Height="30px" Width="156px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td><asp:ImageButton ID="ImageButton1" runat="server" Height="307px" Width="274px" 
            ImageAlign="Top" /></td>
    <td class="style8" valign="top" 
            style="font-family: Broadway; font-size: large; font-weight: normal; font-style: normal; color: #008080;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Specification: <br />
        &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox  
            ID="TextBox1" runat="server" TextMode="MultiLine" Rows="3" Height="250px" 
            ReadOnly="True" Width="300px" Font-Bold="True"></asp:TextBox></td>
    </tr>
    </table>
    <br />

       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; <br />
            <asp:Panel ID="Panel3" runat="server" BackColor="#FFFFCC" Height="398px" 
        BorderStyle="Solid" BorderWidth="1px">
        &nbsp;<br /> &nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="IN STOCK"></asp:Label>
        <br />
        <br />
        <br />
        &nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" 
            ForeColor="Red" Text="Rs."></asp:Label>
        &nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Quantity"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="84px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <br />
        <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="seller rating"></asp:Label>
        &nbsp;<asp:Image ID="Image2" runat="server" Height="20px" ImageUrl="~/my pages/img/BB.jpg" 
            Width="85px" />
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server" Height="16px" Width="208px">
            <asp:ListItem>Cash on Delivery</asp:ListItem>
            <asp:ListItem>Free Shipping</asp:ListItem>
            <asp:ListItem>Delivery in 9-15 Business Days</asp:ListItem>
        </asp:BulletedList>
        <br /><br /><br /><br />
               <center> 
                   <asp:Button ID="Button1" runat="server" CssClass="btn1" Text="ADD TO CART" 
                    Width="184px" /></center>
    </asp:Panel><br /><br /><br />
    
</asp:Content>
