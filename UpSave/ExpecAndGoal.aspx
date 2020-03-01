<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExpecAndGoal.aspx.cs" Inherits="UpSave.ExpecAndGoal" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<body>
    <h1 class="text-truncate text-capitalize text-center flex-row flex-grow-1 justify-content-center align-self-center" style="min-height: 55px;margin-top: 50px;">Savings Calculator</h1>
    <div class="container" style="margin: 100px 70px;margin-top: 40px;">
        <div class="row">
            <div class="col">
                <input class="custom-range" type="range" name="timeRange" runat="server" id="time_range" value="10" min="1" max="60" step="1" style="margin-top: 20px;"></div>
            <div class="col">
                <h4 style="margin-top: 10px;" id="number" runat="server">Savings over _ months: 100$</h4>
                <button class="btn btn-primary text-capitalize text-centerk" id="SignUp" runat="server" onServerClick="get_range_ServerClick">Sign Up</button>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <h5>Range: $1-2<br>Likely: $-100</h5>
            </div>
        </div>
    </div>




    <h1 class="text-truncate text-capitalize text-center flex-row flex-grow-1 justify-content-center align-self-center" style="min-height: 55px;margin-top: 50px;">Get to your Goal</h1>
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="row">
                    <div class="col">$ <input type="text" style="height: 50px;margin-top: 10px;" name="goalInput" id="goal_input" placeholder="1" inputmode="numeric" minlength="1" maxlength="8"></div>
                    <div class="col"><button class="btn btn-primary text-capitalize text-center" type="button" onServerClick="get_suggestions" style="width: 190px;height: 75px;">Calculate</button></div>
                </div>
            </div>
            <div class="col">
                <h3 class="text-truncate text-capitalize text-right flex-row flex-grow-1 justify-content-right align-self-right" style="min-height: 0px;margin-top: 0px;">Possibilities</h3>
                <p class="text-right">asdf<br>asdf<br>asd<br>asdsdas<br>asasdfasdfasdfasdf<br>asdfasdasgrraretaert<br>asdf asdfsdf<br>asdasd ladskajdagjdfgh&nbsp;<br>asdkjl ahsdlkfahdslk ahsd<br>askdjdgahslk hasdkjf s</p>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
</body>
        
</asp:Content>
