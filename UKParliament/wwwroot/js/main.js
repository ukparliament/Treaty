var UK_Parliament = (function () {

    var
        /**
         * Set a cookie
         * @param {string} cname the cookie name
         * @param {string} cvalue the cookie value
         * @param {number} exdays the cookie expiration days
         */
        setCookie = function (cname, cvalue, exdays) {
            var d = new Date();
            d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
            var expires = 'expires=' + d.toUTCString();
            document.cookie = cname + '=' + cvalue + '; ' + expires + ';path=/';
        },

        /**
         * Get a cookie
         * @param {string} cname the cookie name
         */
        getCookie = function (cname) {
            var name = cname + '=';
            var ca = document.cookie.split(';');
            for (var i = 0; i < ca.length; i++) {
                var c = ca[i].trim();
                if (c.indexOf(name) === 0) return c.substring(name.length, c.length);
            }
            return false;
        },

        /**
         * Create AJAX request
         * @param {string} path the location of the object to request
         * @param {function} callback a callback which is called after a response is recieved
         */
        httpRequest = function (path, callback) {
            var request = new XMLHttpRequest();

            request.open('GET', path);
            request.onreadystatechange = function () {
                if (request.readyState === 4) {
                    if (request.status === 200) {
                        var response = JSON.parse(request.responseText);
                        if (callback) {
                            callback(response);
                        }
                    } else {
                        console.log(request.statusText);
                    }
                }
            };
            request.send();
        },

        /**
         * Get ancestor of an element based on matching attributes by traversing up the DOM
         * @param {object} element The element to traverse from
         * @param {object} attributes HTML attributes with values to check against
         * @param {function} callback Allows user to modify the matching parent element
         *
         * @return Returns parent element that contains all specified `attributes`
         */
        traverseUp = function (element, attributes, callback) {

            var
                parent = element.parentElement,
                attrs = Object.keys(attributes);

            if (parent) {

                for (var i = 0; i < attrs.length; i++) {
                    if (
                        parent.hasAttribute(attrs[i]) &&
                        parent.getAttribute(attrs[i]) === attributes[attrs[i]]
                    ) {
                        if ((i + 1) === attrs.length) {
                            return callback ? callback(parent) : parent;
                        } else {
                            continue;
                        }
                    } else {
                        return this.traverseUp(parent, attributes, callback);
                    }
                }

            }

            throw 'Sorry, there is no such ancestor with the identifiers you referenced: ' + JSON.stringify(attributes);

        },

        /**
         * Toggle class to switch styles
         * @param {object} element Element to toggle class on
         * @param {string} class_name Class to toggle
         */
        toggleClass = function (element, class_name) {

            if (element) {
                element.classList.contains(class_name) ?
                    element.classList.remove(class_name) :
                    element.classList.add(class_name);
            }

        };

    return {
        setCookie: setCookie,
        getCookie: getCookie,
        httpRequest: httpRequest,
        traverseUp: traverseUp,
        toggleClass: toggleClass
    };
})();

//UK_Parliament.cookieBanner = function (cname, cvalue, exdays) {

//  var
//    cookieContent = document.getElementById('cookie'),
//    cookieName = this.getCookie(cname);

//  if (!cookieName && cookieContent) {
//    cookieContent.classList.add('show');
//    this.setCookie(cname, cvalue, exdays);
//  }
//};

//UK_Parliament.cookieBanner('UK_Parliament__seen_cookie_message', 'yes', 28);

UK_Parliament.nsAria = function () {
    var noScript = document.getElementsByTagName('noscript');

    if (noScript) {
        // Loop through collected tags and add aria attribute
        for (var i = 0; i < noScript.length; i++) {
            noScript[i].setAttribute('aria-hidden', 'true');
        }
    }

};

UK_Parliament.nsAria();

UK_Parliament.search = function () {
    var
        header = document.querySelector('header'),
        logo = header.querySelector('.uk_parliament'),
        form = header.querySelector('form'),
        input = header.querySelector('input'),
        inputGroup = header.querySelector('.input-group'),
        button = header.querySelector('button'),
        buttonToggle = header.querySelector('form + a'),
        desktop = 768;

    if (buttonToggle) {
        checkScreenSize();
        buttonToggle.addEventListener('click', toggleSearch);
        window.addEventListener('orientationchange', checkScreenSize);
    }

    function checkScreenSize() {
        if (window.innerWidth <= desktop) {
            buttonToggle.removeAttribute('tabIndex');
            (form.classList.contains('open')) ? removeAttr() : setAttr();
        } else {
            removeAttr();
            buttonToggle.setAttribute('tabIndex', '-1');
            buttonToggle.setAttribute('aria-hidden', 'true');
        }
    }

    function removeAttr() {
        inputGroup.removeAttribute('aria-hidden');
        input.removeAttribute('tabIndex');
        button.removeAttribute('tabIndex');
    }

    function setAttr() {
        inputGroup.setAttribute('aria-hidden', 'true');
        input.setAttribute('tabIndex', '-1');
        button.setAttribute('tabIndex', '-1');
    }

    function toggleSearch(e) {
        (form.classList.contains('open')) ? closeSearch(e) : openSearch(e);
    }

    function closeSearch(e) {
        e.preventDefault();
        logo.classList.remove('portcullis');
        form.classList.remove('open');
        buttonToggle.setAttribute('aria-label', 'open search');
        setAttr();
    }

    function openSearch(e) {
        e.preventDefault();
        logo.classList.add('portcullis');
        form.classList.add('open');
        buttonToggle.setAttribute('aria-label', 'close search');
        input.focus();
        removeAttr();
    }
};

UK_Parliament.search();

UK_Parliament.toggle = function () {

    var
        attribute = 'data-toggle',
        buttons = document.querySelectorAll('[' + attribute + '="parent-item"]');

    // End program if there are no toggle buttons.
    if (buttons.length < 1) {
        return false;
    }

    // Add click/change events to toggle buttons.
    for (var i = 0; i < buttons.length; i++) {

        if (buttons[i].tagName.toUpperCase() === 'INPUT') {
            switch (buttons[i].getAttribute('type')) {
                case 'checkbox':
                case 'radio':
                    buttons[i].onchange = doToggle;
                    break;
            }
        } else {
            buttons[i].onclick = doToggle;
        }

    }

    // Do toggle
    function doToggle(e) {
        e.preventDefault();

        var
            active_state = 'open',
            target = UK_Parliament.traverseUp(e.target, { 'data-toggle': 'item' });

        // Toggle class 'open' to element with the attribute `data-toggle` that
        // contains a value of 'item' or 'content'.
        UK_Parliament.toggleClass(target, active_state);
        UK_Parliament.toggleClass(
            target.querySelector('[' + attribute + '="content"]'), active_state);

    }

};

UK_Parliament.toggle();
