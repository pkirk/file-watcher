﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileWatcherUtilities.Options.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileWatcherUtilities.Options.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Value must be between 10 and 1000..
        /// </summary>
        internal static string ArgumentExceptionInvalidLogMessageValue {
            get {
                return ResourceManager.GetString("ArgumentExceptionInvalidLogMessageValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is null..
        /// </summary>
        internal static string ArgumentNullException {
            get {
                return ResourceManager.GetString("ArgumentNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to autoStartup.
        /// </summary>
        internal static string ColumnAutoStartup {
            get {
                return ResourceManager.GetString("ColumnAutoStartup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to logMessages.
        /// </summary>
        internal static string ColumnLogMessages {
            get {
                return ResourceManager.GetString("ColumnLogMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to processBatchSize.
        /// </summary>
        internal static string ColumnProcessBatchSize {
            get {
                return ResourceManager.GetString("ColumnProcessBatchSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to runQueuedProcesses.
        /// </summary>
        internal static string ColumnRunQueuedProcesses {
            get {
                return ResourceManager.GetString("ColumnRunQueuedProcesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to synchronousExecution.
        /// </summary>
        internal static string ColumnSynchronousExecution {
            get {
                return ResourceManager.GetString("ColumnSynchronousExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fWatcherOptions.
        /// </summary>
        internal static string DatasetName {
            get {
                return ResourceManager.GetString("DatasetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found..
        /// </summary>
        internal static string FileNotFoundException {
            get {
                return ResourceManager.GetString("FileNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to applicationOptions.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
    }
}
