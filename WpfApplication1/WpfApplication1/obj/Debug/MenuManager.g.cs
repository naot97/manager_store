﻿#pragma checksum "..\..\MenuManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7F625F3885C6F86382B06F5B4551430C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// MenuManager
    /// </summary>
    public partial class MenuManager : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TinhLuongButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DiemDanhButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SuaNVButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SuaHangButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MenuManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoiPassButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/menumanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TinhLuongButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MenuManager.xaml"
            this.TinhLuongButton.Click += new System.Windows.RoutedEventHandler(this.TinhLuongButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DiemDanhButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MenuManager.xaml"
            this.DiemDanhButton.Click += new System.Windows.RoutedEventHandler(this.DiemDanhButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SuaNVButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MenuManager.xaml"
            this.SuaNVButton.Click += new System.Windows.RoutedEventHandler(this.SuaNVButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SuaHangButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MenuManager.xaml"
            this.SuaHangButton.Click += new System.Windows.RoutedEventHandler(this.SuaHangButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DoiPassButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MenuManager.xaml"
            this.DoiPassButton.Click += new System.Windows.RoutedEventHandler(this.DoiPassButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

