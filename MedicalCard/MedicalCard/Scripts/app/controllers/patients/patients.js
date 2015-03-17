(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('patientsController', ['$scope', '$modal', '$rootScope', 'modalService', 'Patients', 'Doctors', 'toastService',
			function ($scope, $modal, $rootScope, modalService, Patients, Doctors, toastService) {

				function setPatients() {
					$scope.patients = Patients.query(function () {
						console.log($scope.patients);
					});

					$scope.doctors = Doctors.query(function () {

						$scope.doctors = _.map($scope.doctors, function (doctor) {
							return {
								id: doctor.Id,
								fullName: doctor.LastName + ' ' + doctor.FirstName + ' ' + doctor.MiddleName
							}
						})

					});


				}

				setPatients();

				function showEditModal(patient) {

					var scope = $rootScope.$new(),
						options = {
							templateUrl: '/Scripts/app/controllers/patients/editModal.html',
							controller: 'patientEditController',
							backdrop: 'static',
							scope: scope
						};

					scope.patient = angular.copy(patient);

					return $modal.open(options).result;
				}

				$scope.edit = function (patient) {
					showEditModal(patient).then(function (response) {
						Patients.update({ id: response.Id }, response, function () {
							toastService.showSuccessToast({
								text: 'Данные успешно сохранены!',
								title: 'Редактирование'
							});
							setPatients();
						})
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
						patient.$delete(function () {
							setPatients();
						});
					})
				};

			}]);
}());