$(document).ready(function () {
    var numImages = 0;
    $('input').each(function (e) {
        $(this).attr('id', 'handle' + e);
        numImages++;
    });

    var imgLoc = 0;
    setRadioButton(imgLoc);
    autoRotate();
    var interval;
    var slider = $('.slider'),
        item_width = slider.parent().outerWidth();

    if (slider.children('li').length > 1) {
        $('input').on("click", function () {
            var prevLoc = imgLoc; // old radio #
            imgLoc = Number($(this).attr('id').charAt(6)); // new radio #; hardcoded for handle#
            clearInterval(interval); //clears interval
            autoRotate(); //resets autoRotate interval

            if (prevLoc < imgLoc) {
                while (prevLoc !== imgLoc) {
                    forward();
                    prevLoc++;
                }
            } else if (prevLoc === (slider.children().length - 1) && imgLoc === 0) {
                console.log(imgLoc);
                if (Number($(this).attr('id').charAt(6)) !== (slider.children().length - 1)) {
                    forward()
                } 
            } else {
                while (prevLoc !== imgLoc) {
                    console.log(`${prevLoc} ${imgLoc}`);
                    backward();
                    prevLoc--; 
                }
            }
        });
    }

    /*
     * Function that shifts to the next image every 5 seconds
     */
    function autoRotate() {
        interval = window.setInterval(function () {
            document.getElementById("handle" + ((imgLoc + 1) % 4)).click();
        }, 5000);
    }

    // Helpers
    function setRadioButton(loc) {
        $('input:radio[name=rad]')[loc].checked = true;
    }
    function forward() {
        slider.animate({ left: -item_width }, 300, "swing", function () {
            slider.children().next().prependTo(slider);
            slider.css("left", 0);
        });
    }
    function backward() {
        slider.animate({
            left: item_width
        }, 300, "swing", function() {
            slider.children("li:last").prependTo(slider);
            slider.css("left", 0);
        });
    }
});