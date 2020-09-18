<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @*@Styles.Render("~/Content/css")*@
    @Styles.Render("~/Content/CSS/StyleSheet.css")
    <link href="https://fonts.googleapis.com/css2?family=Titillium+Web:ital,wght@0,200;0,300;0,400;0,600;0,700;0,900;1,200;1,300;1,400;1,600;1,700&display=swap" rel="stylesheet">
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <a id="top"></a>
    <div class="navbar_header">
        <div class="wrapper flex">
            <div>Ph: (246) 810 1214</div>
            <div class="flex">
                <a href="#"><i class='social_icon fab fa-facebook-square'></i></a>
                <a href="#"><i class='social_icon fab fa-youtube'></i></a>
                <a href="#"><i class='social_icon fab fa-instagram'></i></a>
                <a href="#"><i class='social_icon fab fa-twitter'></i></a>
            </div>
        </div>
    </div>
    <nav>
        <div class="wrapper navbar">
            <div>
                <a href="#">
                    <img src="~/Content/Images/logo.png" alt="sc" class="nav_logo"><!-- Logo for Navigation Bar> -->
                </a>
            </div>
            <div>
                <ul class="nav_links">
                    <li>
                        <a href="#">
                            <img src="~/Content/Images/logo.png" alt="sc" class="mobile_logo"><!-- Logo for Navigation Bar> -->
                        </a>
                    </li>
                    <li>
                        <a href="#">SUPERHEROS</a>
                    </li>
                    <li>
                        <div class="dropdown">
                            <button class="drop_button" type="button">DC <span class="drop_icon fas fa-caret-up"></span></button>
                            <div class="dropdown_content">
                                <a href="#">FLASH</a>
                                <a href="#">WONDER WOMAN</a>
                                <a href="#">SUPERMAN</a>
                                <a href="#">BATMAN</a>
                            </div>
                        </div>
                    </li>
                    <li>
                        <a href="#" id="contactLink">About Us</a>
                    </li>
                    <li>
                        <div class="dropdown">
                            <button class="drop_button" type="button">DC Shows <span class="drop_icon fas fa-caret-up"></span></button>
                            <div class="dropdown_content">
                                <a href="#">ARROW</a>
                                <a href="#">SUPERGIRL</a>
                                <a href="#">BATWOMAN</a>
                                <a href="#">SMALLVILLE</a>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
            <div class="burger">
                <div class="burger1"></div>
                <div class="burger2"></div>
                <div class="burger3"></div>
            </div>

        </div>
    </nav>
    <div class="container body-content" id="navbar-collapser">
        @RenderBody()
        <div><a href="#top"><i class="backToTop fas fa-caret-up"></i></a></div>
        <footer>
            <div class="wrapper grid_container">
                <div>
                    <a href="#">
                        <img src="~/Content/Images/logo.png" alt="sc" class="footer_logo">
                    </a>
                </div>
                <div>
                    <ul>
                        <a href="#"><li>SUPERHEROS</li></a>
                        <a href="#"><li>DC UNIVERSE</li></a>
                        <a href="#"><li>ABOUT US</li></a>
                    </ul>
                </div>
            </div>
            <p class="center">&copy; @DateTime.Now.Year - DC UNIVERSE</p>
        </footer>
    </div>
    @Styles.Render("~/Content/JS/JavaScript.js")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <script src="../Content/JS/JavaScript.js"></script>
</body>
</html>
