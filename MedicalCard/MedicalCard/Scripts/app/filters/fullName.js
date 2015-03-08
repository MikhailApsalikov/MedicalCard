(function () {
	'use strict';

	angular.module('medicalCardApp')
		.filter('fullName', function () {
			return function (person) {
				return person.LastName + ' ' + person.FirstName + ' ' + person.MiddleName;
			}
		});
}());