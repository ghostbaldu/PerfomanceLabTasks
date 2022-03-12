using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace task3
{
    public class JsonStruct
    {
        [JsonProperty("tests")]
        public List<MenuItems> Tests { get; set; }

        [JsonProperty("values")]
        public List<MenuItems> Values { get; set; }
    }

    public class MenuItems
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("values")]
        public List<MenuItems> Values { get; set; }

        public IEnumerator GetEnumerator() => Values.GetEnumerator();
    }
}
