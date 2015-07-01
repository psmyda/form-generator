app.service(
  'NancyAPI', function($timeout, $http) {

    var serviceUrl = 'http://localhost:12008';

    this.getFormDefinition = function (formId){
      var url = serviceUrl + '/form/' + formId;

      return $http.get(url).then(
        function (response) {
          return response.data;
        }
      );
    }

    this.getFormData = function (formId){
      var url = serviceUrl + '/formData/' + formId;

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
