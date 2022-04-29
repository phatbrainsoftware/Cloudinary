using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PhatBrainSoftware.Cloudinary
{
    public partial class CloudinaryImage
    {
        [Parameter]
        public string CloudName { get; set; }

        [Parameter]
        public string PublicId { get; set; }

        [Parameter]
        public string FolderName { get; set; }

        [Parameter]
        public int? Height { get; set; }

        [Parameter]
        public int? Width { get; set; }

        [Parameter]
        public bool Pad { get; set; }

        [Parameter]
        public string Class { get; set; } = null;

        [Parameter]
        public string BackgroundColor { get; set; } = null;

        [Parameter]
        public bool Rounded { get; set; } = false;

        [Parameter]
        public bool Thumbnail { get; set; } = false;

        public string Url
        {
            get
            {
                var result = "https://res.cloudinary.com";

                result += $"/{this.CloudName}/image/upload";

                var transformations = new List<string>();

                if (this.Thumbnail)
                {
                    transformations.Add("c_thumb");
                }

                if (!string.IsNullOrWhiteSpace(this.BackgroundColor))
                {
                    transformations.Add($"b_{this.BackgroundColor.ToLower()}");
                }

                if (this.Height != null)
                {
                    transformations.Add($"h_{this.Height}");
                }

                if (this.Width != null)
                {
                    transformations.Add($"w_{this.Width}");
                }

                if (this.Pad)
                {
                    transformations.Add("c_pad");
                }

                if (transformations.Any())
                {
                    result += $"/{string.Join(",", transformations)}";
                }

                if (this.Rounded)
                {
                    result += $"/r_max";
                }

                result += $"/{this.PublicId}";

                return result;
            }
        }
    }
}
