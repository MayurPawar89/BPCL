using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    class DataAccess : IDisposable
    {
        #region "Constructor & Distructor"

        private bool disposed = false;

        public DataAccess()
        {
            OpenConnection();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        ~DataAccess()
        {
            Dispose(false);
        }

        #endregion "Constructor & Distructor"

        SqlConnection _con;
        #region "Connction"

        public void OpenConnection()
        {
            String _conStr = "";
            _conStr = ConfigurationManager.ConnectionStrings["BPCL"].ConnectionString.ToString();
            _con = new SqlConnection(_conStr);
            _con.Open();

        }

        public void CloseConnection()
        {
            if (_con != null)
            {
                if (_con.State != ConnectionState.Closed)
                {
                    _con.Close();
                }
            }
        }

        #endregion "Connction"

        #region "Insert Update Delete - Stored Procedure"

        public int Execute(string StoredProcedureName, DBParameters Parameters)
        {
            int _result = 0;
            int _counter = 0;
            SqlCommand _sqlcommand = new SqlCommand();
            SqlParameter osqlParameter;

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;


                for (_counter = 0; _counter <= Parameters.Count - 1; _counter++)
                {
                    osqlParameter = new SqlParameter();

                    osqlParameter.ParameterName = Parameters[_counter].ParameterName;
                    osqlParameter.SqlDbType = Parameters[_counter].DataType;
                    osqlParameter.Direction = Parameters[_counter].ParameterDirection;
                    osqlParameter.Value = Parameters[_counter].Value;
                    if (Parameters[_counter].Size != null)
                    {
                        if (Parameters[_counter].Size != 0)
                        {
                            osqlParameter.Size = Parameters[_counter].Size;
                        }
                    }
                    _sqlcommand.Parameters.Add(osqlParameter);
                    osqlParameter = null;
                }

                _result = _sqlcommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            return _result;
        }

        public int Execute(string StoredProcedureName)
        {
            int _result = 0;
            SqlCommand _sqlcommand = new SqlCommand();

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;



                _result = _sqlcommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            return _result;
        }

        public object ExecuteScalar(string StoredProcedureName, DBParameters Parameters)
        {
            object _result = null;
            int _counter = 0;
            SqlCommand _sqlcommand = new SqlCommand();
            SqlParameter osqlParameter;

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                for (_counter = 0; _counter <= Parameters.Count - 1; _counter++)
                {
                    osqlParameter = new SqlParameter();

                    osqlParameter.ParameterName = Parameters[_counter].ParameterName;
                    osqlParameter.SqlDbType = Parameters[_counter].DataType;
                    osqlParameter.Direction = Parameters[_counter].ParameterDirection;
                    osqlParameter.Value = Parameters[_counter].Value;
                    if (Parameters[_counter].Size != null)
                    {
                        if (Parameters[_counter].Size != 0)
                        {
                            osqlParameter.Size = Parameters[_counter].Size;
                        }
                    }
                    _sqlcommand.Parameters.Add(osqlParameter);
                    osqlParameter = null;
                }

                _result = _sqlcommand.ExecuteScalar();

                if (_result == null)
                {
                    _result = "";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }

            return _result;
        }

        public object ExecuteScalar(string StoredProcedureName)
        {
            object _result = null;
            SqlCommand _sqlcommand = new SqlCommand();

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                _result = _sqlcommand.ExecuteScalar();

                if (_result == null)
                {
                    _result = "";
                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }

            return _result;
        }

        #endregion


        #region "Retrive Data - Stored Procedure"

        public void Retrive(string StoredProcedureName, DBParameters Parameters, out SqlDataReader _result)
        {
            //SqlDataReader _result;
            int _counter = 0;
            SqlCommand _sqlcommand = new SqlCommand();
            SqlParameter osqlParameter;
            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                for (_counter = 0; _counter <= Parameters.Count - 1; _counter++)
                {
                    osqlParameter = new SqlParameter();

                    osqlParameter.ParameterName = Parameters[_counter].ParameterName;
                    osqlParameter.SqlDbType = Parameters[_counter].DataType;
                    osqlParameter.Direction = Parameters[_counter].ParameterDirection;
                    osqlParameter.Value = Parameters[_counter].Value;
                    if (Parameters[_counter].Size != null)
                    {
                        if (Parameters[_counter].Size != 0)
                        {
                            osqlParameter.Size = Parameters[_counter].Size;
                        }
                    }

                    _sqlcommand.Parameters.Add(osqlParameter);
                    osqlParameter = null;
                }

                _result = _sqlcommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }

        public void Retrive(string StoredProcedureName, DBParameters Parameters, out DataSet _result)
        {
            //DataSet _result = new DataSet();
            int _counter = 0;
            SqlCommand _sqlcommand = new SqlCommand();
            SqlParameter osqlParameter;

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                for (_counter = 0; _counter <= Parameters.Count - 1; _counter++)
                {
                    osqlParameter = new SqlParameter();

                    osqlParameter.ParameterName = Parameters[_counter].ParameterName;
                    osqlParameter.SqlDbType = Parameters[_counter].DataType;
                    osqlParameter.Direction = Parameters[_counter].ParameterDirection;
                    osqlParameter.Value = Parameters[_counter].Value;
                    if (Parameters[_counter].Size != null)
                    {
                        if (Parameters[_counter].Size != 0)
                        {
                            osqlParameter.Size = Parameters[_counter].Size;
                        }
                    }
                    _sqlcommand.Parameters.Add(osqlParameter);
                    osqlParameter = null;
                }

                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_sqlcommand);

                DataSet _resultinternal = new DataSet();

                //_dataAdapter.Fill(_result);
                _dataAdapter.Fill(_resultinternal);
                _dataAdapter.Dispose();

                _result = _resultinternal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }

        public void Retrive(string StoredProcedureName, DBParameters Parameters, out DataTable _result)
        {
            //DataTable _result = new DataTable();
            int _counter = 0;
            SqlCommand _sqlcommand = new SqlCommand();
            SqlParameter osqlParameter;
            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                for (_counter = 0; _counter <= Parameters.Count - 1; _counter++)
                {
                    osqlParameter = new SqlParameter();

                    osqlParameter.ParameterName = Parameters[_counter].ParameterName;
                    osqlParameter.SqlDbType = Parameters[_counter].DataType;
                    osqlParameter.Direction = Parameters[_counter].ParameterDirection;
                    osqlParameter.Value = Parameters[_counter].Value;
                    if (Parameters[_counter].Size != null)
                    {
                        if (Parameters[_counter].Size != 0)
                        {
                            osqlParameter.Size = Parameters[_counter].Size;
                        }
                    }
                    _sqlcommand.Parameters.Add(osqlParameter);
                    osqlParameter = null;
                }

                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_sqlcommand);
                DataSet _dataset = new DataSet();
                DataTable _resultinternal = new DataTable();

                _dataAdapter.Fill(_dataset);
                if (_dataset.Tables[0] != null)
                {
                    _resultinternal = _dataset.Tables[0];
                }
                _result = _resultinternal;

                _resultinternal.Dispose();
                _dataset.Dispose();
                _dataAdapter.Dispose();


            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }


        // Without Parameters //
        public void Retrive(string StoredProcedureName, out SqlDataReader _result)
        {
            //SqlDataReader _result;
            SqlCommand _sqlcommand = new SqlCommand();

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;


                _result = _sqlcommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }

        public void Retrive(string StoredProcedureName, out DataSet _result)
        {
            //DataSet _result = new DataSet();
            SqlCommand _sqlcommand = new SqlCommand();

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;

                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_sqlcommand);

                DataSet _resultinternal = new DataSet();

                //_dataAdapter.Fill(_result);
                _dataAdapter.Fill(_resultinternal);
                _dataAdapter.Dispose();

                _result = _resultinternal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }

        public void Retrive(string StoredProcedureName, out DataTable _result)
        {
            //DataTable _result = new DataTable();
            SqlCommand _sqlcommand = new SqlCommand();

            try
            {
                _sqlcommand.CommandType = CommandType.StoredProcedure;
                _sqlcommand.CommandText = StoredProcedureName;
                _sqlcommand.Connection = _con;


                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_sqlcommand);
                DataSet _dataset = new DataSet();
                DataTable _resultinternal = new DataTable();

                _dataAdapter.Fill(_dataset);
                if (_dataset.Tables[0] != null)
                {
                    _resultinternal = _dataset.Tables[0];
                }
                _result = _resultinternal;

                _resultinternal.Dispose();
                _dataset.Dispose();
                _dataAdapter.Dispose();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_sqlcommand != null)
                {
                    _sqlcommand.Dispose();
                }
            }
            //return _result;
        }

        #endregion


    }

    public class DBParameter : IDisposable
    {
        private string _parametername;
        private ParameterDirection _parameterdirection;
        private SqlDbType _datatype;
        private object _value;
        private int _size = 0;


        #region "Constructor & Distructor"

        public DBParameter()
        {

        }

        public DBParameter(string parametername, object value, ParameterDirection parameterdirection, SqlDbType datatype, int fieldsize)
        {
            _parametername = parametername;
            _parameterdirection = parameterdirection;
            _datatype = datatype;
            _value = value;
            _size = fieldsize;
        }

        public DBParameter(string parametername, object value, ParameterDirection parameterdirection, SqlDbType datatype)
        {
            _parametername = parametername;
            _parameterdirection = parameterdirection;
            _datatype = datatype;
            _value = value;
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        ~DBParameter()
        {
            Dispose(false);
        }

        #endregion

        public string ParameterName
        {
            get { return _parametername; }
            set { _parametername = value; }
        }

        public ParameterDirection ParameterDirection
        {
            get { return _parameterdirection; }
            set { _parameterdirection = value; }
        }

        public SqlDbType DataType
        {
            get { return _datatype; }
            set { _datatype = value; }
        }

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

    }

    public class DBParameters : IDisposable
    {
        protected ArrayList _innerlist;

        #region "Constructor & Destructor"

        public DBParameters()
        {
            _innerlist = new ArrayList();
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }


        ~DBParameters()
        {
            Dispose(false);
        }
        #endregion


        public int Count
        {
            get { return _innerlist.Count; }
        }

        public void Add(DBParameter item)
        {
            _innerlist.Add(item);
        }

        public int Add(string parametername, object value, ParameterDirection parameterdirection, SqlDbType datatype, int fieldsize)
        {
            DBParameter item = new DBParameter(parametername, value, parameterdirection, datatype, fieldsize);
            return _innerlist.Add(item);
        }

        public int Add(string parametername, object value, ParameterDirection parameterdirection, SqlDbType datatype)
        {
            DBParameter item = new DBParameter(parametername, value, parameterdirection, datatype);
            return _innerlist.Add(item);
        }

        public bool Remove(DBParameter item)
        {
            bool result = false;
            DBParameter obj;

            for (int i = 0; i < _innerlist.Count; i++)
            {
                //store current index being checked
                obj = new DBParameter();
                obj = (DBParameter)_innerlist[i];
                if (obj.ParameterName == item.ParameterName && obj.DataType == item.DataType)
                {
                    _innerlist.RemoveAt(i);
                    result = true;
                    break;
                }
                obj = null;
            }

            return result;
        }

        public bool RemoveAt(int index)
        {
            bool result = false;
            _innerlist.RemoveAt(index);
            result = true;
            return result;
        }

        public void Clear()
        {
            _innerlist.Clear();
        }

        public DBParameter this[int index]
        {
            get
            {
                return (DBParameter)_innerlist[index];
            }
        }

        public bool Contains(DBParameter item)
        {
            return _innerlist.Contains(item);
        }

        public int IndexOf(DBParameter item)
        {
            return _innerlist.IndexOf(item);
        }

        public void CopyTo(DBParameter[] array, int index)
        {
            _innerlist.CopyTo(array, index);
        }

    }

    public class DataOperation
    {
        DataAccess dbAccess = null;

        public DataOperation()
        {

        }

        public DataTable GetGender()
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            try
            {
                query_procedure_name = "gsp_GetGender";
                dbAccess.Retrive(query_procedure_name, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "Gender";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
            }

            return dt;
        }

        public DataTable GetTehsil()
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            try
            {
                query_procedure_name = "gsp_GetTehsil";
                dbAccess.Retrive(query_procedure_name, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "Tehsil";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
            }

            return dt;
        }

        public DataTable GetGrampanchayat(string tehsilName)
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            DBParameters dbParameters = new DBParameters();
            try
            {
                query_procedure_name = "gsp_GetGRAMPANCHAYAT";
                dbParameters.Add("@TEHSILNAME", tehsilName, ParameterDirection.Input, SqlDbType.VarChar);
                //using (DbCommand dbCommand = sqlDb.GetStoredProcCommand(query_procedure_name))
                //{
                //    sqlDb.AddInParameter(dbCommand, "@TEHSILNAME", DbType.String, tehsilName);
                //    ds = sqlDb.ExecuteDataSet(dbCommand);

                //    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                //    {
                //        dt = ds.Tables[0];
                //        dt.TableName = "Grampanchayat";
                //    }
                //}
                dbAccess.Retrive(query_procedure_name, dbParameters, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "Grampanchayat";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
                if (dbParameters != null) { dbParameters.Dispose(); dbParameters = null; }
            }

            return dt;
        }

        public DataTable GetTown(string tehsilName, string grampanchayatName)
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            DBParameters dbParameters = new DBParameters();
            try
            {
                query_procedure_name = "gsp_GetTown";
                dbParameters.Add("@TEHSILNAME", tehsilName, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@GRAMPANCHAYATNAME", grampanchayatName, ParameterDirection.Input, SqlDbType.VarChar);
                //using (DbCommand dbCommand = sqlDb.GetStoredProcCommand(query_procedure_name))
                //{
                //    sqlDb.AddInParameter(dbCommand, "@TEHSILNAME", DbType.String, tehsilName);
                //    sqlDb.AddInParameter(dbCommand, "@GRAMPANCHAYATNAME", DbType.String, grampanchayatName);

                //    ds = sqlDb.ExecuteDataSet(dbCommand);

                //    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                //    {
                //        dt = ds.Tables[0];
                //        dt.TableName = "Town";
                //    }
                //}
                dbAccess.Retrive(query_procedure_name, dbParameters, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "Town";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
                if (dbParameters != null) { dbParameters.Dispose(); dbParameters = null; }
            }

            return dt;
        }

        public DataTable SearchPerson(string tehsilName, string grampanchayatName, string townName, string gender, string namesearchString, string namesearchString_P2, string namesearchString_P3, string fathernamesearchString, string mothernamesearchString, string ahl_tintextsearchString, string searchWith)
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            DBParameters dbParameters = new DBParameters();
            try
            {
                query_procedure_name = "gsp_Search";
                dbParameters.Add("@TEHSILNAME", tehsilName, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@GRAMPANCHAYATNAME", grampanchayatName, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@TOWNNAME", townName, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@GENDERID", gender, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@NameSearchString", namesearchString, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@NameSearchString_P2", namesearchString_P2, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@NameSearchString_P3", namesearchString_P3, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@FatherNameSearchString", fathernamesearchString, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@MotherNameSearchString", mothernamesearchString, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@AHL_TINSearchString", ahl_tintextsearchString, ParameterDirection.Input, SqlDbType.VarChar);
                //dbParameters.Add("@NPR_TINSearchString", npr_tinsearchString, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@SearchWith", searchWith, ParameterDirection.Input, SqlDbType.VarChar);

                //using (DbCommand dbCommand = sqlDb.GetStoredProcCommand(query_procedure_name))
                //{

                //    //@TEHSILNAME  NVARCHAR(255) = NULL,
                //    //@GRAMPANCHAYATNAME  NVARCHAR(255) = NULL,
                //    //@TOWNNAME  NVARCHAR(255) = NULL,
                //    //@GENDERID  NVARCHAR(255) = NULL,
                //    //@NameSearchString  VARCHAR(255) = NULL,
                //    //@NameSearchString_P2  VARCHAR(255) = NULL,
                //    //@NameSearchString_P3  VARCHAR(255) = NULL,
                //    //@FatherNameSearchString  VARCHAR(255) = NULL,
                //    //@MotherNameSearchString  VARCHAR(255) = NULL

                //    sqlDb.AddInParameter(dbCommand, "@TEHSILNAME", DbType.String, tehsilName);
                //    sqlDb.AddInParameter(dbCommand, "@GRAMPANCHAYATNAME", DbType.String, grampanchayatName);
                //    sqlDb.AddInParameter(dbCommand, "@TOWNNAME", DbType.String, townName);
                //    sqlDb.AddInParameter(dbCommand, "@GENDERID", DbType.String, gender);
                //    sqlDb.AddInParameter(dbCommand, "@NameSearchString", DbType.String, namesearchString);
                //    sqlDb.AddInParameter(dbCommand, "@NameSearchString_P2", DbType.String, namesearchString_P2);
                //    sqlDb.AddInParameter(dbCommand, "@NameSearchString_P3", DbType.String, namesearchString_P3);
                //    sqlDb.AddInParameter(dbCommand, "@FatherNameSearchString", DbType.String, fathernamesearchString);
                //    sqlDb.AddInParameter(dbCommand, "@MotherNameSearchString", DbType.String, mothernamesearchString);
                //    sqlDb.AddInParameter(dbCommand, "@AHL_TINSearchString", DbType.String, ahl_tintextsearchString);
                //    //sqlDb.AddInParameter(dbCommand, "@NPR_TINSearchString", DbType.String, npr_tinsearchString);
                //    sqlDb.AddInParameter(dbCommand, "@SearchWith", DbType.String, searchWith);

                //    ds = sqlDb.ExecuteDataSet(dbCommand);

                //    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                //    {
                //        dt = ds.Tables[0];
                //        dt.TableName = "SearchResult";
                //    }
                //}

                dbAccess.Retrive(query_procedure_name, dbParameters, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "SearchResult";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
                if (dbParameters != null) { dbParameters.Dispose(); dbParameters = null; }
            }

            return dt;
        }

        public DataTable GetPersonDetails(string tehsilName, string ahl_tin)
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            DBParameters dbParameters = new DBParameters();
            try
            {
                query_procedure_name = "gsp_GetPeronDetails";
                dbParameters.Add("@TEHSILNAME", tehsilName, ParameterDirection.Input, SqlDbType.VarChar);
                dbParameters.Add("@AHL_TIN", ahl_tin, ParameterDirection.Input, SqlDbType.VarChar);
                //using (DbCommand dbCommand = sqlDb.GetStoredProcCommand(query_procedure_name))
                //{
                //    sqlDb.AddInParameter(dbCommand, "@TEHSILNAME", DbType.String, tehsilName);
                //    sqlDb.AddInParameter(dbCommand, "@AHL_TIN", DbType.String, ahl_tin);

                //    ds = sqlDb.ExecuteDataSet(dbCommand);

                //    if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                //    {
                //        dt = ds.Tables[0];
                //        dt.TableName = "PersonDetail";
                //    }
                //}

                dbAccess.Retrive(query_procedure_name, dbParameters, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "PersonDetail";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
                if (dbParameters != null) { dbParameters.Dispose(); dbParameters = null; }
            }

            return dt;
        }

        public DataTable GetProductKey()
        {
            DataSet ds = null;
            DataTable dt = null;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            try
            {
                query_procedure_name = "gsp_GetProductKey";

                dbAccess.Retrive(query_procedure_name, out ds);
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dt.TableName = "Key";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ds != null) { if (ds.Tables != null) { ds.Tables.Clear(); } ds.Dispose(); ds = null; }
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
            }

            return dt;
        }
        public bool InsertProductKey(string sProductKey)
        {
            bool _result = false;
            string query_procedure_name = string.Empty;
            dbAccess = new DataAccess();
            DBParameters dbParameters = new DBParameters();
            try
            {
                query_procedure_name = "gsp_InsertProductKey";

                dbParameters.Add("@ProductKey", sProductKey, ParameterDirection.Input, SqlDbType.VarChar);
                //using (DbCommand dbCommand = sqlDb.GetStoredProcCommand(query_procedure_name))
                //{
                //    sqlDb.AddInParameter(dbCommand, "@ProductKey", DbType.String, sProductKey);
                //    //ds = sqlDb.ExecuteDataSet(dbCommand);
                //    int n = sqlDb.ExecuteNonQuery(dbCommand);

                //    if (n > 0)
                //        _result = true;
                //    else
                //        _result = false;
                //}
                int n = dbAccess.Execute(query_procedure_name, dbParameters);
                if (n > 0)
                    _result = true;
                else
                    _result = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dbAccess != null) { dbAccess.Dispose(); dbAccess = null; }
                if (dbParameters != null) { dbParameters.Dispose(); dbParameters = null; }
            }

            return _result;
        }
    }
}
