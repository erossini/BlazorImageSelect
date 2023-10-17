using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ImageSelect.Models.Configuration
{
    /// <summary>
    /// Callback Generic Context
    /// </summary>
    public readonly record struct CallbackGenericContext(int SelectedIndex)
    {
    }
}
