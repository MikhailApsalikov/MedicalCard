(function () {
	'use strict';
	angular.module('medicalCardApp')
	.factory('responseError', ['$injector', '$q', function ($injector, $q) {
		var responseErrorInterceptor = {
			responseError: function (response) {
				var toastService = $injector.get('toastService'),
					deferred = $q.defer();;
				toastService.showHttpErrorToast(response);
				deferred.reject(response);

				return deferred.promise;
			}
		};

		return responseErrorInterceptor;
	}]);
}());