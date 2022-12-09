
using Newtonsoft.Json;

public class SearchByTextResponse
{
    public Candidate[] Candidates { get; set; }
    public string Status { get; set; }
}

public class Candidate
{
    [JsonProperty("place_id")]
    public string PlaceId { get; set; }
}
