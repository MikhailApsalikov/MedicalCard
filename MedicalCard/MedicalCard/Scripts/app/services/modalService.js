(function () {
	'use strict';

	angular.module('medicalCardApp')
		.service('modalService', ['$modal', '$rootScope',
			function ($modal, $rootScope) {
				var service = {};

				service.showConfirmModal = function (params) {

					var modalInstance,
						scope = $rootScope.$new(),
						options = {
							templateUrl: '/Scripts/app/shared/modals/confirm.html',
							backdrop: 'static',
							scope: scope
						};

					scope.ok = function () {
						modalInstance.close();
					};

					scope.cancel = function () {
						modalInstance.dismiss();
					};

					scope = angular.extend(scope, params);

					modalInstance = $modal.open(options);
					return modalInstance.result;

				};


				return service;
			}]);
}());