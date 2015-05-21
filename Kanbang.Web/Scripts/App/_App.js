(function() {
	window.app = app || {};
	window.app.ng = angular.module("app", ["ngAnimate", "ui.bootstrap"])
		.constant("session", { user: app.user })
		.constant("root", { user: app.root })
		.run(["$rootScope", function($rootScope) {
			// Register data in the root scope so that it's easily accesible from all views.
			$rootScope.data = app.data;
		}])
		.config(["$locationProvider", function ($locationProvider) {
			$locationProvider.html5Mode(false);
		}]);
}());