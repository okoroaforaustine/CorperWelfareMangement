App.controller("CommunityController", ["CommunityService", "$scope", function (CommunityService, $scope) {
    $scope.Community = {
        CommunityName: "",


    };

    

    $scope.PostCommunity = function () {
        CommunityService.createCommunity($scope.Community).then(function (response) {

            $scope.message = "Community Created" + response.data;
            

        }, function (response) {


            $scope.message = response.data;


        })



    }

   
   

    var getCommunity = function () {
        CommunityService.getCommunity().then(function (result) {

            $scope.Community = result.data;

        }, function () {
            $scope.message = "something went wrong";

        })


    };

    
  


}]);