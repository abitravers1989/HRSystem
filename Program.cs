using System;
using Newtonsoft.Json.Linq;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine(manager.GetTotalPension());
            var jArray = new JArray("sdfddfg", 90, "gg");
            Console.WriteLine(jArray[1]);
            var jobject = new JObject(new JProperty("field_source_string", "ggg"), new JProperty(@"[{""field_target_string"": 1,""value"": 2},{""field_target_string"": 4,""value"": 56}]")
            );
            Console.WriteLine(jobject["field_source_string"]);
            //Console.WriteLine(JObject.Parse("dsfdsff"));

        Console.ReadKey();
        }
    }
}
