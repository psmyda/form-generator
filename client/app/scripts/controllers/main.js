'use strict';

/**
 * @ngdoc function
 * @name clientApp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of the clientApp
 */
app
  .controller('MainCtrl', function ($scope, $routeParams, NancyAPI, $sce) {

      console.log($routeParams.formId);

    var id = $routeParams.formId;

    NancyAPI.getFormDefinition(id).then(
      function(data) {
        $scope.safeHtml = $sce.trustAsHtml(data.FormHtml);
      }
    );

    NancyAPI.getFormData(id).then(
      function(data) {
        $scope.formData = data;
      }
    );


  });
