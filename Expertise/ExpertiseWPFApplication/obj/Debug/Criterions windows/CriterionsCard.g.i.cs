﻿#pragma checksum "..\..\..\Criterions windows\CriterionsCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D7E98E4D67D7ED70B8F02D34F5580BBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ExpertiseWPFApplication;
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


namespace ExpertiseWPFApplication {
    
    
    /// <summary>
    /// CriterionsCard
    /// </summary>
    public partial class CriterionsCard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblWait;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbIndex;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgValues;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gUOM;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxUOM;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblNameCategory;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Criterions windows\CriterionsCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ExpertiseWPFApplication;component/criterions%20windows/criterionscard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Criterions windows\CriterionsCard.xaml"
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
            this.tblWait = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.gGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.tbxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbIndex = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\Criterions windows\CriterionsCard.xaml"
            this.cmbIndex.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbIndex_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgValues = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.gUOM = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.tbxUOM = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tblNameCategory = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Criterions windows\CriterionsCard.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Criterions windows\CriterionsCard.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

