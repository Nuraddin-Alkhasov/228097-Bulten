﻿#pragma checksum "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA6ECBD7564E8AA9F72964D69D78C0298684D9C1B03C1ACF4AB7ABE82015D7EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HMI.Resources.UserControls.MO;
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


namespace HMI.Resources.UserControls.MO {
    
    
    /// <summary>
    /// MV_TM
    /// </summary>
    public partial class MV_TM : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid A;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Mani;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PictureBox ManiPosition;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HMI.Resources.UserControls.MO.MVTray Tray;
        
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
            System.Uri resourceLocater = new System.Uri("/228097-Bulten;component/main/resources/user%20controls/mo/station/mv_tm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 5 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
            ((HMI.Resources.UserControls.MO.MV_TM)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.A = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Mani = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ManiPosition = ((VisiWin.Controls.PictureBox)(target));
            return;
            case 5:
            this.Tray = ((HMI.Resources.UserControls.MO.MVTray)(target));
            return;
            case 6:
            
            #line 27 "..\..\..\..\..\..\..\..\Main\Resources\User Controls\MO\Station\MV_TM.xaml"
            ((VisiWin.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

