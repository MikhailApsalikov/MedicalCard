(function () {

	'use strict';

	angular.module('medicalCardApp', [
		'ngRoute',
		'toastr',
		'ngAnimate',
		'ngResource',
		'ui.bootstrap',
	])
	.controller('mainController', ['$scope', '$rootScope', '$window', 'modalService', '$http', 'toastService', function ($scope, $rootScope, $window, modalService, $http, toastService) {

		$scope.user = {};

		$scope.logout = function () {
			modalService.showConfirmModal({
				text: 'Вы уверены что хотите выйти?',
				title: 'Выход'
			}).then(function () {
				$window.location = '#/login';
				$scope.user = {};
				localStorage['id'] = '';
				localStorage['username'] = '';
			})
		};

		$scope.login = function () {
				var promise = $http.post('/home/login', { username: $scope.user.login, password: $scope.user.password });

				promise.then(function (response) {
					console.log(response);
					localStorage['id'] = response.data.id;
					localStorage['username'] = response.data.username;
					$scope.user = response.data;
					$window.location = '#/home';
				});
				promise.error(function (response) {
					toastService.showHttpErrorToast(response);
				})

		};

		$scope.$on('$routeChangeSuccess', function (params, route, next) {
			if ($window.location !== '#/login' && $window.location.hash !== '#/register') {
				if (!localStorage['id']) {
					$window.location = '#/login';
				} else {
					$scope.user.name = localStorage['username'];
					$scope.user.id = localStorage['id'];
				}
			}


		});
	}]);

}());