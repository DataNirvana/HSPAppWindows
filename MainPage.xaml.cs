//using HSP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace HSPApp.UWP {
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    public sealed partial class MainPage {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public MainPage() {
            this.InitializeComponent();


            // Set the Resource path appropriately
            //if ( AudioDeviceType.)
            if (Device.OS == TargetPlatform.Windows) {
                AppHelper.AssetPath = "ms-appx-web:///Assets/";
            } else if (Device.OS == TargetPlatform.WinPhone) {
                AppHelper.AssetPath = "";
            }

            LoadApplication(new HSPApp.App());
        }
    }
}
