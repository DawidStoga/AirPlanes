$(document).ready(function () {
    $("p:nth-child(1)").click(function () {
        $(this).addClass("classA").addClass("classB");
        $(this).addClass(function (index) {
            console.log(index);
            return "classC";
        });
    });

    /*******************/
    $("p:nth-child(2)").click(function () {
        $(this).attr("align", "center");
        var al = $(this).attr("align");
        $(this).attr({
            align: "left"
        });
        console.log(al);
        $(this).text(al);
    });
    /*****************************/
    $("p:nth-child(3)").click(function () {
        var hasclass = $(this).hasClass("classA");

        $(this).text("Has class A? : " + hasclass);

    });
    /*****************************/
    $("p:nth-child(4)").on(
        {
            mouseenter: function () {
                var ht = $(this).html();

                console.log(ht);
                $(this).text(ht);
            }
        }
        );

    /*******************/
    $("p:nth-child(5)").click(function () {
        var t = $(":checkbox");
       
        var chck = $(":checkbox").prop("checked");
    
      $(this).text(chck);
    });


});