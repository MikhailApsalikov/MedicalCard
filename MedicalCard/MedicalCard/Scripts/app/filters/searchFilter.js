(function () {
	'use strict';

	angular.module('medicalCardApp')
		.filter('searchFilter', function () {
			return function (items, query, fields) {
				var searchIn = items,
					result = [];

				if (angular.isString(query) && query.length >= 0 && angular.isArray(fields)) {
					query = query.toLowerCase();
					_.each(fields, function (field) {
						_.each(searchIn, function (item) {
							if (_.contains((item[field] + '').toLowerCase(), query) &&
								!_.some(result, item)) {
								result.push(item);
							}
						});
					});

					return result;
				}
				return items;
			}
		});
}());