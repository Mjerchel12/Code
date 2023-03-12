using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal struct ConfigJSON
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("prefix")]
        public string Prefix { get; set; }
    }
}
