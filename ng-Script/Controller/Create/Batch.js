App.controller("BatchController", ["BatchService", "$scope", function (BatchService, $scope) {
    $scope.Batch = {
        BatchName: ""


    };



    $scope.PostBatch = function () {
        BatchService.createBatch($scope.Batch).then(function (response) {

            $scope.message = "Batch Created" + response.data;
           

        }, function (response) {


            $scope.message = response.data;


        })



    }




    var getBatch = function () {
        BatchService.getBatch().then(function (result) {

            $scope.Batch = result.data;

        }, function () {
            $scope.message = "something went wrong";

        })


    };

    
    


}]);