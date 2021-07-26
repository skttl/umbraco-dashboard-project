angular.module("umbraco").controller("Our.Umbraco.DashIt.DashboardController", function ($scope, $timeout, $http) {
    var vm = this;

    $http.get("/umbraco/backoffice/DashIt/Dashboard/GetWidgets").then(function (response) {

        vm.widgets = response.data;
        vm.loading = false;
        vm.loaded = true;
    });

});