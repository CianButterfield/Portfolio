//load the DOM into jQuery
$(document).ready(function() {
    //Carousel functions START
    $('.carousel-next').on('click', function () {
        //get the active slide
        var activeSlide = $(this).parent().find('.carousel.active');
        //get the next slide
        var nextSlide = activeSlide.next();
        //make sure it's a carousel slide
        if (!nextSlide.hasClass('carousel')) {
            nextSlide = $(this).parent().find('.carousel').first();
        }
        //remove the active and add the hide classes from the active slide
        activeSlide.removeClass('active').addClass('hide');
        //remove the hide and add the active classes to the next slide
        nextSlide.removeClass('hide').addClass('active');
    });

    $('.carousel-prev').on('click', function () {
        //get the active slide
        var activeSlide = $(this).parent().find('.carousel.active');
        //get the next slide
        var prevSlide = activeSlide.prev();
        //make sure it's a carousel slide
        if (!prevSlide.hasClass('carousel')) {
            prevSlide = $(this).parent().find('.carousel').last();
        }
        //remove the active and add the hide classes from the active slide
        activeSlide.removeClass('active').addClass('hide');
        //remove the hide and add the active classes to the next slide
        prevSlide.removeClass('hide').addClass('active');
    });
    //Carousel functions END

    //ajax post for contact form
    $('#contactForm').on("submit", function (event) {
        event.preventDefault();
        //see if the form is valid
        if ($(this).valid()) {
            $.post($(this).attr('action'), $(this).serialize(), function (data) {
                //update the container element with the new html returned in the "data" param
                $('#container').html(data);
            });
        }

    });
});


