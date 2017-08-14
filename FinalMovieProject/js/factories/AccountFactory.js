(function () {
    'use strict';

    angular
        .module('app')
        .factory('AccountFacoty', AccountFacoty);

    AccountFacoty.$inject = ['$http'];

    function AccountFacoty($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }
    }
})();