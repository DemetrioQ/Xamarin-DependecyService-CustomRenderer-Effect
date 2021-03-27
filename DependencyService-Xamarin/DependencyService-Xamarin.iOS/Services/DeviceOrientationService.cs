using DependencyService_Xamarin.Services;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms.Internals;

namespace DependencyService_Xamarin.iOS.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}