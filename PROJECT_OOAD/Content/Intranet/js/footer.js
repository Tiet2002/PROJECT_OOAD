var mL = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
var mS = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'June', 'July', 'Aug', 'Sept', 'Oct', 'Nov', 'Dec'];

function pad(num, size) {
    num = num.toString();
    while (num.length < size) num = "0" + num;
    return num;
}

$(document).add(function () {
    setInterval(function () {
        var d = new Date();
        var now = pad(d.getDate(), 2) +
                    "-" + mS[d.getMonth()] +
                    "-" + d.getFullYear() +
                    " " + pad(d.getHours(), 2) +
                    ":" + pad(d.getMinutes(), 2) +
                    ":" + pad(d.getSeconds(), 2);

        $(".mytime").html(now);
    }, 1000);

    var pathArray = window.location.pathname.split('/');
    //alert(window.location.pathname);
    
    //Set active and open menu
    //$('.active').parents('li.p1').find('a.nav-link:first').addClass("active");
    $('.active').parents('li.p1').addClass("menu-open");

    $('.active').parents('li.p2').find('a.nav-link:first').addClass("active");
    $('.active').parents('li.p2').addClass("menu-open");
});

//$('a .active').parents('.p3').addClass("active");