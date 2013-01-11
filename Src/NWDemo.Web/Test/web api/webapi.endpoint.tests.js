(function() {
    QUnit.config.testTimeout = 10000;

    var stringformat = QUnit.stringformat;

    module("Web Api Get Endpoints respond successfully");

    var apiUrls = [
        '/api/lookups/categories',
        '/api/lookups/products',
        '/api/lookups/customers'
    ];

    var apiUrlslen = apiUrls.length;

    var endpointest = function(url) {
        $.ajax({
            url: url,
            dataType: 'json',
            success: function(result) {
                ok(true, 'GET succeeded for ' + url);
                ok(!!result, 'GET retrieved some data');
                start();
            },
            error: function(result) {
                ok(false, stringformat('GET on \'{0}\' failed with status = \'{1}\': {2}', url, result.status, result.responseText));
                start();
            }
        });
    };

    var endpointTestGenerator = function(url) {
        return function() { endpointest(url); };
    };

    //Test each endpoint in api urls
    for (var i = 0; i < apiUrlslen; i++) {
        var apiUrl = apiUrls[i];
        asyncTest('API can be reached: ' + apiUrl, endpointTestGenerator(apiUrl));
    }
})();