<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="UpSave.LoginPage" %>

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
                        <h2 class="text-center">Login</h2>
                    </div>
                <div class="card-body bg-light">
                    <form class="form-horizontal" id="login_form" role="form">
                        
                         <div style ="width:100%" class="text-center pb-n1">
                            <div class ="alert alert-danger text-center px-5 mx-5 pb-n2" runat="server" role="alert" id="Error_Flag" >
                                <p class="pb-n2">Incorrect Username or Password</p>
                            </div>
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="email" class="form-control bg-light" runat="server" id="email" name="Email" placeholder="Email ID" value="" required>
                        </div>
                        <div class="form-group m-5 text-center">
                            <input type="password" class="form-control bg-light" runat="server" id="Password" placeholder="Password" required>
                        </div>
                        <div class="form-group text-center">
                            <button class="btn btn-primary" id="login_button" runat="server" onserverclick="login_button_ServerClick"> Login </button>
                        </div>
                        <p class="text-center">Don't have an account?</p>
                        <div class="form-group text-center">
                             <button class="btn btn-dark" id="SignUp" runat="server" onServerClick="SignUp_ServerClick">Sign Up</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
       </bod>
</asp:Content>
