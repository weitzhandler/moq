﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moq.Analyzer.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Moq.Analyzer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Generate all proxies in {0} {1}.
        /// </summary>
        internal static string GenerateProxyCodeFix_FixAllTitle {
            get {
                return ResourceManager.GetString("GenerateProxyCodeFix_FixAllTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate Proxy.
        /// </summary>
        internal static string GenerateProxyCodeFix_Title {
            get {
                return ResourceManager.GetString("GenerateProxyCodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only classes and interfaces can be used in proxies. Invalid set of symbols: {0}..
        /// </summary>
        internal static string InvalidProxyTypes {
            get {
                return ResourceManager.GetString("InvalidProxyTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoked method requires a proxy to be generated at design-time or compile-time..
        /// </summary>
        internal static string MissingProxyAnalyzer_Description {
            get {
                return ResourceManager.GetString("MissingProxyAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A proxy named &apos;{0}&apos; was not found in the current compilation..
        /// </summary>
        internal static string MissingProxyAnalyzer_Message {
            get {
                return ResourceManager.GetString("MissingProxyAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proxy not found.
        /// </summary>
        internal static string MissingProxyAnalyzer_Title {
            get {
                return ResourceManager.GetString("MissingProxyAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing generated proxy is no longer up-to-date..
        /// </summary>
        internal static string OutdatedProxyAnalyzer_Description {
            get {
                return ResourceManager.GetString("OutdatedProxyAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proxy named &apos;{0}&apos; must be updated..
        /// </summary>
        internal static string OutdatedProxyAnalyzer_Message {
            get {
                return ResourceManager.GetString("OutdatedProxyAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proxy must be updated.
        /// </summary>
        internal static string OutdatedProxyAnalyzer_Title {
            get {
                return ResourceManager.GetString("OutdatedProxyAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update all proxies in {0} {1}.
        /// </summary>
        internal static string UpdateProxyCodeFix_FixAllTitle {
            get {
                return ResourceManager.GetString("UpdateProxyCodeFix_FixAllTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Proxy.
        /// </summary>
        internal static string UpdateProxyCodeFix_Title {
            get {
                return ResourceManager.GetString("UpdateProxyCodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one base type can be specified for a proxy to generate and it must be the first type in the list. Invalid set of symbols: {0}..
        /// </summary>
        internal static string WrongProxyBaseType {
            get {
                return ResourceManager.GetString("WrongProxyBaseType", resourceCulture);
            }
        }
    }
}