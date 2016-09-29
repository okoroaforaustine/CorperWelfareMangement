App.factory("cdsService", ["$http", function ($http) {


    var CdsFactory = {};

    var _createCds = function (Cds) {

        return $http.post('api/Cds/Post', Cds).then(function (response) {

            return response;


        });

    }


    var _getCds = function () {
        return $http.get('api/Cds/Get').then(function (result) {

            return result;
        }, function (result) {


            return result;

        })


    }

   


    CdsFactory.createCds = _createCds;
    CdsFactory.getCds = _getCds;


    return CdsFactory;






}]);