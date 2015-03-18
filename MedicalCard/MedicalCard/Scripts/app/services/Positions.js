(function () {
	'use strict';
	angular.module('medicalCardApp')
		.service('Positions', ['$resource',
			function ($resource) {
				return $resource(
					//url
					'api/Position',
					//defaults params
					null,
					//actions
					{
					});
			}]);
}());