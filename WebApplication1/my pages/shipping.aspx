<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="shipping.aspx.vb" Inherits="WebApplication1.shipping" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <!--[if lt IE 7]> <html class="no-js ie6 oldie" lang="en"> <![endif]-->
    <!--[if IE 7]>    <html class="no-js ie7 oldie" lang="en"> <![endif]-->
    <!--[if IE 8]>    <html class="no-js ie8 oldie" lang="en"> <![endif]-->
    <!--[if IE 9]> <html class="no-js ie9 oldie" lang="en"> <![endif]-->
    <meta charset="utf-8">
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="description" content="Coming soon, Bootstrap, Bootstrap 3.0, Free Coming Soon, free coming soon, free template, coming soon template, Html template, html template, html5, Code lab, codelab, codelab coming soon template, bootstrap coming soon template">
    
    <!-- ============ Google fonts ============ -->
    <link href='http://fonts.googleapis.com/css?family=EB+Garamond' rel='stylesheet'
        type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,300,800'
        rel='stylesheet' type='text/css' />
    <!-- ============ Add custom CSS here ============ -->
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="custom-bootstrap-menu" class="navbar navbar-default " role="navigation">
        <div class="container">
            <div class="navbar-header" >
                <a class="navbar-brand" href="#">JSR-CART</a>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-menubuilder">
                    <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span
                        class="icon-bar"></span><span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse navbar-menubuilder">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="homepage.aspx">Home</a> </li>
                    <li><a href="/about-us">About Us</a> </li>
                </ul>
            </div>
        </div>
    </div>
   <div class="col-md-6 text-center"  >
            <div class="registrationform" >
                <div class="form-horizontal" >
                    <fieldset>
                        <legend class="text-center header">Shipping Details Form</legend>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-user bigicon"></i></span>
                            <div class="col-md-8">
                               <asp:TextBox ID="TextBox1" runat="server" placeholder="First Name" class="form-control" ></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="please enter First name"  ControlToValidate="TextBox1" Font-Overline="False" ></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-user bigicon"></i></span>
                            <div class="col-md-8">
                                   <asp:TextBox ID="TextBox2" runat="server" placeholder="Last Name" class="form-control"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="please enter Last name"  ControlToValidate="TextBox2" Font-Overline="False" ></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-envelope-o bigicon"></i></span>
                            <div class="col-md-8">
                                       <asp:TextBox ID="TextBox3" runat="server" placeholder="Email Address" class="form-control"></asp:TextBox>
                                
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-phone-square bigicon"></i></span>
                            <div class="col-md-8">
                                           <asp:TextBox ID="TextBox4" runat="server" type="text" placeholder="Phone" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="please enter Phone Nmuber"  ControlToValidate="TextBox4" Font-Overline="False" ></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-pencil-square-o bigicon"></i></span>
                            <div class="col-md-8">
                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" placeholder="Enter your full Address."></asp:TextBox>
                            
                                
                            </div>
                        </div>
                         <div class="form-group">
                          <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-pencil-square-o bigicon"></i></span>                          
                            <div class="col-lg-8">
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control ddl">
                                    <asp:ListItem>INDIA</asp:ListItem>
                                   
                                </asp:DropDownList>                              
                            </div>
                            </div>
                            <div class="form-group">
                          <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-pencil-square-o bigicon"></i></span>                          
                            <div class="col-lg-8">
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control ddl">
                                    <asp:ListItem>JHARKHAND</asp:ListItem>
                                    <asp:ListItem>BIHAR</asp:ListItem>
                                    <asp:ListItem>DELHI</asp:ListItem>
                                    <asp:ListItem>WEST BANGAL</asp:ListItem>
                                </asp:DropDownList>                              
                            </div>
                            </div>
                             <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-phone-square bigicon"></i></span>
                            <div class="col-md-8">
                                           <asp:TextBox ID="TextBox6" runat="server" type="text" placeholder="PIN CODE" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Pin Code"  ControlToValidate="TextBox6" Font-Overline="False" ></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-primary btn-lg" />
                                
                            </div>
                        </div>
                        
                    </fieldset>
                    </div></div></div>
                    <br /><br /><br />
   <div class="col-md-3 pull-right " >
            <div class="registrationform" >
                <div class="form-horizontal" >
                    <fieldset>
                        <legend class="text-center header">We Belive In Customer Statisfaction<br />
                        So We have Only Cash On Delivery Option
                        <br />
                        <center>!! Be Happy !!</center>  </legend>
                        
                    </fieldset>
                    </div></div></div>
                </form>
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery.backstretch.js" type="text/javascript"></script>
    <script type="text/javascript">
        'use strict';

        /* ========================== */
        /* ::::::: Backstrech ::::::: */
        /* ========================== */
        // You may also attach Backstretch to a block-level element
        $.backstretch(
        [
            "img/md.jpg",
        ],

        {
            duration: 4500,
            fade: 1500
        }
    );
    </script>
    <style>
    .header {
        color: #ffffff;
        font-size: 27px;
        padding: 10px;
    }

    .bigicon {
        font-size: 35px;
        color: #ffffff ;
    }
</style>
    </form>
</body>
</html>