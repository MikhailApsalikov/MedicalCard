(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('doctorsController', ['$scope', '$modal', '$rootScope', 'modalService', 'Doctors', '$http',
			function ($scope, $modal, $rootScope, modalService, Doctors, $http) {


				function setDoctors() {
					$scope.doctors = Doctors.query(function () {
						console.log($scope.doctors);
					});
				}

				setDoctors();

				var query = Doctors.query(function (response) {
					console.log(query);
				});

				function showEditModal(doctor) {

					var scope = $rootScope.$new(),
						options = {
							templateUrl: '/Scripts/app/controllers/doctors/editModal.html',
							controller: 'editController',
							backdrop: 'static',
							scope: scope
						};

					scope.doctor = angular.copy(doctor);

					return $modal.open(options).result;
				}

				$scope.edit = function (doctor) {
					showEditModal(doctor).then(function (response) {
						Doctors.update({ id: response.Id }, response, function () {
							setDoctors();
						});
					});
				};

				$scope.add = function () {
					showEditModal(new Doctors()).then(function (response) {
						response.$save(function () {
							setDoctors();
						});
					})
				};

				$scope.delete = function (doctor) {
					modalService.showConfirmModal({
						text: 'Вы уверены что хотите удалить запись о сотруднике?',
						title: 'Удаление'
					}).then(function () {
						doctor.$delete(function () {
							setDoctors();
						});
					})
				};

			}]);
}());