#pragma checksum "..\..\Uc_Namelist.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73F14FCCF21E62D6A51429E8C24E233647DA802CDA73719BB3DE7DD7EE455D94"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Geburtstagskalender;
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


namespace Geburtstagskalender {
    
    
    /// <summary>
    /// Uc_namelist
    /// </summary>
    public partial class Uc_namelist : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Uc_Namelist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Cc_NameList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Uc_Namelist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LsV_MemberList;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Uc_Namelist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn gvc_Geb;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Uc_Namelist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn gvc_NN;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Uc_Namelist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn gvc_VN;
        
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
            System.Uri resourceLocater = new System.Uri("/Geburtstagskalender;component/uc_namelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Uc_Namelist.xaml"
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
            this.Cc_NameList = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.LsV_MemberList = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\Uc_Namelist.xaml"
            this.LsV_MemberList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LsV_MemberList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gvc_Geb = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.gvc_NN = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.gvc_VN = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

