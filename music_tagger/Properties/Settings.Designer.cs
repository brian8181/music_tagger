﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace music_tagger.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>File Name,0</string>
  <string>File Path,1</string>
  <string>Size,2</string>
  <string>Attributes,3</string>
  <string>Last Access,4</string>
  <string>Last Write,5</string>
  <string>Created,6</string>
  <string>Track,7</string>
  <string>Artist,8</string>
  <string>Album,9</string>
  <string>Title,10</string>
  <string>Year,11</string>
  <string>Comment,12</string>
  <string>Genre,13</string>
  <string>Lenght,14</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection columns {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["columns"]));
            }
            set {
                this["columns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string last_dir {
            get {
                return ((string)(this["last_dir"]));
            }
            set {
                this["last_dir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool restore_dir {
            get {
                return ((bool)(this["restore_dir"]));
            }
            set {
                this["restore_dir"] = value;
            }
        }
    }
}
