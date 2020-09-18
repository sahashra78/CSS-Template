@Code
    ViewData("Title") = "Home Page"
End Code

<header class="homepage_header">
    <div class="center header_content">
        <h2 class="heading">
            SUPERHEROS<br />
            <span class="sub_heading">DC UNIVERSE</span>
        </h2>
        <br />
        <p>There is no stopping us now.</p>
    </div>
</header>
<section>

    @* Grid with 2 columns *@
    <div class="wrapper grid_container big_grid_container">
        <div>
            <img class="responsive" src="~/Content/Images/DC.jpg" alt="heros" />
        </div>
        <div class="wrapper">
            <h2>DC Universe</h2>
            <p>DC Universe is an American video-on-demand streaming service operated by DC Entertainment and Warner Bros. Digital Networks. It was announced in April 2017, with the title and service formally announced in May 2018.</p>
            <a href="#" target="_blank" class="visitLink">
                <span>Visit Site<i class='arrowmation fas fa-angle-right'></i><i class='arrowmation fas fa-angle-right'></i></span>
            </a>
        </div>
    </div>
    
    @* Grid with 3 columns *@
<div class="wrapper grid_container small_grid_container">
    <div>
        <img class="categoryColumnImage" src="~/Content/Images/superman.jpg" alt="Superman" />
        <div class="padding">
            <h2>Superman</h2>
            <p>“Dreams save us. Dreams lift us up and transform us. And on my soul I swear until my dream of a world where dignity, honor, and justice becomes the reality we all share, I'll never stop fighting. Ever!”</p>
        </div>
    </div>
    <div>
        <img class="categoryColumnImage" src="~/Content/Images/wonderwoman.jpg" alt="WonderWoman" />
        <div class="padding">
            <h2>Wonder Woman</h2>
            <p>“I will fight for those who cannot fight for themselves.” “Now I know, that only love can truly save the world. So I stay, I fight, and I give, for the world I know can be.”</p>
        </div>
    </div>
    <div>
        <img class="categoryColumnImage" src="~/Content/Images/flash.jpg" alt="Flash" />
        <div class="padding">
            <h2>Flash</h2>
            <p>I’m the fastest man alive.</p>
        </div>
    </div>
</div>

</section>