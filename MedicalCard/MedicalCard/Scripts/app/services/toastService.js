(function () {
	'use strict';

	angular.module('medicalCardApp')
		.service('toastService', ['toastr', function (toastr) {
			var service = {},
				options = {
					positionClass: 'toast-bottom-right',
					tapToDismiss: true,
					closeButton: true
				};

			service.showSuccessToast = function (params) {
				var localOptions = angular.extend(options, params);
				toastr.success(localOptions.text, localOptions.title, localOptions);
			};

			service.showErrorToast = function (params) {
				var localOptions = angular.extend(options, params);
				toastr.error(localOptions.text, localOptions.title, localOptions);
			};

			service.showHttpErrorToast = function (response) {
				var localOptions = angular.extend(options, response);
				if (localOptions.status === 400 && localOptions.data.message) {
					toastr.error(localOptions.data.message, 'Ошибка', localOptions);
				} else {
					toastr.error('Во время выполнения операции произошла ошибка.', 'Ошибка', localOptions);
				}
			};

			service.showInfoToast = function (params) {
				var localOptions = angular.extend(options, params);
				toastr.info(localOptions.text, localOptions.title, localOptions);
			};


			return service;
		}]);
}());