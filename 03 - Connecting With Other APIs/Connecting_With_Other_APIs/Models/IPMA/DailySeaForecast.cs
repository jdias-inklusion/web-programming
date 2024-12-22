using System.Text.Json.Serialization;

namespace Connecting_With_Other_APIs.Models.IPMA;

public class DailySeaForecast
{
    [JsonPropertyName("owner")]
    public string owner { get; set; }

    [JsonPropertyName("country")]
    public string country { get; set; }

    [JsonPropertyName("forecastDate")]
    public string forecastDate { get; set; }

    [JsonPropertyName("data")]
    public List<Datum> data { get; set; }

    [JsonPropertyName("dataUpdate")]
    public DateTime dataUpdate { get; set; }
}

public class Datum
{
    [JsonPropertyName("wavePeriodMin")]
    public string wavePeriodMin { get; set; }

    [JsonPropertyName("globalIdLocal")]
    public int globalIdLocal { get; set; }

    [JsonPropertyName("totalSeaMax")]
    public double totalSeaMax { get; set; }

    [JsonPropertyName("waveHighMax")]
    public string waveHighMax { get; set; }

    [JsonPropertyName("waveHighMin")]
    public string waveHighMin { get; set; }

    [JsonPropertyName("longitude")]
    public string longitude { get; set; }

    [JsonPropertyName("wavePeriodMax")]
    public string wavePeriodMax { get; set; }

    [JsonPropertyName("latitude")]
    public string latitude { get; set; }

    [JsonPropertyName("totalSeaMin")]
    public double totalSeaMin { get; set; }

    [JsonPropertyName("sstMax")]
    public string sstMax { get; set; }

    [JsonPropertyName("predWaveDir")]
    public string predWaveDir { get; set; }

    [JsonPropertyName("sstMin")]
    public string sstMin { get; set; }
}