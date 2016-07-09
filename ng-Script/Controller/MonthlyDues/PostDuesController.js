App.controller('PostDuesController', ['$scope', 'PostMonthly', function ($scope, PostMonthly) {

    $scope.MonthlyDues = {
        
        CorperID:"",
        AmountMonthly: "",
        Month:"",
         paid:" ",
       
     
       



    }

  

    

    $scope.monthly = function () {
        PostMonthly.PostDues($scope.MonthlyDues).then(function (response) {
            
            $scope.message="Post Succesfully"

        }, function (error) {
            $scope.error = error.response;

        });
    }


  
    
}]);