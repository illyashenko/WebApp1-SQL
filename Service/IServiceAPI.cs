using System.Collections.Generic;


namespace WebApp._1С.SQL.Service
{
    public interface IServiceAPI
    {
        public List<dynamic> GetData(JSONParametrs Request);
    }
}
