(function () {
    'use strict';

    angular
        .module('app')
        .controller('AccountController', AccountController);

    AccountController.$inject = ['$location'];

    function AccountController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'AccountController';

        activate();

        function activate() { }
    }
})();
