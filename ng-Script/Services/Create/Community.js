App.factory("CommunityService", ["$http", function ($http) {


    var CommunityFactory = {};

    var _createCommunity = function (Community) {

        return $http.post('api/Community/Post', Community).then(function (response) {

            return response;


        });

    }

    var _getCommunity = function () {
        return $http.get('api/Community/Get').then(function (result) {

            return result;
        }, function (result) {


            return result;

        })


    }


    CommunityFactory.createCommunity = _createCommunity;
    CommunityFactory.getCommunity = _getCommunity;


    return CommunityFactory;











}]);