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

    $scope.formData = [];

    NancyAPI.getFormDefinition(id).then(
      function(data) {
        $scope.safeHtml = $sce.trustAsHtml(data.FormCode);
      }
    );

    NancyAPI.getFormData(id).then(
      function(data) {
        $scope.formData = data;
      }
    );

    $scope.saveFormDataToDb = function (){
      var dataObject = {
        id: 0,
        formId: $routeParams.formId,
        field1: $scope.formData.field1,
        field2: $scope.formData.field2,
        field3: $scope.formData.field3,
        field4: $scope.formData.field4,
        field5: $scope.formData.field5,
        field6: $scope.formData.field6,
        field7: $scope.formData.field7
      }

      NancyAPI.saveFormData(dataObject);
    }


  });
