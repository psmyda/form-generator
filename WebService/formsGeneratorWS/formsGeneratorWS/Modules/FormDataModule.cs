﻿using formsGeneratorWS.Data.Models;
using formsGeneratorWS.Data.Repositories;
using Nancy;
using Nancy.ModelBinding;
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
            Get["/all/{id}"] = parameters =>
                {
                    int id = parameters.id;

                    return Response.AsJson<object>(_repo.getAllSubmissionsById(id));
                };

            Get["/{id}"] = parameters =>
            {
                int id = parameters.id;

                return Response.AsJson<object>(_repo.getSubmissionById(id));
            };

            Post["/"] = parameters =>
                {
                    FormData model = this.Bind<FormData>();

                    var newId = _repo.saveFormData(model);

                    return Response.AsJson(_repo.getSubmissionById(newId));
                };

            Get["/delete/{id}"] = parameters =>
            {
                int id = parameters.id;

                var newId = _repo.deleteFormData(id);

                return Response.AsJson(HttpStatusCode.OK);
            };
        }
        
    }
}