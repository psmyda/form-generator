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

        public void SaveNewFormData(FormData formData)
        {
            var formIdParam = new SqlParameter();
            formIdParam.SqlDbType = SqlDbType.Int;
            formIdParam.ParameterName = "@FormId";
            formIdParam.Direction = ParameterDirection.Input;
            formIdParam.Value = formData.FormId;

            var field1Param = new SqlParameter();
            field1Param.SqlDbType = SqlDbType.NVarChar;
            field1Param.ParameterName = "@Field1";
            field1Param.Direction = ParameterDirection.Input;
            field1Param.Value = formData.Field1 == null ? DBNull.Value : (object)formData.Field1;

            var field2Param = new SqlParameter();
            field2Param.SqlDbType = SqlDbType.NVarChar;
            field2Param.ParameterName = "@Field2";
            field2Param.Direction = ParameterDirection.Input;
            field2Param.Value = formData.Field2 == null ? DBNull.Value : (object)formData.Field2;

            var field3Param = new SqlParameter();
            field3Param.SqlDbType = SqlDbType.NVarChar;
            field3Param.ParameterName = "@Field3";
            field3Param.Direction = ParameterDirection.Input;
            field3Param.Value = formData.Field3 == null ? DBNull.Value : (object)formData.Field3;

            var field4Param = new SqlParameter();
            field4Param.SqlDbType = SqlDbType.NVarChar;
            field4Param.ParameterName = "@Field4";
            field4Param.Direction = ParameterDirection.Input;
            field4Param.Value = formData.Field4 == null ? DBNull.Value : (object)formData.Field4;

            var field5Param = new SqlParameter();
            field5Param.SqlDbType = SqlDbType.NVarChar;
            field5Param.ParameterName = "@field5";
            field5Param.Direction = ParameterDirection.Input;
            field5Param.Value = formData.Field5 == null ? DBNull.Value : (object)formData.Field5;

            var field6Param = new SqlParameter();
            field6Param.SqlDbType = SqlDbType.NVarChar;
            field6Param.ParameterName = "@field6";
            field6Param.Direction = ParameterDirection.Input;
            field6Param.Value = formData.Field6 == null ? DBNull.Value : (object)formData.Field6;

            var field7Param = new SqlParameter();
            field7Param.SqlDbType = SqlDbType.NVarChar;
            field7Param.ParameterName = "@field7";
            field7Param.Direction = ParameterDirection.Input;
            field7Param.Value = formData.Field7 == null ? DBNull.Value : (object)formData.Field7;
            
            var field8Param = new SqlParameter();
            field8Param.SqlDbType = SqlDbType.NVarChar;
            field8Param.ParameterName = "@field8";
            field8Param.Direction = ParameterDirection.Input;
            field8Param.Value = formData.Field8 == null ? DBNull.Value : (object)formData.Field8;

            var field9Param = new SqlParameter();
            field9Param.SqlDbType = SqlDbType.NVarChar;
            field9Param.ParameterName = "@field9";
            field9Param.Direction = ParameterDirection.Input;
            field9Param.Value = formData.Field9 == null ? DBNull.Value : (object)formData.Field9;

            var field10Param = new SqlParameter();
            field10Param.SqlDbType = SqlDbType.NVarChar;
            field10Param.ParameterName = "@field10";
            field10Param.Direction = ParameterDirection.Input;
            field10Param.Value = formData.Field10 == null ? DBNull.Value : (object)formData.Field10;

            var field11Param = new SqlParameter();
            field11Param.SqlDbType = SqlDbType.NVarChar;
            field11Param.ParameterName = "@field11";
            field11Param.Direction = ParameterDirection.Input;
            field11Param.Value = formData.Field11 == null ? DBNull.Value : (object)formData.Field11;

            var field12Param = new SqlParameter();
            field12Param.SqlDbType = SqlDbType.NVarChar;
            field12Param.ParameterName = "@field12";
            field12Param.Direction = ParameterDirection.Input;
            field12Param.Value = formData.Field12 == null ? DBNull.Value : (object)formData.Field12;

            //var field13Param = new SqlParameter();
            //field13Param.SqlDbType = SqlDbType.NVarChar;
            //field13Param.ParameterName = "@field13";
            //field13Param.Direction = ParameterDirection.Input;
            //field13Param.Value = formData.Field13 == null ? DBNull.Value : (object)formData.Field13;

            //var field14Param = new SqlParameter();
            //field14Param.SqlDbType = SqlDbType.NVarChar;
            //field14Param.ParameterName = "@field14";
            //field14Param.Direction = ParameterDirection.Input;
            //field14Param.Value = formData.Field14 == null ? DBNull.Value : (object)formData.Field14;

            //var field15Param = new SqlParameter();
            //field15Param.SqlDbType = SqlDbType.NVarChar;
            //field15Param.ParameterName = "@field15";
            //field15Param.Direction = ParameterDirection.Input;
            //field15Param.Value = formData.Field15 == null ? DBNull.Value : (object)formData.Field15;

            //var field16Param = new SqlParameter();
            //field16Param.SqlDbType = SqlDbType.NVarChar;
            //field16Param.ParameterName = "@field16";
            //field16Param.Direction = ParameterDirection.Input;
            //field16Param.Value = formData.Field16 == null ? DBNull.Value : (object)formData.Field16;

            //var field17Param = new SqlParameter();
            //field17Param.SqlDbType = SqlDbType.NVarChar;
            //field17Param.ParameterName = "@field17";
            //field17Param.Direction = ParameterDirection.Input;
            //field17Param.Value = formData.Field17 == null ? DBNull.Value : (object)formData.Field17;

            //var field18Param = new SqlParameter();
            //field18Param.SqlDbType = SqlDbType.NVarChar;
            //field18Param.ParameterName = "@field18";
            //field18Param.Direction = ParameterDirection.Input;
            //field18Param.Value = formData.Field18 == null ? DBNull.Value : (object)formData.Field18;

            //var field19Param = new SqlParameter();
            //field19Param.SqlDbType = SqlDbType.NVarChar;
            //field19Param.ParameterName = "@field19";
            //field19Param.Direction = ParameterDirection.Input;
            //field19Param.Value = formData.Field19 == null ? DBNull.Value : (object)formData.Field19;

            //var field20Param = new SqlParameter();
            //field20Param.SqlDbType = SqlDbType.NVarChar;
            //field20Param.ParameterName = "@field20";
            //field20Param.Direction = ParameterDirection.Input;
            //field20Param.Value = formData.Field20 == null ? DBNull.Value : (object)formData.Field20;

            //var field21Param = new SqlParameter();
            //field21Param.SqlDbType = SqlDbType.NVarChar;
            //field21Param.ParameterName = "@field21";
            //field21Param.Direction = ParameterDirection.Input;
            //field21Param.Value = formData.Field21 == null ? DBNull.Value : (object)formData.Field21;

            //var field22Param = new SqlParameter();
            //field22Param.SqlDbType = SqlDbType.NVarChar;
            //field22Param.ParameterName = "@field22";
            //field22Param.Direction = ParameterDirection.Input;
            //field22Param.Value = formData.Field22 == null ? DBNull.Value : (object)formData.Field22;

            //var field23Param = new SqlParameter();
            //field23Param.SqlDbType = SqlDbType.NVarChar;
            //field23Param.ParameterName = "@field23";
            //field23Param.Direction = ParameterDirection.Input;
            //field23Param.Value = formData.Field23 == null ? DBNull.Value : (object)formData.Field23;

            //var field24Param = new SqlParameter();
            //field24Param.SqlDbType = SqlDbType.NVarChar;
            //field24Param.ParameterName = "@field24";
            //field24Param.Direction = ParameterDirection.Input;
            //field24Param.Value = formData.Field24 == null ? DBNull.Value : (object)formData.Field24;

            //var field25Param = new SqlParameter();
            //field25Param.SqlDbType = SqlDbType.NVarChar;
            //field25Param.ParameterName = "@field25";
            //field25Param.Direction = ParameterDirection.Input;
            //field25Param.Value = formData.Field25 == null ? DBNull.Value : (object)formData.Field25;

            //var field26Param = new SqlParameter();
            //field26Param.SqlDbType = SqlDbType.NVarChar;
            //field26Param.ParameterName = "@field26";
            //field26Param.Direction = ParameterDirection.Input;
            //field26Param.Value = formData.Field26 == null ? DBNull.Value : (object)formData.Field26;

            //var field27Param = new SqlParameter();
            //field27Param.SqlDbType = SqlDbType.NVarChar;
            //field27Param.ParameterName = "@field27";
            //field27Param.Direction = ParameterDirection.Input;
            //field27Param.Value = formData.Field27 == null ? DBNull.Value : (object)formData.Field27;

            //var field28Param = new SqlParameter();
            //field28Param.SqlDbType = SqlDbType.NVarChar;
            //field28Param.ParameterName = "@field28";
            //field28Param.Direction = ParameterDirection.Input;
            //field28Param.Value = formData.Field28 == null ? DBNull.Value : (object)formData.Field28;

            //var field29Param = new SqlParameter();
            //field29Param.SqlDbType = SqlDbType.NVarChar;
            //field29Param.ParameterName = "@field29";
            //field29Param.Direction = ParameterDirection.Input;
            //field29Param.Value = formData.Field29 == null ? DBNull.Value : (object)formData.Field29;

            //var field30Param = new SqlParameter();
            //field30Param.SqlDbType = SqlDbType.NVarChar;
            //field30Param.ParameterName = "@field30";
            //field30Param.Direction = ParameterDirection.Input;
            //field30Param.Value = formData.Field30 == null ? DBNull.Value : (object)formData.Field30;

            //var field31Param = new SqlParameter();
            //field31Param.SqlDbType = SqlDbType.NVarChar;
            //field31Param.ParameterName = "@field31";
            //field31Param.Direction = ParameterDirection.Input;
            //field31Param.Value = formData.Field31 == null ? DBNull.Value : (object)formData.Field31;

            //var field32Param = new SqlParameter();
            //field32Param.SqlDbType = SqlDbType.NVarChar;
            //field32Param.ParameterName = "@field32";
            //field32Param.Direction = ParameterDirection.Input;
            //field32Param.Value = formData.Field32 == null ? DBNull.Value : (object)formData.Field32;

            _db.Database.ExecuteSqlCommand(
                @"exec [SaveFormData] @FormId, @Field1, @Field2, @Field3, @field4, @field5, @field6, @field7, @field8, @field9, @field10, @field11, @field12",
                formIdParam, field1Param, field2Param, field3Param, field4Param, field5Param, field6Param, field7Param, field8Param, field9Param, field10Param, field11Param, field12Param);
        }
    }

    public interface IFormDataRepository
    {
        IList<FormData> getAllSubmissionsById(int id);
        void SaveNewFormData(FormData formData);
    }
}