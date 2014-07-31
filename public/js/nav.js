jQuery(function($) {
    var $window = $(window);
    var $sections = $('h2').get().reverse();
    var $navLinks = $('#markdown-toc a');

    var setCurrentSection = function() {
        var cutoff = $window.scrollTop();

        $sections.each(function() {
            var $this = $(this);
            if ($this.offset().top + $this.height() > cutoff) {
                var id = $this.prop('id');
                $navLinks.removeClass('active');

                $navLinks
                    .filter('[href=#' + id + ']')
                    .addClass('active');

                return false;
            }
        });
    };

    $window.on('scroll', setCurrentSection);
    $window.trigger('scroll');
});
