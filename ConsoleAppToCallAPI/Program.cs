using ConsoleAppToCallAPI.Api;
using ConsoleAppToCallAPI.Client;
using System;

namespace ConsoleAppToCallAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration();
            config.BasePath = "https://csnempapi.azurewebsites.net/";
            EmployeesApi api = new EmployeesApi(config);
            var emps = api.ApiEmployeesGet();

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name+" "+emp.Salary);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
