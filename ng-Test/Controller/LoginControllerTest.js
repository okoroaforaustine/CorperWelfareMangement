/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\bower_components/angular/angular.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\bower_components/angular-mocks/angular-mocks.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\ng-Script/App.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\bower_components/angular-local-storage/dist/angular-local-storage.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\ng-Script/Services/AuthService.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\bower_components/jasmine-sinon/lib/jasmine-sinon.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\ng-Script/Controller/LoginController.js" />
/// <reference path="C:\Users\yessboss\documents\visual studio 2013\Projects\CorpersWelfareManager\ng-Script/Services/authInterceptorService.js" />


describe('LoginController', function () {

    var scope, AuthService, $controllerconstructor, userName, password;

    beforeEach(function () {

        module('App'),

        module('LocalStorageModule')

    });
    
    beforeEach(inject(function ($controller, $rootScope) {

        $controllerconstructor = $controller,
       
        scope = $rootScope.$new();
        
    }));


    beforeEach(function () {

        AuthService = {

            Login: function (userName, password) {

                userName: '';
                password: '';  

            }

        };
        spyOn(AuthService, 'Login')
        
        AuthService.Login('okoroafor','emeka');
      

    })
   

    it(' to track that AuthService.Login was called', function () {

        var contrl = $controllerconstructor('LoginController', { $scope: scope, AuthService: {}, });

       

        expect(AuthService.Login).toHaveBeenCalled();

    });

     

});


 
    








        
   

   



  