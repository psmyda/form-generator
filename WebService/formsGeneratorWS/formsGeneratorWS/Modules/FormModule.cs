using formsGeneratorWS.Data.Models;
using formsGeneratorWS.Data.Repositories;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Modules
{
    public class FormModule : NancyModule
    {
        public FormModule(IFormRepository _repo)
            :base("/form")
        {
            Get["/{id}"] = parameters =>
                {
                    int id = parameters.id;

                    return Response.AsJson<object>(_repo.getFormDefinition(id));
                };
        }
    }
}