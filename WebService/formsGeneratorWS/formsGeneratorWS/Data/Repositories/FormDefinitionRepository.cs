using formsGeneratorWS.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Data.Repositories
{
    public class FormDefinitionRepository : IFormDefinitionRepository
    {
        FormGeneratorDBContext _db;


        public FormDefinitionRepository(FormGeneratorDBContext db)
        {
            _db = db;
        }

        public IList<FormDefinition> getAllFormDefinitionsForUser(int userId)
        {
            var userIdParam = new SqlParameter();
            userIdParam.SqlDbType = SqlDbType.Int;
            userIdParam.ParameterName = "@UserId";
            userIdParam.Direction = ParameterDirection.Input;
            userIdParam.Value = userId;

            var formDefinitions = _db.Database.SqlQuery<FormDefinition>(
                @"exec [getAllFormsForUser] @UserId", userIdParam
                ).ToList();

            return formDefinitions;
        }

        public FormDefinition getFormDefinition(int id)
        {
            var idParam = new SqlParameter();
            idParam.SqlDbType = SqlDbType.Int;
            idParam.ParameterName = "@FormId";
            idParam.Direction = ParameterDirection.Input;
            idParam.Value = id;

            var form = _db.Database.SqlQuery<FormDefinition>(
                @"exec [getFormDefinition] @FormId", idParam).FirstOrDefault();

            return form;
        }

        public int saveFormDefinition(FormDefinition formDefinition)
        {
            var idParam = new SqlParameter();
            idParam.ParameterName = "@Id";
            idParam.SqlDbType = SqlDbType.Int;
            idParam.Direction = ParameterDirection.Input;
            idParam.Value = formDefinition.Id == 0 ? DBNull.Value : (object)formDefinition.Id;

            var ownerIdParam = new SqlParameter();
            ownerIdParam.ParameterName = "@OwnerId";
            ownerIdParam.SqlDbType = SqlDbType.Int;
            ownerIdParam.Direction = ParameterDirection.Input;
            ownerIdParam.Value = formDefinition.OwnerId;

            var formCodeParam = new SqlParameter();
            formCodeParam.ParameterName = "@FormCode";
            formCodeParam.SqlDbType = SqlDbType.Text;
            formCodeParam.Direction = ParameterDirection.Input;
            formCodeParam.Value = formDefinition.FormCode;

            try { 
            var newFormId = _db.Database.SqlQuery<int>(
                @"exec [saveFormDefinition] @Id, @OwnerId, @FormCode",
                idParam, ownerIdParam, formCodeParam).First();

            return newFormId;
                }
            catch (SqlException e)
            {
                return e.ErrorCode;
            }

        }

        public int deleteFormDefinition(int id)
        {
            var idParam = new SqlParameter();
            idParam.ParameterName = "@FormId";
            idParam.SqlDbType = SqlDbType.Int;
            idParam.Direction = ParameterDirection.Input;
            idParam.Value = id;

            _db.Database.ExecuteSqlCommand(
                @"exec [deleteFormDefinition] @FormId", idParam);

            return id;
        }
    }

    public interface IFormDefinitionRepository
    {
        IList<FormDefinition> getAllFormDefinitionsForUser(int userId);
        FormDefinition getFormDefinition(int id);
        int saveFormDefinition(FormDefinition formDefinition);
        int deleteFormDefinition(int id);
    }
}