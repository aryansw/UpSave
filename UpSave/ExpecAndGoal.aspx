<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpecAndGoal.aspx.cs" Inherits="UpSave.WebForm1" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>ExpectationsAndGoals</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
</head>

<body class="text-center flex-grow-1">
    <h1 class="text-truncate text-capitalize text-center flex-row flex-grow-1 justify-content-center align-self-center" style="min-height: 55px;margin-top: 50px;">Expected Savings</h1>
    <div class="container" style="margin: 100px 70 px;margin-top: 40px;">
        <div class="row">
            <div class="col"><input class="custom-range" type="range" name="timeRange" value="10" min="1" max="60" step="1" style="margin-top: 20px;"></div>
            <div class="col">
                <h4 style="margin-top: 10px;">Slider Value</h4>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <h3>Range: $1-2<br>Likely: $-100</h3>
            </div>
        </div>
    </div>
    <h1 class="text-truncate text-capitalize text-center flex-row flex-grow-1 justify-content-center align-self-center" style="min-height: 55px;margin-top: 50px;">Goal</h1>
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="row">
                    <div class="col"><input type="text" style="height: 50px;margin-top: 10px;" name="goalInput" placeholder="1" inputmode="numeric" minlength="1" maxlength="8"></div>
                    <div class="col"><button class="btn btn-primary text-capitalize text-center" type="button" style="width: 190px;height: 75px;">Calculate</button></div>
                </div>
            </div>
            <div class="col">
                <h3 class="text-truncate text-capitalize text-center flex-row flex-grow-1 justify-content-center align-self-center" style="min-height: 0px;margin-top: 0px;">Possibilities</h3>
                <p class="text-left">asdf<br>asdf<br>asd<br>asdsdas<br>asasdfasdfasdfasdf<br>asdfasdasgrraretaert<br>asdf asdfsdf<br>asdasd ladskajdagjdfgh&nbsp;<br>asdkjl ahsdlkfahdslk ahsd<br>askdjdgahslk hasdkjf s</p>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
</body>

</html>
