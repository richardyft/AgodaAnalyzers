//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agoda.Analyzers.AgodaCustom {
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
    public class CustomRulesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomRulesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Agoda.Analyzers.AgodaCustom.CustomRulesResources", typeof(CustomRulesResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access dependencies in a resolver-agnostic way.
        /// </summary>
        public static string AG0001Description {
            get {
                return ResourceManager.GetString("AG0001Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access dependencies in a resolver-agnostic way.
        /// </summary>
        public static string AG0001MessageFormat {
            get {
                return ResourceManager.GetString("AG0001MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use DependencyResolver directly.
        /// </summary>
        public static string AG0001Title {
            get {
                return ResourceManager.GetString("AG0001Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test only the public surface of your API.
        /// </summary>
        public static string AG0002Description {
            get {
                return ResourceManager.GetString("AG0002Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test only the public surface of your API.
        /// </summary>
        public static string AG0002MessageFormat {
            get {
                return ResourceManager.GetString("AG0002MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not test private methods.
        /// </summary>
        public static string AG0002Title {
            get {
                return ResourceManager.GetString("AG0002Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pass only the fields that are actually needed, not the entire HttpContext instance.
        /// </summary>
        public static string AG0003Description {
            get {
                return ResourceManager.GetString("AG0003Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pass only the fields that are actually needed, not the entire HttpContext instance.
        /// </summary>
        public static string AG0003MessageFormat {
            get {
                return ResourceManager.GetString("AG0003MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not pass HttpContext as method argument.
        /// </summary>
        public static string AG0003Title {
            get {
                return ResourceManager.GetString("AG0003Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string AG0004Description {
            get {
                return ResourceManager.GetString("AG0004Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method is blocking on async code which can cause threadpool starvation..
        /// </summary>
        public static string AG0004MessageFormat {
            get {
                return ResourceManager.GetString("AG0004MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t Mix Blocking and Async.
        /// </summary>
        public static string AG0004Title {
            get {
                return ResourceManager.GetString("AG0004Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test method names must follow convention.
        /// </summary>
        public static string AG0005Title {
            get {
                return ResourceManager.GetString("AG0005Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class should have only one public constructor.
        /// </summary>
        public static string AG0006Title {
            get {
                return ResourceManager.GetString("AG0006Title", resourceCulture);
            }
        }

        /// <summary>
        /// Ensure test method contains at least one assertion
        /// </summary>
        public static string AG0012Title
        {
            get
            {
                return ResourceManager.GetString("AG0012Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Prevent use of dynamic.
        /// </summary>
        public static string AG0030Title {
            get {
                return ResourceManager.GetString("AG0030Title", resourceCulture);
            }
        }
    }
}
