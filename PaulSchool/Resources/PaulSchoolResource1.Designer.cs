﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaulSchool.Resources {
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
    public class PaulSchoolResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PaulSchoolResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PaulSchool.Resources.PaulSchoolResource", typeof(PaulSchoolResource).Assembly);
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
        ///   Looks up a localized string similar to absent.
        /// </summary>
        public static string Absent_Text {
            get {
                return ResourceManager.GetString("Absent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current password is incorrect or the new password is invalid..
        /// </summary>
        public static string AccountController_ChangePassword_The_current_password_is_incorrect_or_the_new_password_is_invalid_ {
            get {
                return ResourceManager.GetString("AccountController_ChangePassword_The_current_password_is_incorrect_or_the_new_pas" +
                        "sword_is_invalid_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user name or password provided is incorrect..
        /// </summary>
        public static string AccountController_LogOn_The_user_name_or_password_provided_is_incorrect_ {
            get {
                return ResourceManager.GetString("AccountController_LogOn_The_user_name_or_password_provided_is_incorrect_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to present.
        /// </summary>
        public static string Present_Text {
            get {
                return ResourceManager.GetString("Present_Text", resourceCulture);
            }
        }
    }
}
