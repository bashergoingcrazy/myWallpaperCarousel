﻿#pragma checksum "..\..\..\..\..\Resources\UserControls\ControlPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E27B080A7EC50B0C67E28FBEAD039C66A70C7807"
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
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using myWallpaperCarousel.Resources.UserControls;


namespace myWallpaperCarousel.Resources.UserControls {
    
    
    /// <summary>
    /// ControlPage
    /// </summary>
    public partial class ControlPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox folderPathTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox intervalTimeInMinutes;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox randomizeCheckBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/myWallpaperCarousel;component/resources/usercontrols/controlpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.folderPathTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 31 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Browse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 32 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Preview_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.intervalTimeInMinutes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.randomizeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            
            #line 53 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Apply_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Stop_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 55 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 56 "..\..\..\..\..\Resources\UserControls\ControlPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

