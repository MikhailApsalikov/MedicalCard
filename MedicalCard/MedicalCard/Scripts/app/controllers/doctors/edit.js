(function () {
	'use strict';

	angular.module('medicalCardApp')
		.controller('editController', ['$scope', '$modalInstance',
			function ($scope, $modalInstance) {

				$scope.format = 'dd.MM.yyyy';
				$scope.open = function ($event) {
					$event.preventDefault();
					$event.stopPropagation();

					$scope.opened = true;
				};

				$scope.save = function () {
					$modalInstance.close($scope.doctor);
				};

				$scope.cancel = function () {
					$modalInstance.dismiss();
				};
			}]);
}());