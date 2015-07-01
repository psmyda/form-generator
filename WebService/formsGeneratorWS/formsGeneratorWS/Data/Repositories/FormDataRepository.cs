using formsGeneratorWS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace formsGeneratorWS.Data.Repositories
{
    public class FormDataRepository : IFormDataRepository
    {

        FormGeneratorDBContext _db;


        public FormDataRepository(FormGeneratorDBContext db)
        {
            _db = db;
        }

        public IList<FormData> getAllSubmissionsById(int id)
        {
            var idParam = new SqlParameter();
            idParam.SqlDbType = SqlDbType.Int;
            idParam.ParameterName = "@Id";
            idParam.Direction = ParameterDirection.Input;
            idParam.Value = id;

            var formData = _db.Database.SqlQuery<FormData>(
                @"exec [getFormData] @Id", idParam).ToList();

            return formData;
        }

        // methods

        // getAllFormSubmissions

        // save new formData
    }

    public interface IFormDataRepository
    {
        IList<FormData> getAllSubmissionsById(int id);
    }
}