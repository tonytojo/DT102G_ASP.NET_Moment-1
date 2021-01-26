"use strict";

//Handle setting active om the page that is currently
function setActive(page) {
    $('.sidebar-ul li').removeAttr("class");
    $('#' + page).addClass("active");
}


//Code that support toggle the menu
$("#toggle-menu").click(function ()
{
    $("#menu").slideToggle();
})


/* Handle displying the menu when resize window */
$(window).resize(function () {
    var width = $(window).width();
    if (width > 850 && width < 860) {
        $("#menu").slideDown();
    }
});