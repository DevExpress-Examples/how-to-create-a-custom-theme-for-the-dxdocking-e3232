using System;
using System.Linq;
using System.Windows.Controls;
using DevExpress.Xpf.Core;

namespace CustomDockingSLTheme {
    public partial class MainPage : UserControl {
        public MainPage() {
            Theme theme = new Theme("CustomTheme") {  IsStandard = false, FullName = "Custom Theme for the DXDocking" };
            ThemeManager.ApplicationTheme = theme;
            InitializeComponent();           
        }

   }         


}
