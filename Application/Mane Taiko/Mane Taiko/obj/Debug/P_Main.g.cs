#pragma checksum "..\..\P_Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BD4E5DEEBC596D0852BF0734A4400812934095710661414AE08394AA308B2D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mane_Taiko;
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


namespace Mane_Taiko {
    
    
    /// <summary>
    /// P_Main
    /// </summary>
    public partial class P_Main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label A_Label;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label B_Label;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label C_Label;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label D_Label;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ConnectLabel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingBTN;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\P_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RST_BTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Mane Taiko;component/p_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\P_Main.xaml"
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
            
            #line 8 "..\..\P_Main.xaml"
            ((Mane_Taiko.P_Main)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\P_Main.xaml"
            ((Mane_Taiko.P_Main)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.A_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.B_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.C_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.D_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ConnectLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.SettingBTN = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\P_Main.xaml"
            this.SettingBTN.Click += new System.Windows.RoutedEventHandler(this.SettingBTN_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RST_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\P_Main.xaml"
            this.RST_BTN.Click += new System.Windows.RoutedEventHandler(this.RST_BTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

