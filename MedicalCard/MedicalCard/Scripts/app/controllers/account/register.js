(function () {
	'use strict';

	angular.module('medicalCardApp')

	.controller('registerController', ['$scope', 'Accounts', 'Enums', function ($scope, Accounts, Enums) {

		$scope.account = new Accounts();

		$scope.registerFirstStep = true;

		$scope.register = function () {

			$scope.account.$save(function (response) {
				console.log(response);
				$scope.registerFirstStep = false;
			});


		};

	}])


}());