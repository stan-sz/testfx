﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Resources.Reso" +
                            "urce", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find file &apos;{0}&apos;..
        /// </summary>
        internal static string CannotFindFile {
            get {
                return ResourceManager.GetString("CannotFindFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter should not be null or empty..
        /// </summary>
        internal static string Common_CannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("Common_CannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Bad deployment item: &apos;{0}&apos;: output directory &apos;{1}&apos; specifies the item to be deployed outside deployment root directory which is not allowed..
        /// </summary>
        internal static string DeploymentErrorBadDeploymentItem {
            get {
                return ResourceManager.GetString("DeploymentErrorBadDeploymentItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Failed to access output directory &apos;{1}&apos; specified by deployment item &apos;{0}&apos;, the item will not be deployed: {2}: {3}.
        /// </summary>
        internal static string DeploymentErrorFailedToAccesOutputDirectory {
            get {
                return ResourceManager.GetString("DeploymentErrorFailedToAccesOutputDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Failed to access the file &apos;{0}&apos;: {1}: {2}.
        /// </summary>
        internal static string DeploymentErrorFailedToAccessFile {
            get {
                return ResourceManager.GetString("DeploymentErrorFailedToAccessFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Failed to copy file &apos;{0}&apos; to &apos;{1}&apos;: {2}: {3}.
        /// </summary>
        internal static string DeploymentErrorFailedToCopyWithOverwrite {
            get {
                return ResourceManager.GetString("DeploymentErrorFailedToCopyWithOverwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Failed to deploy dependencies for test storage &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string DeploymentErrorFailedToDeployDependencies {
            get {
                return ResourceManager.GetString("DeploymentErrorFailedToDeployDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: Failed to get the file for {0}: {1}: {2}.
        /// </summary>
        internal static string DeploymentErrorFailedToGetFileForDeploymentItem {
            get {
                return ResourceManager.GetString("DeploymentErrorFailedToGetFileForDeploymentItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: an error occurred while getting satellite assemblies for {0}: {1}: {2}.
        /// </summary>
        internal static string DeploymentErrorGettingSatellite {
            get {
                return ResourceManager.GetString("DeploymentErrorGettingSatellite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deployment item &apos;{0}&apos;.
        /// </summary>
        internal static string DeploymentItem {
            get {
                return ResourceManager.GetString("DeploymentItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid deployment item: the specified path &apos;{0}&apos; or output directory &apos;{1}&apos; contains illegal characters..
        /// </summary>
        internal static string DeploymentItemContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("DeploymentItemContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid deployment item: the output directory cannot be null..
        /// </summary>
        internal static string DeploymentItemOutputDirectoryCannotBeNull {
            get {
                return ResourceManager.GetString("DeploymentItemOutputDirectoryCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid deployment item: the specified output directory &apos;{0}&apos; is not relative..
        /// </summary>
        internal static string DeploymentItemOutputDirectoryMustBeRelative {
            get {
                return ResourceManager.GetString("DeploymentItemOutputDirectoryMustBeRelative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid deployment item: the path must contain at least one character..
        /// </summary>
        internal static string DeploymentItemPathCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("DeploymentItemPathCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deployment item &apos;{0}&apos; (output directory &apos;{1}&apos;).
        /// </summary>
        internal static string DeploymentItemWithOutputDirectory {
            get {
                return ResourceManager.GetString("DeploymentItemWithOutputDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSTestAdapter encountered an unexpected element &apos;{0}&apos; in its settings &apos;{1}&apos;. Remove this element and try again..
        /// </summary>
        internal static string InvalidSettingsXmlElement {
            get {
                return ResourceManager.GetString("InvalidSettingsXmlElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value &apos;{0}&apos; for runsettings entry &apos;{1}&apos;, setting will be ignored..
        /// </summary>
        internal static string InvalidValue {
            get {
                return ResourceManager.GetString("InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: The assembly or module &apos;{0}&apos; was not found. Reason: {1}.
        /// </summary>
        internal static string MissingDeploymentDependency {
            get {
                return ResourceManager.GetString("MissingDeploymentDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Run deployment issue: The assembly or module &apos;{0}&apos; was not found..
        /// </summary>
        internal static string MissingDeploymentDependencyWithoutReason {
            get {
                return ResourceManager.GetString("MissingDeploymentDependencyWithoutReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}_{1} {2}.
        /// </summary>
        internal static string TestRunName {
            get {
                return ResourceManager.GetString("TestRunName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data source &apos;{0}&apos; cannot be found in the test configuration settings.
        /// </summary>
        internal static string UTA_DataSourceConfigurationSectionMissing {
            get {
                return ResourceManager.GetString("UTA_DataSourceConfigurationSectionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unit test adapter failed to connect to the data source or to read the data. For more information on troubleshooting this error, see &quot;Troubleshooting Data-Driven Unit Tests&quot; (http://go.microsoft.com/fwlink/?LinkId=62412) in the MSDN Library. Error details: {0}.
        /// </summary>
        internal static string UTA_ErrorDataConnectionFailed {
            get {
                return ResourceManager.GetString("UTA_ErrorDataConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong number of objects for permutation. Should be greater than zero..
        /// </summary>
        internal static string WrongNumberOfObjects {
            get {
                return ResourceManager.GetString("WrongNumberOfObjects", resourceCulture);
            }
        }
    }
}
