﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F3D9BB6B276F7280361063DC5CCE856B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using VisualGGPK.Properties;


namespace VisualGGPK {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu treeView1ContextMenu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemExport;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemReplace;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gridSplitter1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxOutput;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextOutput;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rainParticles;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox skillEffects;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox monsterSounds;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox charSounds;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox portalSounds;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chargeSounds;
        
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
            System.Uri resourceLocater = new System.Uri("/VisualGGPK;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 6 "..\..\..\MainWindow.xaml"
            ((VisualGGPK.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\MainWindow.xaml"
            ((VisualGGPK.MainWindow)(target)).Drop += new System.Windows.DragEventHandler(this.Window_Drop_1);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\MainWindow.xaml"
            ((VisualGGPK.MainWindow)(target)).PreviewDrop += new System.Windows.DragEventHandler(this.Window_PreviewDrop_1);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\MainWindow.xaml"
            ((VisualGGPK.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.treeView1 = ((System.Windows.Controls.TreeView)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.treeView1.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.treeView1_SelectedItemChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.treeView1.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.treeView1_MouseDoubleClick_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.treeView1ContextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.menuItemExport = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.menuItemExport.Click += new System.Windows.RoutedEventHandler(this.menuItemExport_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.menuItemReplace = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.menuItemReplace.Click += new System.Windows.RoutedEventHandler(this.menuItemReplace_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridSplitter1 = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 7:
            this.textBoxOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.richTextOutput = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 9:
            this.rainParticles = ((System.Windows.Controls.CheckBox)(target));
            
            #line 45 "..\..\..\MainWindow.xaml"
            this.rainParticles.Checked += new System.Windows.RoutedEventHandler(this.RainParticles);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\MainWindow.xaml"
            this.rainParticles.Unchecked += new System.Windows.RoutedEventHandler(this.RainParticles);
            
            #line default
            #line hidden
            return;
            case 10:
            this.skillEffects = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.skillEffects.Checked += new System.Windows.RoutedEventHandler(this.SkillEffects);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.skillEffects.Unchecked += new System.Windows.RoutedEventHandler(this.SkillEffects);
            
            #line default
            #line hidden
            return;
            case 11:
            this.monsterSounds = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.monsterSounds.Checked += new System.Windows.RoutedEventHandler(this.MonsterSounds);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.monsterSounds.Unchecked += new System.Windows.RoutedEventHandler(this.MonsterSounds);
            
            #line default
            #line hidden
            return;
            case 12:
            this.charSounds = ((System.Windows.Controls.CheckBox)(target));
            
            #line 48 "..\..\..\MainWindow.xaml"
            this.charSounds.Checked += new System.Windows.RoutedEventHandler(this.CharSounds);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\MainWindow.xaml"
            this.charSounds.Unchecked += new System.Windows.RoutedEventHandler(this.CharSounds);
            
            #line default
            #line hidden
            return;
            case 13:
            this.portalSounds = ((System.Windows.Controls.CheckBox)(target));
            
            #line 49 "..\..\..\MainWindow.xaml"
            this.portalSounds.Checked += new System.Windows.RoutedEventHandler(this.PortalSounds);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow.xaml"
            this.portalSounds.Unchecked += new System.Windows.RoutedEventHandler(this.PortalSounds);
            
            #line default
            #line hidden
            return;
            case 14:
            this.chargeSounds = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.chargeSounds.Checked += new System.Windows.RoutedEventHandler(this.ChargeSounds);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.chargeSounds.Unchecked += new System.Windows.RoutedEventHandler(this.ChargeSounds);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

