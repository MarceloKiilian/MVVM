﻿

#pragma checksum "C:\Projetos\CalculadoraUniversal\CalculadoraUniversal\CalculadoraUniversal.Windows\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6035DE62FAE54076A33F37445C82330"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculadoraUniversal
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 41 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).LostFocus += this.amountTextBox_LostFocus;
                 #line default
                 #line hidden
                #line 42 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.billAmountTextBox_TextChanged;
                 #line default
                 #line hidden
                #line 43 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.amountTextBox_GotFocus;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 53 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RadioButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 58 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RadioButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 62 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RadioButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


