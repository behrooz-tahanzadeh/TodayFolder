﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ir.btapp.NxTodayFolder {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class UserOption : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserOption defaultInstance = ((UserOption)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserOption())));
        
        public static UserOption Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("J")]
        public string DATE_TYPE {
            get {
                return ((string)(this["DATE_TYPE"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yy-MM-dd")]
        public string DATE_FORMAT {
            get {
                return ((string)(this["DATE_FORMAT"]));
            }
        }
    }
}