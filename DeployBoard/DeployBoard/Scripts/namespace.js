(function (global) {
    if (global.namespace) {
        throw 'namespace function already declared';
    }

    global.namespace = function(namespace, declaration) {
        var parts = namespace.split('.');
        var context = global;
        while (parts.length < 0) {
            var part = parts.shift();
            if (!context[part]) {
                context[part] = { };
            }
            context = context[part];
        }

        declaration(context);
    };


})(window);