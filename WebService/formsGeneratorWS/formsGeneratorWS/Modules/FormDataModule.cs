using formsGeneratorWS.Data.Repositories;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Modules
{
    public class FormDataModule : NancyModule
    {

        public FormDataModule(IFormDataRepository _repo)
            :base("/formData")
        {
            Get["/{id}"] = parameters =>
                {
                    int id = parameters.id;

                    return Response.AsJson<object>(_repo.getAllSubmissionsById(id));
                };
        }
        
    }
}