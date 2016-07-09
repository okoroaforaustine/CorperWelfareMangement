
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular/angular.js" />
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular-mocks/angular-mocks.js" />
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular-resource/angular-resource.js" />
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/jquery/dist/jquery.js" />

/// <reference path="../App.js" />
/// <reference path="../Services/AuthService.js" />
'use strict';
App.controller('RegisterController',['$scope','$location','$timeout','AuthService',function ($scope, $location, $timeout, AuthService) {

    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.registration = {
        userName: "",
        password: "",
        confirmPassword: ""
    };

    $scope.signUp = function () {

        AuthService.saveRegistration($scope.registration).then(function (response) {

            $scope.savedSuccessfully = true;
            $scope.message = "User has been registered successfully, you will be redicted to login page in 2 seconds.";
            startTimer();

        },
         function (response) {
             var errors = [];
             for (var key in response.data.modelState) {
                 for (var i = 0; i < response.data.modelState[key].length; i++) {
                     errors.push(response.data.modelState[key][i]);
                 }
             }
             $scope.message = "Failed to register user due to:" + errors.join(' ');
         });
    };

    var startTimer = function () {
        var timer = $timeout(function () {
            $timeout.cancel(timer);
            $location.path('/Login');
        }, 5000);
    };

}]);