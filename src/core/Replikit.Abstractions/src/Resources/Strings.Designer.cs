﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Replikit.Abstractions.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Replikit.Abstractions.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string InvalidIdentifierValue {
            get {
                return ResourceManager.GetString("InvalidIdentifierValue", resourceCulture);
            }
        }
        
        internal static string CustomDataNotFound {
            get {
                return ResourceManager.GetString("CustomDataNotFound", resourceCulture);
            }
        }
        
        internal static string ValueCannotBeDefault {
            get {
                return ResourceManager.GetString("ValueCannotBeDefault", resourceCulture);
            }
        }
        
        internal static string UnsupportedFeatureException {
            get {
                return ResourceManager.GetString("UnsupportedFeatureException", resourceCulture);
            }
        }
        
        internal static string UnexpectedlyUnsupportedFeature {
            get {
                return ResourceManager.GetString("UnexpectedlyUnsupportedFeature", resourceCulture);
            }
        }
        
        internal static string ValueCannotBeNullOrWhiteSpace {
            get {
                return ResourceManager.GetString("ValueCannotBeNullOrWhiteSpace", resourceCulture);
            }
        }
        
        internal static string AttachmentTypeCannotBeUnknown {
            get {
                return ResourceManager.GetString("AttachmentTypeCannotBeUnknown", resourceCulture);
            }
        }
        
        internal static string StreamMustBeReadable {
            get {
                return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
            }
        }
        
        internal static string AdapterForBotNotFound {
            get {
                return ResourceManager.GetString("AdapterForBotNotFound", resourceCulture);
            }
        }
        
        internal static string AdapterForPlatformNotFound {
            get {
                return ResourceManager.GetString("AdapterForPlatformNotFound", resourceCulture);
            }
        }
        
        internal static string NoAdaptersRegistered {
            get {
                return ResourceManager.GetString("NoAdaptersRegistered", resourceCulture);
            }
        }
        
        internal static string AdapterServiceNotImplemented {
            get {
                return ResourceManager.GetString("AdapterServiceNotImplemented", resourceCulture);
            }
        }
    }
}
