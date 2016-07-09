App.factory("TotalMonthly", ['$http', function ($http) {

   var TotalMonthlyFactory = {};

   var _GetTotal = function () {
       return $http.get('api/MonthlyDues/GetAmount').then(function (result) {



           return result;

       });




   };
   

   
   TotalMonthlyFactory.GetTotal = _GetTotal;

   return TotalMonthlyFactory;


}]);