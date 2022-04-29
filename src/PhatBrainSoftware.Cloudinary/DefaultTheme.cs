namespace PhatBrainSoftware.Cloudinary
{
    public class DefaultTheme : ICloudinaryUploadWidgetTheme
    {
        public string WindowColor { get; set; } = "#ffffff";

        public string BackgroundColor { get; set; } = "#ffffff";

        public string WindowBorderColor { get; set; } = "#757575";

        public string TabIconColor { get; set; } = "#333333";

        public string InactiveTabIconColor { get; set; } = "#757575";

        public string MenuIconsColor { get; set; } = "#333333";

        public string LinkColor { get; set; } = "#0d6efd";

        public string ActionColor { get; set; } = "#0d6efd";

        public string InProgressColor { get; set; } = "#0433ff";

        public string CompleteColor { get; set; } = "#339933";

        public string ErrorColor { get; set; } = "#cc0000";

        public string DarkTextColor { get; set; } = "#333333";

        public string LightTextColor { get; set; } = "#fcfffd";
    }
}