using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ImageSelect.Models.Configuration
{
    /// <summary>
    /// Class ByJson.
    /// </summary>
    public class ByJson
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        [JsonPropertyName("data")]
        public object Data { get; set; } = null;

        /// <summary>
        /// Gets or sets the index of the selected.
        /// </summary>
        /// <value>The index of the selected.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("selectedIndex")]
        public long? SelectedIndex { get; set; } = 0;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonPropertyName("name")]
        public object Name { get; set; } = null;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("size")]
        public long? Size { get; set; } = 0;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ByJson"/> is multiple.
        /// </summary>
        /// <value><c>null</c> if [multiple] contains no value, <c>true</c> if [multiple]; otherwise, <c>false</c>.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("multiple")]
        public bool? Multiple { get; set; } = false;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("width")]
        public long? Width { get; set; } = 250;
    }
}
