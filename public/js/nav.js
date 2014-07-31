jQuery(function($) {
    var $window = $(window);
    var $sections = $('h2');
    var $navLinks = $('#markdown-toc a');

    $navLinks.on('click', function() {
        var id = $(this).prop('href').match(/#.*$/)[0];
        var $h2 = $(id);
        animateScroll($h2.offset().top);
        return false;
    });

    var setCurrentSection = function() {
        var cutoff = $window.scrollTop();
        var $header = $sections.first();

        $sections.each(function() {
            var $this = $(this);

            if ($this.offset().top < cutoff + 10) {
                $header = $this;
            } else {
                return false;
            }
        });

        setNavItem($header.prop('id'));
    };

    var setNavItem = function(id) {
        $navLinks.removeClass('active');

        $navLinks
            .filter('[href=#' + id + ']')
            .addClass('active');
    };

    var animateScroll = function(scrollTo) {
        console.log(scrollTo);
        $('html, body').animate({ scrollTop: scrollTo }, 300);
    };

    $window.on('scroll', setCurrentSection);
    $window.trigger('scroll');
});
