﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OptionsPlay.Resources {
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
    public class LogMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LogMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OptionsPlay.Resources.LogMessages", typeof(LogMessages).Assembly);
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
        ///   Looks up a localized string similar to Cron Options is Incorrect for {0}.
        /// </summary>
        public static string Error_CronOptionsIncorrect {
            get {
                return ResourceManager.GetString("Error_CronOptionsIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed Scheduler Job: {0}.
        /// </summary>
        public static string Error_FailedSchedulerJob {
            get {
                return ResourceManager.GetString("Error_FailedSchedulerJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler task type could not be resolved. Implementation for the following task type is not found: &apos;{0}&apos;.
        /// </summary>
        public static string Error_SchedulerTaskTypeNotFound {
            get {
                return ResourceManager.GetString("Error_SchedulerTaskTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler Job: {0} was Started.
        /// </summary>
        public static string Info_StartSchedulerJob {
            get {
                return ResourceManager.GetString("Info_StartSchedulerJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler Task: {0} was Started.
        /// </summary>
        public static string Info_StartSchedulerTask {
            get {
                return ResourceManager.GetString("Info_StartSchedulerTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler Job: {0} was Stopped.
        /// </summary>
        public static string Info_StopSchedulerJob {
            get {
                return ResourceManager.GetString("Info_StopSchedulerJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler Task: {0} was Stopped. Elapsed Time: {1}ms.
        /// </summary>
        public static string Info_StopSchedulerTask {
            get {
                return ResourceManager.GetString("Info_StopSchedulerTask", resourceCulture);
            }
        }
    }
}