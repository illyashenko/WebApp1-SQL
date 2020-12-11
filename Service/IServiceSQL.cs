using System.Collections.Generic;


namespace WebApp._1С.SQL.Service
{
    public interface IServiceSQL
    {
        public List<dynamic> SendRequest(JSONParametrs TextRequest);
    }
}
