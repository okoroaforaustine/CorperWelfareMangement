App.controller("cdsController", ["cdsService", "$scope", function (cdsService, $scope) {

    
    

    $scope.Cds = {
        CdsName: "",


    };

     
      
    
    
     

    $scope.PostCds = function () {
        cdsService.createCds($scope.Cds).then(function (response) {

            
            $scope.message = response.data + "Cds Created succesfully";

          
        }, function (response) {


            $scope.message =response.data;
            

        }

      

        );
       


    }
    
   
  var getCds =  function () {
        cdsService.getCds().then(function (result) {

            $scope.Cds = result.data;

        }, function (result) {
            return result.reponse;

        })
       
        
    };
    
  
  

}]);