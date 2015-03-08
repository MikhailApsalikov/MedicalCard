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
					.when('/register', {
						templateUrl: 'Scripts/app/controllers/account/register.html',
						controller: 'registerController',
					})
					.otherwise({
						redirectTo: '/home'
					});
				$locationProvider.html5Mode(false);
			}]);
}());