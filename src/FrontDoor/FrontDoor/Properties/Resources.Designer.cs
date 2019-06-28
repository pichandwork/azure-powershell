﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.FrontDoor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.FrontDoor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Create Front Door?.
        /// </summary>
        internal static string CreateFrontDoor {
            get {
                return ResourceManager.GetString("CreateFrontDoor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Rules Engine {0}?.
        /// </summary>
        internal static string CreateRulesEngine {
            get {
                return ResourceManager.GetString("CreateRulesEngine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create WebApplicationFirewallPolicy?.
        /// </summary>
        internal static string CreateWebApplicationFirewallPolicy {
            get {
                return ResourceManager.GetString("CreateWebApplicationFirewallPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable HTTPS for a custom domain?.
        /// </summary>
        internal static string DisableCustomDomainHttpsWarning {
            get {
                return ResourceManager.GetString("DisableCustomDomainHttpsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable HTTPS for a custom domain?.
        /// </summary>
        internal static string EnableCustomDomainHttpsWarning {
            get {
                return ResourceManager.GetString("EnableCustomDomainHttpsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already an existing Front Door with name &apos;{0}&apos; in the resource group &apos;{1}&apos;.
        /// </summary>
        internal static string Error_CreateExistingFrontDoor {
            get {
                return ResourceManager.GetString("Error_CreateExistingFrontDoor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already an existing Rules Engine with name &apos;{0}&apos; in the Front Door &apos;{1}&apos;.
        /// </summary>
        internal static string Error_CreateExistingRulesEngine {
            get {
                return ResourceManager.GetString("Error_CreateExistingRulesEngine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already an existing WAF policy with name &apos;{0}&apos; in the resource group &apos;{1}&apos;..
        /// </summary>
        internal static string Error_CreateExistingWebApplicationFirewallPolicy {
            get {
                return ResourceManager.GetString("Error_CreateExistingWebApplicationFirewallPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebApplicationFirewallPolicy with name &apos;{0}&apos; in the resource group &apos;{1}&apos; does not exist..
        /// </summary>
        internal static string Error_DeleteNonExistingWebApplicationFirewallPolicy {
            get {
                return ResourceManager.GetString("Error_DeleteNonExistingWebApplicationFirewallPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error response received. Error Message: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_ErrorResponseFromServer {
            get {
                return ResourceManager.GetString("Error_ErrorResponseFromServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Front Door with name &apos;{0}&apos; in the resource group &apos;{1}&apos; does not exist..
        /// </summary>
        internal static string Error_FrontDoorNotFound {
            get {
                return ResourceManager.GetString("Error_FrontDoorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid resource id - {0}.
        /// </summary>
        internal static string Error_InvalidResourceId {
            get {
                return ResourceManager.GetString("Error_InvalidResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Front Door with name &apos;{0}&apos; in the resource group &apos;{1}&apos; does not exist..
        /// </summary>
        internal static string Error_NonExistingFrontDoor {
            get {
                return ResourceManager.GetString("Error_NonExistingFrontDoor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebApplicationFirewallPolicy with name &apos;{0}&apos; in the resource group &apos;{1}&apos; does not exist..
        /// </summary>
        internal static string Error_WebApplicationFirewallPolicyNotFound {
            get {
                return ResourceManager.GetString("Error_WebApplicationFirewallPolicyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Front Door &apos;{0}&apos;.
        /// </summary>
        internal static string FrontDoorChangeWarning {
            get {
                return ResourceManager.GetString("FrontDoorChangeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current context.
        /// </summary>
        internal static string FrontDoorTarget {
            get {
                return ResourceManager.GetString("FrontDoorTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purge Contents?.
        /// </summary>
        internal static string PurgeFrontDoor {
            get {
                return ResourceManager.GetString("PurgeFrontDoor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Front Door?.
        /// </summary>
        internal static string RemoveFrontDoor {
            get {
                return ResourceManager.GetString("RemoveFrontDoor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove WebApplicationFirewallPolicy?.
        /// </summary>
        internal static string RemoveWebApplicationFirewallPolicy {
            get {
                return ResourceManager.GetString("RemoveWebApplicationFirewallPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current context.
        /// </summary>
        internal static string RulesEngineTarget {
            get {
                return ResourceManager.GetString("RulesEngineTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating WebApplicationFirewallPolicy &apos;{0}&apos;.
        /// </summary>
        internal static string WebApplicationFirewallPolicyChangeWarning {
            get {
                return ResourceManager.GetString("WebApplicationFirewallPolicyChangeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current context.
        /// </summary>
        internal static string WebApplicationFirewallPolicyTarget {
            get {
                return ResourceManager.GetString("WebApplicationFirewallPolicyTarget", resourceCulture);
            }
        }
    }
}
