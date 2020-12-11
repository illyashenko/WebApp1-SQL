using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace WebApp._1С.SQL.Service
{
    public class ServiceSQL : IServiceSQL
    { 
        public List<dynamic> SendRequest(JSONParametrs Request)
        {
            var Result = new List<dynamic>();

            using (IDbConnection dbConnection = new SqlConnection(Request.ConnectionString))
            { 
                dbConnection.Open();
                Result = dbConnection.Query(Request.StringRequest, null, null, true, Request.TimeOutInSecond).ToList();
            }

            return Result;
        }  
    }
 }
