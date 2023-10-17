using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ImageSelect.Models.Configuration
{
    public class Config
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("byJson")]
        public ByJson? ByJson { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mainCss")]
        public string MainCss { get; set; } = "ms-dd";


        [JsonPropertyName("rowHeight")]
        public object? RowHeight { get; set; } = null;


        [JsonPropertyName("visibleRows")]
        public object? VisibleRows { get; set; } = null;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("showIcon")]
        public bool? ShowIcon { get; set; } = true;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("zIndex")]
        public long? ZIndex { get; set; } = 9999;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("event")]
        public string Event { get; set; } = "click";


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("style")]
        public string? Style { get; set; }


        [JsonPropertyName("childWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? ChildWidth { get; set; }


        [JsonPropertyName("childHeight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? ChildHeight { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enableCheckbox")]
        public bool? EnableCheckbox { get; set; } = false;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("checkboxNameSuffix")]
        public string CheckboxNameSuffix { get; set; } = "_mscheck";


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("showPlusItemCounter")]
        public bool? ShowPlusItemCounter { get; set; } = true;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enableAutoFilter")]
        public bool? EnableAutoFilter { get; set; } = true;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("showListCounter")]
        public bool? ShowListCounter { get; set; } = false;


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; } = "Please select an item from this list";


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("on")]
        public On On { get; set; }
    }
}
