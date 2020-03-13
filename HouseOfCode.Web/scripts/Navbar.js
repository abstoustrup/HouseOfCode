$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 2) {
            $('.navbar-custom').addClass('scrolled');
        }
        else {
            $('.navbar-custom').removeClass('scrolled');
        }
    });
});


                        