/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular-route/angular-route.js" />
/// <reference path="C:\Users\yessboss\Documents\Visual Studio 2013\Projects\CorpersWelfareManager\bower_components/angular/angular.js" />
/// <reference path="../App.js" />

App.controller('CorperController', ['$http', 'Addcorpers', '$scope', '$location', function ($http, Addcorpers, $scope, $location) {

    $scope.savedSuccessfully = false;
    $scope.message = "";

    $scope.Corper = {
        
        Statecode: "",
        Firstname: "",
        Lastname: "",
        Community: "",
        MonthlyID: "",




    }
    

    $scope.Selectors = ["Statecode", "SalesAgentName", "MobileNo"];
    $scope.SelectedCriteria = ""; //The Object used for selecting value from <option>
    $scope.filterValue = "";
    $scope.AbuahCommunity =
         ["Okoboh", "odelga", "Omelima", "ogonokom"]



   

    $scope.SaveCorper = function () {

        Addcorpers.AddCorper($scope.Corper).then(function (response) {
            $scope.savedSuccessfully = true;
     
            $scope.message = "Corper Added successfully";


        }, function (error) {
            $scope.error = error.response;


        }


        )
    }
















}]);