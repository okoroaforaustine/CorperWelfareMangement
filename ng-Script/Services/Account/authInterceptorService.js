'use strict';
App.factory('authInterceptorService', ['$q', '$injector', '$location', 'localStorageService', function ($q, $injector, $location, localStorageService) {
    var authInterceptorServiceFactory = {};

    var _request = function (config) {

        //COnfiguring the header
        config.headers = config.headers || {};
        
       
        var authData = localStorageService.get('authorizationData');
        if (authData) {
            //if(authData) is true,set the header to contain bearer and token of stored token in the browser
            config.headers.Authorization = 'Bearer ' + authData.token;
        }

        return config;
    }
    
    //response error when there is a rejection the promise http status of equals to 401

    var _responseError = function (rejection) {
        if (rejection.status === 401) {
            $location.path('/Login');
        }
        return $q.reject(rejection);
    }

    authInterceptorServiceFactory.request = _request;
    authInterceptorServiceFactory.responseError = _responseError;

    return authInterceptorServiceFactory;
    
}]);