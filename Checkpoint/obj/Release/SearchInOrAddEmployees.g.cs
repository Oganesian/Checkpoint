﻿#pragma checksum "..\..\SearchInOrAddEmployees.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51F10FB4E1FC201F041D892CF6A3FEB4BA7FA67A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace Checkpoint {
    
    
    /// <summary>
    /// SearchInOrAddEmployees
    /// </summary>
    public partial class SearchInOrAddEmployees : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Passport;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Organization;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ConfirmedByTheOrganization;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\SearchInOrAddEmployees.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchOrAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Checkpoint;component/searchinoraddemployees.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchInOrAddEmployees.xaml"
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
            this.ID = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\SearchInOrAddEmployees.xaml"
            this.ID.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.OnlyDigits);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Passport = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\SearchInOrAddEmployees.xaml"
            this.Passport.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.OnlyDigits);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Organization = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ConfirmedByTheOrganization = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.SearchOrAdd = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\SearchInOrAddEmployees.xaml"
            this.SearchOrAdd.Click += new System.Windows.RoutedEventHandler(this.SearchOrAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
