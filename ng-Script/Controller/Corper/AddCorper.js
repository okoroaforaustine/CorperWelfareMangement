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
        BatchName: "",
        NyscYearName: "",
        Cds: "",
        CommunityName:""




    }
    
    


    $scope.Selectors = ["Statecode", "SalesAgentName", "MobileNo"];
    $scope.SelectedCriteria = ""; //The Object used for selecting value from <option>
    $scope.filterValue = "";
    $scope.AbuahCommunity =
         ["Okoboh", "odelga", "Omelima", "ogonokom"]
    


    function getCd() {
        Addcorpers.getCds().then(function (result) {

            $scope.AllCds = result.data;
            console.log(result.data);

        }, function (result) {
            return result.reponse;

        })


    };

    getCd();
    function getCommunitys() {
        Addcorpers.getCommunity().then(function (result) {

            $scope.AllCommunity = result.data;
            console.log(result.data);

        }, function (result) {
            return result.reponse;

        })


    };

    getCommunitys();

    function getBatchs() {
        Addcorpers.getBatch().then(function (result) {

            $scope.AllBatch = result.data;
            console.log(result.data);

        }, function (result) {
            return result.reponse;

        })


    };

    getBatchs();
    function getNyscYears() {
        Addcorpers.getNyscYear().then(function (result) {

            $scope.AllNyscYear = result.data;
            console.log(result.data);

        }, function (result) {
            return result.reponse;

        })


    };

    getNyscYears();




    $scope.SaveCorper = function () {

        Addcorpers.AddCorper($scope.Corper).then(function (response,Corper) {

            
                $scope.savedSuccessfully = true;


                $scope.message = response.data+"Created Successfully";
                console.log(response.data);

        }, function (response) {
            $scope.message = response.data;

            console.log(response.data);


        }
          
 
   

        )

   
         
      
    }


   













}]);