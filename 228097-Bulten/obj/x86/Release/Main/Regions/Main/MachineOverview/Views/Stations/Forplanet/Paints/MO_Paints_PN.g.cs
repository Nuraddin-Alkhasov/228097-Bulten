﻿#pragma checksum "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "111838B7B258E7FCC84AFF2B919CACA00B8B6CE02FB38BA22EC61E7EF53FB4F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace HMI.MainRegion.MO.Views {
    
    
    /// <summary>
    /// MO_Paints_PN
    /// </summary>
    public partial class MO_Paints_PN : VisiWin.Controls.View, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.PanoramaNavigation pn_paints;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisiWin.Controls.TextBlock header;
        
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
            System.Uri resourceLocater = new System.Uri("/228097-Bulten;component/main/regions/main/machineoverview/views/stations/forplan" +
                    "et/paints/mo_paints_pn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.pn_paints = ((VisiWin.Controls.PanoramaNavigation)(target));
            return;
            case 3:
            this.header = ((VisiWin.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 24 "..\..\..\..\..\..\..\..\..\..\..\Main\Regions\Main\MachineOverview\Views\Stations\Forplanet\Paints\MO_Paints_PN.xaml"
            ((VisiWin.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

