(function () {
	'use strict';

	angular.module('medicalCardApp')
		.filter('positionFilter',  function () {
			return function (position, positions) {
				var role;

				role = _.find(positions, function (item) {
					return item.Id === position;
				})

				return role.Name;

			}
		});
}());