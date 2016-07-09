App.controller('indexController', ['$scope', '$location', 'AuthService', function ($scope, $location, AuthService) {

    $scope.logOut = function () {
        AuthService.logOut();
        $location.path('/Home');
    }
   

    $scope.authentication = AuthService.authentication;






}]);