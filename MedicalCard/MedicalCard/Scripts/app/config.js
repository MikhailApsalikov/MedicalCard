(function () {
	'use strict';

	angular.module('medicalCardApp')
		.config(['$routeProvider', '$locationProvider',
			function ($routeProvider, $locationProvider) {
				$routeProvider

					.when('/home', {
						templateUrl: 'Scripts/app/controllers/home/home.html',
						controller: 'homeController',
					})
					.otherwise({
						redirectTo: '/home'
					});
				$locationProvider.html5Mode(false);
			}]);
}());