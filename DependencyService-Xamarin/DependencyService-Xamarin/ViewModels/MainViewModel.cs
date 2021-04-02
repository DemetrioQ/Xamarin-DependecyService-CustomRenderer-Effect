using DependencyService_Xamarin.Services;
using Prism.Commands;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms.Internals;

namespace DependencyService_Xamarin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        IDeviceOrientationService DeviceOrientationService;
        public ICommand GetCommand { get; }
        public string Orientation { get; set; }

        public MainViewModel(IDeviceOrientationService deviceOrientationService, IPageDialogService pageDialogService) : base(pageDialogService)
        {
            DeviceOrientationService = deviceOrientationService;
            GetCommand = new DelegateCommand(OnGet);
        }
        public void OnGet()
        {
            DeviceOrientation deviceOrientation = DeviceOrientationService.GetOrientation();
            Orientation = deviceOrientation.ToString();
        }



    }
}
