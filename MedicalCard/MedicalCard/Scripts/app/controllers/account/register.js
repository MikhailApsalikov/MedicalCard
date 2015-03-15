(function () {
	'use strict';

	angular.module('medicalCardApp')

	.controller('registerController', ['$scope', 'Accounts', function ($scope, Accounts) {

		$scope.account = new Accounts();

		$scope.register = function () {

			$scope.account.$save().then(function (response) {
				console.log(response)
			});

		};

	}])


}());