/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular-route/angular-route.js" />
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular/angular.js" />

var App = angular.module("App", ['ngRoute', 'LocalStorageModule', 'ngResource', 'ui.bootstrap','validation','validation.rule'])
    .config(function ($routeProvider) {
        $routeProvider.when('/home', {
            templateUrl: '/ng-View/Home/Home.html',
            controller: "homeController",
            
        });
        $routeProvider.when('/Login', {

            templateUrl: '/ng-View/Account/Login.html',
            controller: "LoginController",

        });

    $routeProvider.when('/Home/Register', {

        templateUrl: '/ng-View/Account/Register.html',
        controller: 'RegisterController'

        

    });

    $routeProvider.when('/Corper/Add', {

        templateUrl: '/ng-View/Corper/AddCorper.html',
        controller: 'CorperController'



    });


    $routeProvider.when('/Corper/All', {

        templateUrl: '/ng-View/Corper/AllCorper.html',
        controller: 'CorperController'



    });
    $routeProvider.when('/Corper/Update/: CorperID', {

        templateUrl: '/ng-View/Corper/UpdateCorper.html',
        controller: 'EditCorpersController'



    });

    $routeProvider.when('/Corper/Page', {

        templateUrl: '/ng-View/Corper/CorperPage.html',
        controller: 'fullCtrl'



    });
    $routeProvider.when('/Admin', {

        templateUrl: '/ng-View/Home/AdminDashBoard.html'
        



    });
   
  

    $routeProvider.when('/Summary', {

        templateUrl: '/ng-View/MonthlyDues/MonthlyDues.html',
        controller: 'TotalSum'



    });

    $routeProvider.when('/AllDues', {

        templateUrl: '/ng-View/MonthlyDues/AllDues.html',
        controller: 'PostDuesController'



    });

    $routeProvider.when('/PostDue', {

        templateUrl: '/ng-View/MonthlyDues/PostMonthly.html',
        controller: 'PostDuesController'



    });





    });






    
App.config(function ($httpProvider) {
   $httpProvider.interceptors.push('authInterceptorService');
});
