using formsGeneratorWS.Data.Models;
using formsGeneratorWS.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace formsGeneratorWS.Modules
{
    public class FormDefinitionModule : NancyModule
    {
        public FormDefinitionModule(IFormDefinitionRepository _repo)
            :base("/form")
        {
            Get["/{id}"] = parameters =>
                {
                    int id = parameters.id;

                    return Response.AsJson<object>(_repo.getFormDefinition(id));
                };

            Get["/all/{userId}"] = parameters =>
                {
                    int userId = parameters.userId;

                    return Response.AsJson<object>(_repo.getAllFormDefinitionsForUser(userId));
                };

            Post["/"] = parameters =>
                {
                    FormDefinition model = this.Bind<FormDefinition>();

                    var newId = _repo.saveFormDefinition(model);

                    return Response.AsJson<object>(_repo.getFormDefinition(newId));
                };
            Get["/delete/{id}"] = parameters =>
                {
                    int id = parameters.id;

                    var newId = _repo.deleteFormDefinition(id);

                    return Response.AsJson(HttpStatusCode.OK);
                };
        }
    }
}