App.factory("Addcorpers", ['$http',function ($http) {


    var AddCorperFactory = {};


    var _AddCorper= function(Corper)
    {
        return $http.post('api/Corpers/Post', Corper).then(function (response) {

            return response;

        });


    }

    AddCorperFactory.AddCorper = _AddCorper;


    return AddCorperFactory;

}]);