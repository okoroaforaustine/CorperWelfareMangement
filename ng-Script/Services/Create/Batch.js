App.factory("BatchService", ["$http", function ($http) {


    var BatchFactory = {};

    var _createBatch = function (Batch) {

        return $http.post('api/Batch/Post', Batch).then(function (response) {

            return response;


        });

    }

    var _getBatch = function () {
        return $http.get('api/Batch/Get').then(function (result) {

            return result;

        }, function (result) {


            return result;

        })


    }


    BatchFactory.createBatch = _createBatch;
    BatchFactory.getBatch = _getBatch;


    return BatchFactory;











}]);