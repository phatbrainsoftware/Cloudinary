# Introduction

https://www.meziantou.net/publishing-a-self-contained-blazor-component-razor-css-js-as-a-nuget-package.htm

Build the nuget package.

Navigate to the folder containing the `PhatBrainSoftware.Cloudinary.csproj` file.

```bash
dotnet pack --configuration Release

dotnet nuget push bin/Release/PhatBrainSoftware.Cloudinary.1.0.0.nupkg --api-key "<your api key>" --source https://api.nuget.org/v3/index.json
```

## Links

* [Cloudinary Upload API References](https://cloudinary.com/documentation/image_upload_api_reference)
* [Cloudinary Upload Widget Sandbox](https://codesandbox.io/s/upload-widget-74ggb)