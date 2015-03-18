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

		$scope.slides = [
			{
				image: '/Content/Images/slider1.jpg',
				text: 'Новейшее оборудование'
			},
			{
				image: '/Content/Images/slider2.jpg',
				text: 'Команда квалифицированных специалистов'
			}
		];

		$scope.$on('$routeChangeSuccess', function (params, route, next) {
			if ($window.location !== '#/login' && $window.location.hash !== '#/register') {
					if (!$scope.user.name) {

						$window.location = '#/login';

					}
				}


		});
	}]);

}());