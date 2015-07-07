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

    $scope.formData = [];

      console.log($routeParams.formId);

    var id = 1;


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
        Id: 0,
        FormId: 1,
        field1: $scope.formNewData.Field1,
        Field2: $scope.formNewData.Field2,
        Field3: $scope.formNewData.Field3,
        Field4: $scope.formNewData.Field4,
        Field5: $scope.formNewData.Field5,
        Field6: $scope.formNewData.Field6,
        Field7: $scope.formNewData.Field7
      };

      console.log(dataObject);

      NancyAPI.saveFormData(dataObject).then(function(result){
        console.log("zapisane z id: ");
        console.log(result.id);
        $scope.formData.push(result);
      });
    }


  });
