(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('patientsController', ['$scope', '$modal', '$rootScope', 'modalService', 'Doctors',
			function ($scope, $modal, $rootScope, modalService, Patients) {

				$scope.doctors = [


				];


				function showEditModal(patient) {

					var scope = $rootScope.$new(),
						options = {
							templateUrl: '/Scripts/app/controllers/patients/editModal.html',
							controller: 'patientEditController',
							backdrop: 'static',
							scope: scope
						};

					scope.doctor = angular.copy(patient);

					return $modal.open(options).result;
				}

				$scope.edit = function (patient) {
					showEditModal(patient).then(function (response) {
						console.log(response);
					});
				};

				$scope.add = function (patient) {
					showEditModal(patient).then(function (response) {
						console.log(response);
					});
				};

				$scope.delete = function (patient) {
					modalService.showConfirmModal({
						text: 'Вы уверены что хотите удалить запись о пациенте?',
						title: 'Удаление'
					}).then(function () {
						console.log(patient);
					})
				};

			}]);
}());