using Microsoft.JSInterop;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhatBrainSoftware.Cloudinary
{
    public partial class CloudinaryUploadWidget : IAsyncDisposable
    {
        private IJSRuntime JSRuntime { get; set; }

        public string Id { get; private set; }

        public CloudinaryUploadWidgetOptions Options { get; set; }

        protected IJSObjectReference Module { get; set; }

        public delegate void UploadCompletedCallBack(CloudinaryFileUploaded result);

        private UploadCompletedCallBack _uploadCompletedCallBack;

        public CloudinaryUploadWidget(IJSRuntime jsRuntime)
        {
            this.Id = Guid.NewGuid().ToString();
            this.JSRuntime = jsRuntime;
        }

        public async Task CreateAsync(
            CloudinaryUploadWidgetOptions options)
        {
            this.Options = options;

            this.Module = await this.JSRuntime.InvokeAsync<IJSObjectReference>("import", $"./_content/{typeof(CloudinaryUploadWidget).Namespace}/CloudinaryUploadWidget.js");

            await this.Module.InvokeVoidAsync("setCloudinaryCloudName", this.Options.CloudName);

            await this.Module.InvokeVoidAsync("setupCloudinaryUploadWidget", this.Options, DotNetObjectReference.Create(this), "UploadComplete");
        }

        public async Task OpenWidgetAsync()
        {
            await this.Module.InvokeVoidAsync("openWidget");
        }

        public async Task OpenWidgetAsync(
            UploadCompletedCallBack uploadCompletedCallBack)
        {
            _uploadCompletedCallBack = uploadCompletedCallBack;

            await this.Module.InvokeVoidAsync("openWidget");
        }

        [JSInvokable]
        public void UploadComplete(
            string response)
        {
            Console.WriteLine(response);

            var cloudinaryFileUploaded =
                JsonSerializer.Deserialize<CloudinaryFileUploaded>(response);

            if (_uploadCompletedCallBack != null)
            {
                _uploadCompletedCallBack(cloudinaryFileUploaded);
            }
        }

        [SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize", Justification = "<Pending>")]
        public async ValueTask DisposeAsync()
        {
            if (this.Module is not null)
            {
                await this.Module.DisposeAsync();
            }
        }
    }
}
