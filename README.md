# WebApp1-SQL ODBC
SQL запросы из 1С
c# NET.Core 5

HTTP Request:
{
  "stringRequest": "string", // SQL запрос  // ПРИМЕР: "SELECT cl.INN as INN, cl.Email FROM [dbo].[Clients]"
  "connectionString": "string", // строка подключения к SQL серверу // ПРИМЕР: "Server=tcp:127.0.0.1;User=admin;Password=admin;Integrated Security=false"
  "timeOutInSecond": 0 // int в сек. мах ожидание выполнения запроса
}

