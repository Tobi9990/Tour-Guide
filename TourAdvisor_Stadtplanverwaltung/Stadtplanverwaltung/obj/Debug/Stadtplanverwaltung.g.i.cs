﻿#pragma checksum "..\..\Stadtplanverwaltung.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8BDE5BF700E450725865BC008D3C13D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace Stadtplanverwaltung {
    
    
    /// <summary>
    /// AdminStadtplanverwaltung
    /// </summary>
    public partial class AdminStadtplanverwaltung : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasMap;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridPoi;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxPoi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridUser;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxUser;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Stadtplanverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHelp;
        
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
            System.Uri resourceLocater = new System.Uri("/Stadtplanverwaltung;component/stadtplanverwaltung.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Stadtplanverwaltung.xaml"
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
            this.canvasMap = ((System.Windows.Controls.Canvas)(target));
            
            #line 6 "..\..\Stadtplanverwaltung.xaml"
            this.canvasMap.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.canvasMap_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridPoi = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.txtBoxPoi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dataGridUser = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.txtBoxUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Stadtplanverwaltung.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Stadtplanverwaltung.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnHelp = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Stadtplanverwaltung.xaml"
            this.btnHelp.Click += new System.Windows.RoutedEventHandler(this.btnHelp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

