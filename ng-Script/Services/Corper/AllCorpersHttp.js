
(function () {
    'use strict';

    angular
        .module('App')
        .factory('clubClientSvc', function ($resource) {
            return $resource("api/Corpers/:id",
                { id: "@id" },
                {
                    'query': {
                        method: 'GET',
                        url: '/api/Corpers/:pageSize/:pageNumber/:orderBy',
                        params: { pageSize: '@pageSize', pageNumber: '@pageNumber', orderBy: '@orderBy' }
                    }
                });
        });
})();

