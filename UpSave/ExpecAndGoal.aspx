<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="ExpecAndGoal.aspx.cs" Inherits="UpSave.ExpecAndGoal" %>

<!DOCTYPE html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Blank Page - Brand</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
</head>

<body id="page-top">
    <div id="wrapper">
        <div class="d-flex flex-column" id="content-wrapper">
            <div id="content">
                <nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle mr-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button><i class="fas fa-money-bill-wave"></i>
                        <form class="form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"><span>UPSave</span></form>
                    </div>
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle mr-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button><i class="fas fa-money-bill-wave"></i>
                        <form class="form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"><span><a href="MyProfile.aspx">My Profile</a></span></form>
                    </div>
                </nav>
                <div class="container-fluid">
                    <h3 class="text-dark mb-1">Financial Planner</h3>
                    <div class="card shadow mb-3">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 font-weight-bold">Savings Calculator</p>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="form-row">
                                    <div class="col">
                                        <div class="form-group" id="approx" runat="server"><label for="username"><strong>Select a duration on the slider</strong></label>
                                </div><div class="col">
                <input class="custom-range" type="range" name="timeRange" runat="server" id="time_range" value="10" min="1" max="60" step="1" style="margin-top: 20px;"></div></div>
                                    </div>
                                <div class="form-row">
                                    <div class="col">
                                        <div class="form-group"><label for="first_name" id="Months" runat="server"><strong>Time Span:</strong>&nbsp;</label></div></div>
                                    <div class="col">
                                        <div class="form-group"><label for="last_name" id="Range" runat="server"><strong>Approximate Range:</strong><br></label></div><label for="last_name" id="Likely" runat="server"><strong>Likely:</strong><br></label></div>
                                </div>
                                <div class="form-group"><button class="btn btn-primary btn-sm" id="Calculate_Savings" runat="server" OnClick="get_range_ServerClick" onserverclick="get_range_ServerClick" >Forecast Savings</button></div>
                            </form>
                        </div>
                    </div>
                    <div class="flex-grow-0"></div>
                    <div class="card shadow mb-3">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 font-weight-bold">How can I save more?</p>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="form-row">
                                    <div class="col">
                                        <div class="form-group"><label for="username"><strong>How much do you want to save in a year?</strong><br></label>
                                            <input class="form-control" type="number" id="number" runat="server" ></div>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="col">
                                        <div class="form-group"><label for="first_name"><strong>How do I save up?</strong></label>
                                            <input class="form-control-plaintext" type="text" id="text_f" runat="server" value="Cut entertainment by 80%" readonly=""></div>
                                    </div>
                                </div>
                                <div class="form-group"><button class="btn btn-primary btn-sm" type="submit" id="button" runat="server" >Calculate</button></div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <footer class="bg-white sticky-footer">
                <div class="container my-auto">
                    <div class="text-center my-auto copyright"><span>Made by UpSave</span></div>
                </div>
            </footer>
        </div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a></div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
    <script src="assets/js/theme.js"></script>
</body>
        