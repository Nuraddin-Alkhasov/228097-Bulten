﻿#pragma checksum "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2627CB1BD95A7C48F06971449B017623EF5F906051E4E24935579A9DC3F19D5C"
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
using VisiWin.Adapter;
using VisiWin.ApplicationFramework;
using VisiWin.Controls;
using VisiWin.Extensions;
using VisiWin.Shapes;


namespace HMI.DialogRegion.Recipes.Views {
    
    
    /// <summary>
    /// Article_Browser
    /// </summary>
    public partial class Article_Browser : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid border;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock HeaderText;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_articles;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image gif;
        
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
            System.Uri resourceLocater = new System.Uri("/228097-Bulten;component/main/regions/dialog/recipes/views/article_browser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Main\Regions\Dialog\Recipes\Views\Article_Browser.xaml"
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
            this.border = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.HeaderText = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 3:
            this.CancelButton = ((VisiWin.Controls.Button)(target));
            return;
            case 4:
            this.dg_articles = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.gif = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
