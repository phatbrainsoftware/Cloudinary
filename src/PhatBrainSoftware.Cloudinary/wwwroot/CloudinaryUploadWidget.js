
export function setCloudinaryCloudName(cloudName) {
    cloudinary.setCloudName(cloudName);
}

var widget;

export function setupCloudinaryUploadWidget(options, instance, callback) {
    widget = cloudinary.createUploadWidget({
        uploadPreset: options.preset,
        sources: options.sources,
        defaultSource: "local",
        cropping: options.allowCropping,
        croppingAspectRatio: options.croppingAspectRatio,
        maxImageWidth: options.maximumImageHeight,
        maxImageHeight: options.maximumImageWidth,
        minImageWidth: options.minImageHeight,
        minImageHeight: options.minImageWidth,
        croppingValidateDimensions: options.validateCroppingDimensions,
        showSkipCropButton: options.showSkipCropButton,
        multiple: false,
        folder: options.folderName,
        tags: options.tags,     
        clientAllowedFormats: options.allowedFormats,
        styles: {
            palette: {
                window: options.theme.windowColor,
                sourceBg: options.theme.backgroundColor,
                windowBorder: options.theme.windowBorderColor,
                tabIcon: options.theme.tabIconColor,
                inactiveTabIcon: options.theme.inactiveTabIconColor,
                menuIcons: options.theme.menuIconsColor,
                link: options.theme.linkColor,
                action: options.theme.actionColor,
                inProgress: options.theme.inProgressColor,
                complete: options.theme.completeColor,
                error: options.theme.errorColor,
                textDark: options.theme.darkTextColor,
                textLight: options.theme.lightTextColor,
            },
            fonts: {
                default: null,
                "'Poppins', sans-serif": {
                    url: "https://fonts.googleapis.com/css?family=Poppins",
                    active: true
                }
            }
        }
    }, (error, result) => {
        if (!error && result.event === 'success') {
            instance.invokeMethodAsync(callback, JSON.stringify(result));
        }
    });
}

export function openWidget() {
    widget.open();
}
