app.service(
  'NancyAPI', function($timeout, $http) {

    var serviceUrl = 'http://smd-soft.com/formGeneratorWS';


    //form definition API

    this.getFormDefinition = function (formId){
      var url = serviceUrl + '/form/' + formId;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.getAllFormDefinitions = function (userId){
      var url = serviceUrl + '/form/all/' + userId;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.deleteFormDefinition = function (formId){
      var url = serviceUrl + '/form/delete/' + formId;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.saveFormDefinition = function (newFormDefitnion){
      var url = serviceUrl + '/form';

      return $http.post(url, newFormDefitnion).then(
        function(response) {
          return response.data;
        }
      );
    }

    // formData API

    this.getFormData = function (formId){
      var url = serviceUrl + '/formData/all/' + formId;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.getSingleFormData = function (id){
      var url = serviceUrl + '/formData/' + id;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.deleteFormData = function (id){
      var url = serviceUrl + '/formData/delete/' + id;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.saveFormData = function (newData){
      var url = serviceUrl + '/formData';

      return $http.post(url, newData).then(
        function(response) {
          return response.data;
        }
      );
    }

  }
)
