App.controller("TotalSum",['$http','TotalMonthly','$scope',function($http,TotalMonthly,$scope){
    Totalsum();

   

  function  Totalsum ()
    {

        TotalMonthly.GetTotal().then(function (result) {
            if (result.data.AmountMonthly = "") {
                $scope.Total = 'N0.00';
            }
            else {
                $scope.Total = result.data;


            }




        })
    }


}])







