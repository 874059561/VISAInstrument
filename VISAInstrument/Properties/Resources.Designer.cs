﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VISAInstrument.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VISAInstrument.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 http://www.cnc6.cn 的本地化字符串。
        /// </summary>
        internal static string BlogURL {
            get {
                return ResourceManager.GetString("BlogURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关闭 的本地化字符串。
        /// </summary>
        internal static string CloseString {
            get {
                return ResourceManager.GetString("CloseString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 命令不能为空！ 的本地化字符串。
        /// </summary>
        internal static string CommandNotEmpty {
            get {
                return ResourceManager.GetString("CommandNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 检测成功！ 的本地化字符串。
        /// </summary>
        internal static string DetectOK {
            get {
                return ResourceManager.GetString("DetectOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/cnxy/VISAInstrument 的本地化字符串。
        /// </summary>
        internal static string GithubURL {
            get {
                return ResourceManager.GetString("GithubURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 LAN地址已经包含该IP，请重新输入！ 的本地化字符串。
        /// </summary>
        internal static string LANContainIP {
            get {
                return ResourceManager.GetString("LANContainIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 【正在加载GPIB资源中...请稍候...】 的本地化字符串。
        /// </summary>
        internal static string LoadingGPIB {
            get {
                return ResourceManager.GetString("LoadingGPIB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正在加载仪器资源，请等待加载完毕后再关闭此程序！ 的本地化字符串。
        /// </summary>
        internal static string LoadingInstrumentResource {
            get {
                return ResourceManager.GetString("LoadingInstrumentResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 【正在加载LAN资源中...请稍候...】 的本地化字符串。
        /// </summary>
        internal static string LoadingLAN {
            get {
                return ResourceManager.GetString("LoadingLAN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 【正在加载RS232资源中...请稍候...】 的本地化字符串。
        /// </summary>
        internal static string LoadingRS232 {
            get {
                return ResourceManager.GetString("LoadingRS232", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 【正在加载USB资源中...请稍候...】 的本地化字符串。
        /// </summary>
        internal static string LoadingUSB {
            get {
                return ResourceManager.GetString("LoadingUSB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 VISAInstrument 的本地化字符串。
        /// </summary>
        internal static string MutexName {
            get {
                return ResourceManager.GetString("MutexName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不是正确的IP地址，请重新输入！ 的本地化字符串。
        /// </summary>
        internal static string NotCorrectIP {
            get {
                return ResourceManager.GetString("NotCorrectIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没有检测到有效的仪器IP地址，请重新输入！ 的本地化字符串。
        /// </summary>
        internal static string NotDetectIP {
            get {
                return ResourceManager.GetString("NotDetectIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 打开 的本地化字符串。
        /// </summary>
        internal static string OpenString {
            get {
                return ResourceManager.GetString("OpenString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 读取时间超时 的本地化字符串。
        /// </summary>
        internal static string ReadTimeout {
            get {
                return ResourceManager.GetString("ReadTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 程序已经在运行！ 的本地化字符串。
        /// </summary>
        internal static string Running {
            get {
                return ResourceManager.GetString("Running", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 运行时错误 的本地化字符串。
        /// </summary>
        internal static string RuntimeError {
            get {
                return ResourceManager.GetString("RuntimeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 加载VISA32错误，请保证已经安装VISA32运行时！ 的本地化字符串。
        /// </summary>
        internal static string VISA32Error {
            get {
                return ResourceManager.GetString("VISA32Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/cnxy/VISAInstrument/releases/download/1.0.0.1/VISAInstrument-1.0.0.1.exe 的本地化字符串。
        /// </summary>
        internal static string VISA32URL {
            get {
                return ResourceManager.GetString("VISA32URL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 点击“是”从弹出的网址进行下载并安装。 的本地化字符串。
        /// </summary>
        internal static string VISADownLoad {
            get {
                return ResourceManager.GetString("VISADownLoad", resourceCulture);
            }
        }
    }
}
