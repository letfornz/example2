﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenLiveWriter.CoreServices {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Exceptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Exceptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenLiveWriter.CoreServices.Exceptions", typeof(Exceptions).Assembly);
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
        ///   Looks up a localized string similar to The specified path ({0}) is invalid.
        /// </summary>
        internal static string SiteStorageException_InvalidPath {
            get {
                return ResourceManager.GetString("SiteStorageException.InvalidPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified RootFile value (&quot;{0}&quot;) is invalid.
        /// </summary>
        internal static string SiteStorageException_InvalidRootFileName {
            get {
                return ResourceManager.GetString("SiteStorageException.InvalidRootFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error accessing manifest for site at {0}.
        /// </summary>
        internal static string SiteStorageException_ManifestAccessError {
            get {
                return ResourceManager.GetString("SiteStorageException.ManifestAccessError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A RootFile was not specified for the site.
        /// </summary>
        internal static string SiteStorageException_NoRootFileSpecified {
            get {
                return ResourceManager.GetString("SiteStorageException.NoRootFileSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error accessing path {0}.
        /// </summary>
        internal static string SiteStorageException_PathAccessError {
            get {
                return ResourceManager.GetString("SiteStorageException.PathAccessError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not locate the path {0}.
        /// </summary>
        internal static string SiteStorageException_PathNotFound {
            get {
                return ResourceManager.GetString("SiteStorageException.PathNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Stream that was written to was not closed prior to attempting to read from it (path = {0}).
        /// </summary>
        internal static string SiteStorageException_StreamNotClosed {
            get {
                return ResourceManager.GetString("SiteStorageException.StreamNotClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error copying site from {0} to {1}.
        /// </summary>
        internal static string SiteStorageException_UnableToCopySite {
            get {
                return ResourceManager.GetString("SiteStorageException.UnableToCopySite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create storage at {0}.
        /// </summary>
        internal static string SiteStorageException_UnableToCreateStorage {
            get {
                return ResourceManager.GetString("SiteStorageException.UnableToCreateStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deleting site at {0}.
        /// </summary>
        internal static string SiteStorageException_UnableToDeleteSite {
            get {
                return ResourceManager.GetString("SiteStorageException.UnableToDeleteSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error moving site from {0} to {1}.
        /// </summary>
        internal static string SiteStorageException_UnableToMoveSite {
            get {
                return ResourceManager.GetString("SiteStorageException.UnableToMoveSite", resourceCulture);
            }
        }
    }
}