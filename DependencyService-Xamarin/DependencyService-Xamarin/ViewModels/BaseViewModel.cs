using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DependencyService_Xamarin.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected IPageDialogService AlertService { get; }

        protected BaseViewModel(IPageDialogService pageDialogService)
        {
            AlertService = pageDialogService;
        }
    }
}
