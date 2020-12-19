(function () {
    $('.reset-website button').on('click', () => {
        if (!confirm('Do you really want to reset your website? This cannot be undone and all files related to your current website will be permenantly delete.')) { return; }
        $.ajax({
            url: '/ResetWebsite',
            success: () => {
                alert('The current website reset to the default template website. The page will now be reloaded...');
                window.parent.location.reload();
            }
        });
    });
})();