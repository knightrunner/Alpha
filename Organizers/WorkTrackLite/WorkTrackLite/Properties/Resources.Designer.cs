﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkTrackLite.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WorkTrackLite.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Work Track Lite.
        /// </summary>
        internal static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What are you up to?.
        /// </summary>
        internal static string BallonTipText {
            get {
                return ResourceManager.GetString("BallonTipText", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon Clock {
            get {
                object obj = ResourceManager.GetObject("Clock", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string ExitMenuItem {
            get {
                return ResourceManager.GetString("ExitMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program must be restarted for these changes to take effect..
        /// </summary>
        internal static string RestartNeededBySettings {
            get {
                return ResourceManager.GetString("RestartNeededBySettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        internal static string SettingsMenuItem {
            get {
                return ResourceManager.GetString("SettingsMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Track work.
        /// </summary>
        internal static string TrackWorkMenuItem {
            get {
                return ResourceManager.GetString("TrackWorkMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0}.
        /// </summary>
        internal static string VersionFormat {
            get {
                return ResourceManager.GetString("VersionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Work overview.
        /// </summary>
        internal static string WorkOverviewMenuItem {
            get {
                return ResourceManager.GetString("WorkOverviewMenuItem", resourceCulture);
            }
        }
    }
}
