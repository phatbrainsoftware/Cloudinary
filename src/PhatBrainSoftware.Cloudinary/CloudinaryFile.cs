using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PhatBrainSoftware.Cloudinary
{
    public class CloudinaryFile
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("batchId")]
        public string BatchId { get; set; }

        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("version_id")]
        public string VersionId { get; set; }

        [JsonPropertyName("signature")]
        public string Signature { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("resource_type")]
        public string ResourceType { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("bytes")]
        public int Bytes { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("etag")]
        public string ETag { get; set; }

        [JsonPropertyName("placeholder")]
        public bool Placeholder { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("secure_url")]
        public string SecureUrl { get; set; }

        [JsonPropertyName("access_mode")]
        public string AccessMode { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }
}
