App.factory("NyscYearService", ["$http", function ($http) {


    var NyscYearFactory = {};

    var _createNyscYear = function (NyscYear) {

        return $http.post('api/NyscYear/Post', NyscYear).then(function (response) {

            return response;


        });

    }

    var _getNyscYear = function () {
        return $http.get('api/NyscYear/Get').then(function (result) {

            return result;
        }, function (result) {


            return result;

        })


    }


    NyscYearFactory.createNyscYear = _createNyscYear;
    NyscYearFactory.getNyscYear = _getNyscYear;


    return NyscYearFactory;











}]);