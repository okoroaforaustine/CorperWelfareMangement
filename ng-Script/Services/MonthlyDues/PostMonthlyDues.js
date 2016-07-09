App.factory("PostMonthly", ['$http', function ($http) {

    var PostMonthlyFactory = {};


    var _PostDues = function (MonthlyDues) {

        return $http.post('api/Monthlydues/post',MonthlyDues).then(function (response) {

            return response;


        });



    };

     PostMonthlyFactory.PostDues=_PostDues;

    

    return PostMonthlyFactory;










}]);
