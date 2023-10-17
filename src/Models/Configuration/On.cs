using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ImageSelect.Models.Configuration
{
    public class On
    {
        [JsonPropertyName("create")]
        public object Create { get; set; }

        [JsonPropertyName("open")]
        public object Open { get; set; }

        [JsonPropertyName("close")]
        public object Close { get; set; }

        [JsonPropertyName("add")]
        public object Add { get; set; }

        [JsonPropertyName("remove")]
        public object Remove { get; set; }

        [JsonPropertyName("blur")]
        public object Blur { get; set; }

        [JsonIgnore]
        public Func<CallbackGenericContext, int>? Click { get; set; }

        [JsonPropertyName("dblclick")]
        public object Dblclick { get; set; }

        [JsonPropertyName("mousemove")]
        public object Mousemove { get; set; }

        [JsonPropertyName("mouseover")]
        public object Mouseover { get; set; }

        [JsonPropertyName("mouseout")]
        public object Mouseout { get; set; }

        [JsonPropertyName("focus")]
        public object Focus { get; set; }

        [JsonPropertyName("mousedown")]
        public object Mousedown { get; set; }

        [JsonPropertyName("mouseup")]
        public object Mouseup { get; set; }
    }
}
