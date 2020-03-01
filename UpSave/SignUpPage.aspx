<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="UpSave.SignUpPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <body style="background-image:url(https://www.krcomplexlit.com/wp-content/uploads/2017/08/GettyImages-114854649.jpg);
                background-position: center;
                background-repeat:no-repeat;
                background-size:cover;
                height:100%;" >
    <div class="row m-5">
        <div class="card-header container-fluid bg-light text-black">
            <h1 class="display-4 text-center"><b>UpSave</b> : The Future of Personal Finance</h1>
        </div>
        <div class="col-md-3 ">
        </div>
        <div class="col-md-6 pt-5">
            <div class="card">
                <div class="card-header container-fluid bg-dark text-white">
                        <h2 class="text-center">Sign Up</h2>
                    </div>
                <div class="card-body bg-light">
                    <form class="form-horizontal" id="login_form" role="form">
                         <div style ="width:100%" class="text-center pb-n1">
                            <div class ="alert alert-danger text-center px-5 mx-5 pb-n2" runat="server" role="alert" id="Error_Flag" >
                                <p class="pb-n2">Incorrect Username or Password</p>
                            </div>
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="text" class="form-control bg-light" runat="server" id="first_name" name="fname" placeholder="First Name" value="" required />
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="text" class="form-control bg-light" runat="server" id="last_name" name="lname" placeholder="Last Name" value="" required />
                        </div>
                        <div class="form-group m-5 text-center">
                            <div class="form-group mb-2">
                            <input type="text" class="form-control bg-light" runat="server" id="street_number" name="street_number" placeholder="Street Number" value="" required>
                            </div>
                            <div class="form-group mb-2">
                            <input type="text" class="form-control bg-light" runat="server" id="street_name" name="street_name" placeholder="Street Name" value="" required>
                                </div>
                            <div class="form-group mb-2">
                            <input type="text" class="form-control bg-light" runat="server" id="city" name="city" placeholder="City" value="" required>
                                </div>
                            <div class="form-group mb-2">
                            <input type="text" class="form-control bg-light" runat="server" id="state" name="state" placeholder="State" value="" required>
                                </div>
                            <div class="form-group mb-2">
                            <input type="text" class="form-control bg-light" runat="server" id="zip" name="zip" placeholder="Zip" value="" required>
                                </div>
                        </div>
                        
                        <div class="form-group m-5 text-center">
                            <input type="email" class="form-control bg-light" runat="server" id="email" name="email" placeholder="Email ID" value="" required>
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="password" class="form-control bg-light" runat="server" id="Password" placeholder="Password" required>
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="password" class="form-control bg-light" runat="server" id="Password1" placeholder="Confirm Password" required>
                        </div>
                        <div class="form-group text-center">
                            <button class="btn btn-primary" id="login_button" runat="server" onserverclick="SignUp_ServerClick"> Sign Up </button>
                        </div>
                        <p class="text-center">Already have an account?</p>
                        <div class="form-group text-center">
                             <button class="btn btn-dark" id="SignUp" runat="server" onServerClick="login_button_ServerClick">Login</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
       </body>
</asp:Content>
