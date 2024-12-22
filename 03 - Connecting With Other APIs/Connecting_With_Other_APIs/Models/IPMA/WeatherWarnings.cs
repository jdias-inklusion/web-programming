using System.Text.Json.Serialization;

namespace Connecting_With_Other_APIs.Models.IPMA;

public class WeatherWarnings
{
    [JsonPropertyName("text")]
    public string text { get; set; }

    [JsonPropertyName("awarenessTypeName")]
    public string awarenessTypeName { get; set; }

    [JsonPropertyName("idAreaAviso")]
    public string idAreaAviso { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime startTime { get; set; }

    [JsonPropertyName("awarenessLevelID")]
    public string awarenessLevelID { get; set; }

    [JsonPropertyName("endTime")]
    public DateTime endTime { get; set; }
}