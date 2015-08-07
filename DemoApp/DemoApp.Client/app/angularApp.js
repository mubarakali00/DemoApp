(function () {

    var app = angular.module('angularApp', ["ngRoute"]);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        var baseUrl = 'app/view/';
        $routeProvider
            .when('/', {
                templateUrl: baseUrl + 'tracks/trackListView.html',
                controller: 'tracksController',
                controllerAs: 'vm'
            })
            .when('/contact', {
                templateUrl: baseUrl + 'contact/contactView.html',
                controller: 'contactController',
                controllerAs: 'vm'
            })
            .otherwise({
                redirectTo: '/'
            });

        $locationProvider.html5Mode(true);

    }]);

}());