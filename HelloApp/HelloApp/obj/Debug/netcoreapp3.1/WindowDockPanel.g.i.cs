﻿#pragma checksum "..\..\..\WindowDockPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94A56E688209D49D00ED040387E93C851AFC8E9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HelloApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HelloApp {
    
    
    /// <summary>
    /// WindowDockPanel
    /// </summary>
    public partial class WindowDockPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CB1;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNumberTwo;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup testPopup;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MessageButton;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\WindowDockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HelloApp;component/windowdockpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowDockPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 33 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 37 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CB1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 57 "..\..\..\WindowDockPanel.xaml"
            this.CB1.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\WindowDockPanel.xaml"
            this.CB1.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\WindowDockPanel.xaml"
            this.CB1.Indeterminate += new System.Windows.RoutedEventHandler(this.CheckBox_Indeterminate);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 83 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonNumberTwo = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.testPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.MessageButton = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\WindowDockPanel.xaml"
            this.MessageButton.Click += new System.Windows.RoutedEventHandler(this.MessageButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.button1 = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\WindowDockPanel.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 187 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.Expander)(target)).Expanded += new System.Windows.RoutedEventHandler(this.Expander_Expanded);
            
            #line default
            #line hidden
            
            #line 188 "..\..\..\WindowDockPanel.xaml"
            ((System.Windows.Controls.Expander)(target)).Collapsed += new System.Windows.RoutedEventHandler(this.Expander_Collapsed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

