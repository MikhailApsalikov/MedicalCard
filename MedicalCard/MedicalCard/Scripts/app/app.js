(function () {

	'use strict';

	angular.module('medicalCardApp', [
		'ngRoute',
		'toastr',
		'ngAnimate',
		'ngResource',
		'ui.bootstrap',
	])
	.controller('mainController', ['$scope', '$rootScope', '$window', 'modalService', function ($scope, $rootScope, $window, modalService) {

		$scope.user = {};

		$scope.logout = function () {
			modalService.showConfirmModal({
				text: 'Вы уверены что хотите выйти?',
				title: 'Выход'
			}).then(function () {
				$window.location = '#/login';
				$scope.user = {};
			})
		};

		$scope.login = function () {
			$scope.user.name = $scope.user.login;
			$window.location = '#/home';
		};


		$scope.$on('$locationChangeSuccess', function (params, route, next) {
			if (next.originalPath !== '/login' && route.originalPath !== '/login') {
				if (!$scope.user.name) {

					$window.location = '#/login';

				}
			}

		});
	}]);

}());