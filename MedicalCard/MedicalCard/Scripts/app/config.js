(function () {
	'use strict';

	angular.module('medicalCardApp')
		.config(['$routeProvider', '$locationProvider',
			function ($routeProvider, $locationProvider) {
				$routeProvider

					.when('/doctors', {
						templateUrl: 'Scripts/app/controllers/doctors/doctors.html',
						controller: 'doctorsController',
					})
					.when('/patients', {
						templateUrl: 'Scripts/app/controllers/patients/patients.html',
						controller: 'patientsController',
					})
					.when('/login', {
						templateUrl: 'Scripts/app/controllers/account/login.html',
						controller: 'loginController',
					})
					.otherwise({
						redirectTo: '/home'
					});
				$locationProvider.html5Mode(false);
			}]);
}());