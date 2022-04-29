using System.Text.Json.Serialization;

namespace PhatBrainSoftware.Cloudinary
{
    public class CloudinaryFileUploaded
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("info")]
        public CloudinaryFile File { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl
        {
            get
            {
                if (this.File == null)
                {
                    return null;
                }

                return this.File.Url;
            }
        }

        [JsonPropertyName("thumbnailImageUrl")]
        public string ThumbnailImageUrl
        {
            get
            {
                if (this.File == null)
                {
                    return null;
                }

                return this.File.ThumbnailUrl;
            }
        }
    }
}
