// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Web App stack runtimes. </summary>
    public partial class WebAppRuntimes
    {
        /// <summary> Initializes a new instance of WebAppRuntimes. </summary>
        internal WebAppRuntimes()
        {
        }

        /// <summary> Initializes a new instance of WebAppRuntimes. </summary>
        /// <param name="linuxRuntimeSettings"> Linux-specific settings associated with the minor version. </param>
        /// <param name="windowsRuntimeSettings"> Windows-specific settings associated with the minor version. </param>
        /// <param name="linuxContainerSettings"> Linux-specific settings associated with the Java container minor version. </param>
        /// <param name="windowsContainerSettings"> Windows-specific settings associated with the Java container minor version. </param>
        internal WebAppRuntimes(WebAppRuntimeSettings linuxRuntimeSettings, WebAppRuntimeSettings windowsRuntimeSettings, LinuxJavaContainerSettings linuxContainerSettings, WindowsJavaContainerSettings windowsContainerSettings)
        {
            LinuxRuntimeSettings = linuxRuntimeSettings;
            WindowsRuntimeSettings = windowsRuntimeSettings;
            LinuxContainerSettings = linuxContainerSettings;
            WindowsContainerSettings = windowsContainerSettings;
        }

        /// <summary> Linux-specific settings associated with the minor version. </summary>
        public WebAppRuntimeSettings LinuxRuntimeSettings { get; }
        /// <summary> Windows-specific settings associated with the minor version. </summary>
        public WebAppRuntimeSettings WindowsRuntimeSettings { get; }
        /// <summary> Linux-specific settings associated with the Java container minor version. </summary>
        public LinuxJavaContainerSettings LinuxContainerSettings { get; }
        /// <summary> Windows-specific settings associated with the Java container minor version. </summary>
        public WindowsJavaContainerSettings WindowsContainerSettings { get; }
    }
}
