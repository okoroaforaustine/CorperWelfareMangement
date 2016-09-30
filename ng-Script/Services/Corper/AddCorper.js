App.factory("Addcorpers", ['$http',function ($http) {


    var AddCorperFactory = {};


    var _AddCorper= function(Corper)
    {
        return $http.post('api/Corpers/Post', Corper).then(function (response) {

            return response;

        });


    }
    var _getCds = function () {
        return $http.get('api/Cds/Get').then(function (result) {

            return result;

        });


    }

    var _getCommunity = function () {

        return $http.get('api/Community/Get').then(function (result) {

            return result;

        });

    }
    var _getBatch = function () {

        return $http.get('api/Batch/Get').then(function (result) {

            return result;

        });

    }
    var _getNyscYear = function () {

        return $http.get('api/NyscYear/Get').then(function (result) {

            return result;

        });

    }


    AddCorperFactory.AddCorper = _AddCorper;
    AddCorperFactory.getCds = _getCds;
    AddCorperFactory.getCommunity = _getCommunity;
    AddCorperFactory.getBatch = _getBatch;
    AddCorperFactory.getNyscYear = _getNyscYear;
    
    return AddCorperFactory;

}]);