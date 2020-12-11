using System.Collections.Generic;


namespace WebApp._1С.SQL.Service
{
    public class ServiceAPI : IServiceAPI
    {
        IServiceSQL ServiceSQL;

        public ServiceAPI(IServiceSQL serviceSQL)
        {
            ServiceSQL = serviceSQL;
        }
        public List<dynamic> GetData(JSONParametrs Request)
        {
            if (Request.TimeOutInSecond == 0 
                   || Request.ConnectionString == string.Empty 
                       || Request.StringRequest == string.Empty)
            {
                return null; 
            }
       
            var answer = ServiceSQL.SendRequest(Request);

            return answer;
        }
    }
}
