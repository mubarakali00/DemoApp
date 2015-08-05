(function () {
    
    var tracksController = function() {

        var vm = this;
        vm.Whatever = 'finally its working now';
    };

    angular.module('angularApp').controller('tracksController', tracksController);
}());