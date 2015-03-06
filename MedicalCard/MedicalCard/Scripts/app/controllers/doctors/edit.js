(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('editController', ['$scope', '$modalInstance',
			function ($scope, $modalInstance) {

				$scope.save = function () {
					$modalInstance.close($scope.doctor);
				};

				$scope.cancel = function () {
					$modalInstance.dismiss();
				};
			}]);
}());