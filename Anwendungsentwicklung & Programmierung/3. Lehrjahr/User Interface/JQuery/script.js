$(document).ready(function () {
    $("#para1").click(function () {
        $("#para1").hide();
    });

    $("#para2").click(function () {
        $("#para2").hide();
    });

    $("#para3").click(function () {
        $("#para3").hide();
    });

    $("#btnBigger").click(function () {
        $("#box").animate({ height: $("#box").height() + 50, width: $("#box").width() + 50 });
    })

    $("#btnReset").click(function () {
        $("#box").animate({ height: "100px", width: "100px" });
    })

    $(window).bind('mousewheel', function(event) {
        if (event.originalEvent.wheelDelta >= 0) {
            $("#box").animate({ height: $("#box").height() + 50, width: $("#box").width() + 50 });
        }
        else {
            $("#box").animate({ height: $("#box").height() - 50, width: $("#box").width() - 50 });
        }
    });
});

