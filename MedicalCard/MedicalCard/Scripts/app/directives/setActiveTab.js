(function () {
	'use strict';

	angular.module('medicalCardApp')
		.directive('setActiveTab', function () {
			return {
				restrict: 'A',
				link: function (scope, element, attrs) {
					scope.$on('$routeChangeSuccess', function (event, next, current) {
						element.find('.active').toggleClass('active', false);
						element.find('a[href="#' + next.originalPath + '"]').closest('li').toggleClass('active').closest('.dropdown').toggleClass('active');
					});
				}
			}
		});
}());