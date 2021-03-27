using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace DependencyService_Xamarin.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
