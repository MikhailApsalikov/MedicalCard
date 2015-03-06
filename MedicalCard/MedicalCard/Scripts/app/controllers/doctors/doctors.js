(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('doctorsController', ['$scope', '$modal', '$rootScope', 'modalService', 'Doctors', '$http',
			function ($scope, $modal, $rootScope, modalService, Doctors, $http) {

				$scope.doctors = [

					{ id: 0, fullName: 'Кузнецов Михаил Викторович', phone: '+7-905-999-66-10', position: 'Хирург' },
					{ id: 1, fullName: 'Апсаликов Михаил Юрьевич', phone: '+7-905-999-66-11', position: 'Костроправ' },
					{ id: 2, fullName: 'Апсаликов Михаил Юрьевич', phone: '+7-905-999-65-10', position: 'Терапевт' },
					{ id: 3, fullName: 'Федяев Иван Викторович', phone: '+7-905-999-66-10', position: 'Мясник' },
					{ id: 4, fullName: 'Усков Дмитрий Викторович', phone: '+7-905-998-66-10', position: 'Проктолог' },
					{ id: 5, fullName: 'Гудков Максим Остапович', phone: '+7-905-941-66-10', position: 'Окулист' },
					{ id: 6, fullName: 'Гук Сергей Викторович', phone: '+7-905-929-66-10', position: 'Ассистент хирурга' },
					{ id: 7, fullName: 'Семичев Михаил Викторович', phone: '+7-915-999-66-10', position: 'Главврач' },
				];

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
						console.log(response);
					});
				};

				$scope.add = function (doctor) {
					showEditModal(doctor).then(function (response) {
						console.log(response);
					});
				};

				$scope.delete = function (doctor) {
					modalService.showConfirmModal({
						text: 'Вы уверены что хотите удалить запись о сотруднике?',
						title: 'Удаление'
					}).then(function () {
						console.log(doctor);
					})
				};

			}]);
}());