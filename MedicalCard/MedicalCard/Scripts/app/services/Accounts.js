(function () {
	'use strict';
	angular.module('medicalCardApp')
		.service('Accounts', ['$resource',
			function ($resource) {
				return $resource(
					//url
					'api/accounts/:id',
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