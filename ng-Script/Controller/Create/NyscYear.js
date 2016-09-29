App.controller("NyscYearController", ["NyscYearService", "$scope", function (NyscYearService, $scope) {
    $scope.NyscYear = {
        NyscYearName: "",


    };



    $scope.PostNyscYear = function () {
        NyscYearService.createNyscYear($scope.NyscYear).then(function (response) {

            $scope.message = "NyscYear Created" + response.data;
            

        }, function (response) {


            $scope.message = response.data;


        })



    }




    var getNyscYear = function () {
        NyscYearService.getNyscYear().then(function (result) {

            $scope.NyscYear = result.data;
            

        }, function () {
            $scope.message = "something went wrong";

        })
     
        
    };

  
    


}]);