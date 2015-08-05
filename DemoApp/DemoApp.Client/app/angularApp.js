(function () {

    var app = angular.module('angularApp', ["ngRoute"]);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/', {
                templateUrl: 'app/view/tracks/trackListView.html',
                controller: 'tracksController',
                controllerAs: 'vm'
            })
            .when('/contact', {
                templateUrl: 'app/view/contact/contactView.html',
                controller: 'contactController',
                controllerAs: 'vm'
            })
            .otherwise({
                redirectTo: '/'
            });

        $locationProvider.html5Mode(true);

    }]);

}());