App.controller('PostDuesController', ['$scope', 'PostMonthly', function ($scope, PostMonthly) {

    $scope.MonthlyDues = {
        
        CorperID:"",
        AmountMonthly: "",
        Month:"",
         paid:" ",
       
     
       



    }

  

    

    $scope.monthly = function () {
        PostMonthly.PostDues($scope.MonthlyDues).then(function (response) {
            
            $scope.message = "Payment Succesfully";

        }, function (response) {
            $scope.error = response.data;

        });
    }


  
    
}]);