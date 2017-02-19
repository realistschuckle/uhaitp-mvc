// Write your Javascript code.
(function () {
    var deleters = document.querySelectorAll('.delete-button');
    for (var i = 0; i < deleters.length; i += 1) {
        var deleter = deleters[i];
        var form = deleter;
        while (form.tagName !== 'FORM') {
            form = form.parentElement;
        }
        deleter.addEventListener('click', (function (form, e) {
            e.preventDefault();
            if (form) {
                form.submit();
            }
        }).bind(deleter, form));
    }
})();
