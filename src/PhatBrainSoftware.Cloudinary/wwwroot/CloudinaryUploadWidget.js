
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
        showSkipCropButton: options.showSkipCropButton,
        multiple: false,
        folder: options.folder,
        tags: options.tags,     
        clientAllowedFormats: options.allowedFormats,
        resourceType: 'image',
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

//export function setupCloudinaryUploadWidget(preset, handle, sources, instance, callback) {
//    console.log(preset);
//    console.log(handle);
//    console.log(sources);
//    widget = cloudinary.createUploadWidget({
//        uploadPreset: preset,
//        sources: sources,
//        cropping: true,
//        showSkipCropButton: true,
//        multiple: false,
//        folder: handle,
//        tags: ['user', handle],
//        resourceType: 'image',
//        image_file_type: 'jpg',
//    }, (error, result) => {
//        if (!error && result.event === 'success') {
//            instance.invokeMethodAsync(callback, JSON.stringify(result));
//        }
//    });
//}

export function openWidget() {
    widget.open();
}

export function showUploadWidget() {
    cloudinary.openUploadWidget({
        cloudName: "<cloud name>",
        uploadPreset: "<upload preset>",
        sources: [
            "local",
            "url",
            "camera",
            "image_search",
            "google_drive",
            "facebook",
            "dropbox",
            "instagram",
            "unsplash",
            "istock",
            "getty",
            "shutterstock"
        ],
        googleApiKey: "<image_search_google_api_key>",
        showAdvancedOptions: false,
        cropping: true,
        multiple: false,
        defaultSource: "local",
        styles: {
            palette: {
                window: "#ffffff",
                sourceBg: "#FFFFFF",
                windowBorder: "#757575",
                tabIcon: "#000000",
                inactiveTabIcon: "#757575",
                menuIcons: "#333333",
                link: "#1EAAE7",
                action: "#339933",
                inProgress: "#0433ff",
                complete: "#339933",
                error: "#cc0000",
                textDark: "#000000",
                textLight: "#fcfffd"
            },
            fonts: {
                default: null,
                "'Poppins', sans-serif": {
                    url: "https://fonts.googleapis.com/css?family=Poppins",
                    active: true
                }
            }
        }
    },
        (err, info) => {
            if (!err) {
                console.log("Upload Widget event - ", info);
            }
        });
}