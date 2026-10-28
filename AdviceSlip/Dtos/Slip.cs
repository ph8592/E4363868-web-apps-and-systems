using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AdviceSlip.Dtos
{
    public class AdviceSearchResponse
    {
        public List<Slip> Slips { get; set; } = new();
    }
    public class AdviceSlipResponse
    {
        [JsonPropertyName("slip")]
        public Slip? Slip { get; set; }
    }
    public class Slip
    {
        [JsonPropertyName("id")]
        public int SlipId { get; set; } = 0;

        [JsonPropertyName("advice")]
        public string Advice { get; set; } = string.Empty;
    }
}
