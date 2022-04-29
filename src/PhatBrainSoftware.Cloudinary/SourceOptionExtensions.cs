using System;
using System.Collections.Generic;

namespace PhatBrainSoftware.Cloudinary
{
    public static class SourceOptionExtensions
    {
        public static string ToString(this SourceOption sourceOption)
        {
            return sourceOption switch
            {
                SourceOption.Camera => "camera",
                SourceOption.Facebook => "facebook",
                SourceOption.Getty => "getty",
                SourceOption.Google => "google_drive",
                SourceOption.ImageSearch => "image_search",
                SourceOption.Instagram => "instagram",
                SourceOption.iStock => "istock",
                SourceOption.Local => "local",
                SourceOption.Shutterstock => "shutterstock",
                SourceOption.Unsplash => "unsplash",
                SourceOption.Url => "url",
                _ => throw new NotSupportedException(),
            };
        }

        public static string[] ToString(this SourceOption[] sourceOptions)
        {
            var result = new List<string>();

            foreach (var sourceOption in sourceOptions)
            {
                result.Add(sourceOption.ToString());
            }

            return result.ToArray();
        }
    }
}
