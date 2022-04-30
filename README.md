# Introduction

Cloudinary for Blazor applications - Uses [Cloudinary](https://cloudinary.com).

## Getting Setup

You can install the package via the NuGet package manager just search for PhatBrainSoftware.Cloudinary. You can also install via powershell using the following command.

```ps
Install-Package PhatBrainSoftware.Cloudinary
```

Or via the dotnet CLI.

```bash
dotnet add package PhatBrainSoftware.Cloudinary
```

If you're using Visual Studio you can also install via the built in NuGet package manager.

Add the following to `index.html`:

```html
    <script src="https://upload-widget.cloudinary.com/global/all.js" type="text/javascript"></script>
```

Add the following to `_Imports.razor`:

```cs
@using PhatBrainSoftware.Cloudinary
```

Add the following to `Program.cs`:

```cs
builder.Services.AddTransient(sp => new CloudinaryUploadWidget(sp.GetService<IJSRuntime>()));
```

### Basic Example

See code in the [Index.razor](samples/src/BlazorWebAssembly/Pages/Index.razor) page in the repo for more examples.

```cs
@page "/"

@inject IConfiguration Configuration

<button class="btn btn-primary" type="submit" @onclick="@OnUploadClick">Upload</button>

@code {
    [Inject]
    CloudinaryUploadWidget CloudinaryUploadWidget { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var cloudinaryUploadWidgetOptions =
            new CloudinaryUploadWidgetOptions
                {
                    CloudName = this.Configuration["CLOUDINARY_CLOUD_NAME"],
                    Folder = "test",
                    Sources = new[] { "local", "url", "camera" },
                    CroppingAspectRatio = 1,
                    MaximumImageHeight = 200,
                    MaximumImageWidth = 200
                };

        await this.CloudinaryUploadWidget.CreateAsync(cloudinaryUploadWidgetOptions);
    }

    protected async Task OnUploadClick(
        MouseEventArgs mouseEventArgs)
    {
        await this.CloudinaryUploadWidget.OpenWidgetAsync();
    }
}
```
