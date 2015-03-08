(function () {
	'use strict';
	angular.module('medicalCardApp')
		.service('Patients', ['$resource',
			function ($resource) {
				return $resource(
					//url
					'api/patients/:id',
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