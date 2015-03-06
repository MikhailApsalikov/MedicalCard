(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('patientEditController', ['$scope', '$modalInstance',
			function ($scope, $modalInstance) {

				$scope.save = function () {
					$modalInstance.close($scope.patient);
				};

				$scope.cancel = function () {
					$modalInstance.dismiss();
				};
			}]);
}());