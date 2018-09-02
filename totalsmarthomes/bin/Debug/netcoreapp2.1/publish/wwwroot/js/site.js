// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Cookie related


    var ab_cookie_widget = document.getElementById("ab_cookie_widget");
    var results = document.cookie.match("(^|;) ?ab_cookie_accepted=([^;]*)(;|$)");
    if (results) {
        if ("1" === unescape(results[2])) {
            ab_cookie_accept();
        }
        //} else {
        //// This will make the Cookie warning disapppear when any link on a page is clicked. If that functionality is needed, unconment this section
        //    window.onload = function () {
        //        for (var i = 0, L = document.links.length; i < L; i++) {
        //            var link_href = document.links[i].getAttribute('href');
        //            if ('privacy' != document.links[i].getAttribute('rel') && (!/^[\w]+:/.test(link_href) || (new RegExp('^[\\w]+://[\\w\\d\\-\\.]*' + window.location.host)).test(link_href))) {
        //                var current_onclick = document.links[i].onclick;
        //                document.links[i].onclick = function () { ab_cookie_accept(); if (Object.prototype.toString.call(current_onclick) == '[object Function]') { current_onclick(); } };
        //            }
        //        }
        //    };
    }

    // FUNCTION used when CLOSE button is Clicked or AutoClick timeout is reached
    function ab_cookie_accept() {
        clearTimeout(ab_cookie_timer);
        document.cookie = "ab_cookie_accepted=1; path=/; expires=Mon, 18 Jan 2038 01:23:45 GMT";
        ab_cookie_widget.parentNode.removeChild(ab_cookie_widget);
    }

    // NOT USED: Optional function, changing the "Cookie_timeout" value to greater than Zero (0) activates an auto-Click capability
    var ab_cookie_timer;
    var ab_cookie_timeout = 0; // OPTIONAL: Set auto-Click time (in seconds) here to auto-close the message
    if (ab_cookie_timeout > 0) {
        ab_cookie_timer = setTimeout(ab_cookie_autotick, 1000);
    }
    function ab_cookie_autotick() {
        if (0 >= --ab_cookie_timeout) {
            ab_cookie_accept();
            return;
        }
        var ab_cookie_accept_button = document.getElementById("ab_cookie_accept");
        if (null != ab_cookie_accept_button) {
            ab_cookie_accept_button.innerHTML = "Closing in " + ab_cookie_timeout + " seconds";
            ab_cookie_timer = setTimeout(ab_cookie_autotick, 1000);
        }
    }


 $(document).ready(function () {
            $('#Password').passwordStrength();
            $("#Address").hide();
        });

    function DisplayAddress()
    {
        $("#Address").show();
        $("#Address2").val(' ');
        $("#Address3").val(' ');
    }

$( function() {
    $( "#tabs" ).tabs();
  } );
