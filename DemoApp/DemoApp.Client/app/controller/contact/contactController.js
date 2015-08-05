(function () {

    var contactController = function () {

        var vm = this;
        vm.welcome = 'Welcome to contact page';
    };

    angular.module('angularApp').controller('contactController', contactController);
}());