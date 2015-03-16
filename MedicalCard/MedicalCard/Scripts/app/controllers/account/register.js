(function () {
	'use strict';

	angular.module('medicalCardApp')

	.controller('registerController', ['$scope', 'Accounts', 'Enums', 'Doctors', function ($scope, Accounts, Enums, Doctors) {

		$scope.account = new Accounts();

		$scope.registerFirstStep = true;

		$scope.register = function () {

			$scope.account.$save(function (response) {
				$scope.registerFirstStep = false;
				console.log(response);
				if (response.Role === Enums.roleCodes.doctor) {
					$scope.doctorCreationMode = true;
					$scope.doctor = new Doctors();
					$scope.doctor.id = response.Id;
					$scope.doctor.account = {
						username: response.Username,
						password: response.Password,
						id: response.Id,
						role: response.Role
					}
				}
			});

		};

		$scope.saveDoctor = function () {

			$scope.doctor.$save(function () {

				alert('ok');
			});

		}

	}])


}());