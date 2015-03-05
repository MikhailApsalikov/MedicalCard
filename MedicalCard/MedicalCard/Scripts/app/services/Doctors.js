(function () {
	'use strict';
	angular.module('medicalCardApp')
		.service('Doctors', ['$resource',
			function ($resource) {
				return $resource(
					//url
					'api/doctors/:id',
					//defaults params
					null,
					//actions
					{
						update: {
							method: 'PUT'
						}
					});
			}]);
}());