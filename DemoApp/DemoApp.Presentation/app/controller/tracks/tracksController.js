(function () {
    
    var tracksController = function() {

        var vm = this;
        vm.Whatever = 'finally its working now';
    };

    angular.module('demoStore').controller('tracksController', tracksController);
}());