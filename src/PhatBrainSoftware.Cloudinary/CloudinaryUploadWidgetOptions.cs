﻿namespace PhatBrainSoftware.Cloudinary
{
    public class CloudinaryUploadWidgetOptions
    {
        public string CloudName { get; set; }

        public string ApiKey { get; set; }

        public string ApiSecret { get; set; }

        public string Folder { get; set; }

        public string Preset { get; set; } = "default";

        public string[] Tags { get; set; }

        public string[] Sources { get; set; } = new string[] { "local", "url", "camera" };

        public string[] AllowedFormats { get; set; } = new string[] { "png", "jpg", "jpeg", "gif" };

        public ICloudinaryUploadWidgetTheme Theme { get; set; } = new DefaultTheme();

        public bool AllowCropping { get; set; } = true;

        public bool ShowSkipCropButton { get; set; } = true;

        public int? CroppingAspectRatio { get; set; } = null;

        public int? MaximumImageHeight { get; set; } = null;

        public int? MaximumImageWidth { get; set; } = null;
    }
}

