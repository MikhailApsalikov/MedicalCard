(function () {
	'use strict';

	angular.module('medicalCardApp')

	.controller('registerController', ['$scope', 'Accounts', 'Enums', 'Doctors', '$window', 'toastService', 'Patients', 'Positions', function ($scope, Accounts, Enums, Doctors, $window, toastService, Patients, Positions) {

		$scope.account = new Accounts();

		$scope.registerFirstStep = true;

		var positions = Positions.query(function () {
			$scope.positions = positions;
		});




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
						role: +response.Role
					}
				}

				if (response.Role === Enums.roleCodes.patient) {
					$scope.patientCreationMode = true;
					$scope.patient = new Patients();
					$scope.patient.id = response.Id;
					$scope.patient.account = {
						username: response.Username,
						password: response.Password,
						id: response.Id,
						role: +response.Role
					}
				}

			});

		};

		$scope.saveDoctor = function () {
			Doctors.update({ id: $scope.doctor.id }, $scope.doctor, function () {
				toastService.showSuccessToast({
					text: 'Вы успешно зарегистрировались!',
					title: 'Регистрация'
				});
				$scope.user.name = $scope.doctor.FirstName;
				$window.location = '#/doctors';
			})
		};

		$scope.savePatient = function () {
			Patients.update({ id: $scope.patient.id }, $scope.patient, function () {
				toastService.showSuccessToast({
					text: 'Вы успешно зарегистрировались!',
					title: 'Регистрация'
				});
				$scope.user.name = $scope.patient.FirstName;
				$window.location = '#/patients';
			})
		}
	}]);


}());