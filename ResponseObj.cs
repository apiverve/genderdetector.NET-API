using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("detected")]
    public bool detected { get; set; }

    [JsonProperty("gender")]
    public string gender { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
