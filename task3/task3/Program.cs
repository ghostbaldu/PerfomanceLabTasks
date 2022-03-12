using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                var tests = JsonConvert.DeserializeObject<JsonStruct>(File.ReadAllText(args[0]));

                var values = JsonConvert.DeserializeObject<JsonStruct>(File.ReadAllText(args[1]));

                for (int i = 0; i < values.Values.Count; i++)
                {
                    GetAllValues(tests.Tests, values.Values[i].Id, values.Values[i].Value);
                }

                File.WriteAllText(@"..\task3\report.json", JsonConvert.SerializeObject(tests, Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                }));

                Console.WriteLine("Complete...");
            }
            else
            {
                Console.WriteLine("args.Length != 2");
            }
        }

        public static void GetAllValues(List<MenuItems> menuItems, int id, string value)
        {
            foreach (MenuItems item in menuItems)
            {
                if (item.Values != null) GetAllValues(item.Values, id, value);
                if (item != null && item.Id == id)
                {
                    item.Value = value;
                    break;
                }
            }
        }
    }
}
