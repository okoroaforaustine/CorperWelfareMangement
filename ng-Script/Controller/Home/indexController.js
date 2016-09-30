App.controller('indexController', ['$scope', '$location', 'AuthService', function ($scope, $location, AuthService) {

    $scope.logOut = function () {
        AuthService.logOut();
        $location.path('/home');
        console.log("hello");
    }
   

    $scope.authentication = AuthService.authentication;






}]);