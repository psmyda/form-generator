using formsGeneratorWS.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Data.Repositories
{
    public class FormRepository : IFormRepository
    {
        FormGeneratorDBContext _db;


        public FormRepository(FormGeneratorDBContext db)
        {
            _db = db;
        }

        public Form getFormDefinition(int id)
        {
            var idParam = new SqlParameter();
            idParam.SqlDbType = SqlDbType.Int;
            idParam.ParameterName = "@Id";
            idParam.Direction = ParameterDirection.Input;
            idParam.Value = id;

            var form = _db.Database.SqlQuery<Form>(
                @"exec [getFormDefinition] @Id", idParam).FirstOrDefault();

            return form;
        }
    }

    public interface IFormRepository
    {
        Form getFormDefinition(int id);
    }
}