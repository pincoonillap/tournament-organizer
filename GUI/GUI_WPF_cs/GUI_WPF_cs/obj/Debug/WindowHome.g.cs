﻿#pragma checksum "..\..\WindowHome.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35B95206588B01EEE31A2DEB59233CC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
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


namespace GUI_WPF_cs {
    
    
    /// <summary>
    /// WindowHome
    /// </summary>
    public partial class WindowHome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Button buttonHome;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Button buttonNew;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Button buttonOpen;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Label labelTournamentOrganizer;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Label labelCSC470;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Border borderNTO;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Label labelOptions;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Border borderOTO;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Label labelOpen;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Image image2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.Label labelProgress;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowHome.xaml"
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI_WPF_cs;component/windowhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowHome.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonHome = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\WindowHome.xaml"
            this.buttonHome.Click += new System.Windows.RoutedEventHandler(this.buttonHome_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonNew = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.buttonOpen = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.labelTournamentOrganizer = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labelCSC470 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.borderNTO = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.labelOptions = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.borderOTO = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            this.labelOpen = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.image2 = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            this.labelProgress = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
