using Microsoft.JSInterop;
using PSC.Blazor.Components.ImageSelect.Models.Configuration;

namespace PSC.Blazor.Components.ImageSelect
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class ImageSelectJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ImageSelectJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/PSC.Blazor.Components.ImageSelect/js/imageselect.js").AsTask());
        }

        public async ValueTask Setup(DotNetObjectReference<ImageSelect> dotNetObjectRef, string id, Config config)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("imageSelectSetup", dotNetObjectRef, id, config);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}