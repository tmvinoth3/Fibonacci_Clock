﻿#pragma checksum "c:\users\575435\documents\visual studio 2010\Projects\FiboClock\FiboClock\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2277A90962B4B70CC7700BBBB10BDD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36373
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FiboClock {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle two;
        
        internal System.Windows.Shapes.Rectangle onea;
        
        internal System.Windows.Shapes.Rectangle oneb;
        
        internal System.Windows.Shapes.Rectangle three;
        
        internal System.Windows.Shapes.Rectangle five;
        
        internal System.Windows.Controls.Label showTime;
        
        internal System.Windows.Controls.TextBox tbHour;
        
        internal System.Windows.Controls.TextBox tbMinute;
        
        internal System.Windows.Controls.Button Clock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FiboClock;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.two = ((System.Windows.Shapes.Rectangle)(this.FindName("two")));
            this.onea = ((System.Windows.Shapes.Rectangle)(this.FindName("onea")));
            this.oneb = ((System.Windows.Shapes.Rectangle)(this.FindName("oneb")));
            this.three = ((System.Windows.Shapes.Rectangle)(this.FindName("three")));
            this.five = ((System.Windows.Shapes.Rectangle)(this.FindName("five")));
            this.showTime = ((System.Windows.Controls.Label)(this.FindName("showTime")));
            this.tbHour = ((System.Windows.Controls.TextBox)(this.FindName("tbHour")));
            this.tbMinute = ((System.Windows.Controls.TextBox)(this.FindName("tbMinute")));
            this.Clock = ((System.Windows.Controls.Button)(this.FindName("Clock")));
        }
    }
}

