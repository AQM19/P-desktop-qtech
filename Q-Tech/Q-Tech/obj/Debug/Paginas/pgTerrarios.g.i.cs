﻿#pragma checksum "..\..\..\Paginas\pgTerrarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "461C384145E2CDE5F6EA978168A6CD76EA2AA663A9A9ACFE880836A7990EC30C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace Q_Tech.Paginas {
    
    
    /// <summary>
    /// pgTerrarios
    /// </summary>
    public partial class pgTerrarios : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Paginas\pgTerrarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTerrarios;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Paginas\pgTerrarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddTerra;
        
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
            System.Uri resourceLocater = new System.Uri("/Q-Tech;component/paginas/pgterrarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Paginas\pgTerrarios.xaml"
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
            this.lvTerrarios = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.AddTerra = ((System.Windows.Controls.Border)(target));
            
            #line 14 "..\..\..\Paginas\pgTerrarios.xaml"
            this.AddTerra.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AddTerra_MouseDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Paginas\pgTerrarios.xaml"
            this.AddTerra.MouseEnter += new System.Windows.Input.MouseEventHandler(this.AddTerra_MouseEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

