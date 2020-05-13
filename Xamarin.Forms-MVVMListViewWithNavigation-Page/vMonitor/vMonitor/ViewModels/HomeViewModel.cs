using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using vMonitor.Models;
using vMonitor.Services;
using vMonitor.Views;
using Xamarin.Forms;

namespace vMonitor.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        #region LinkCMD
        
        public Command ForgetCommand
        {
            get
            {
                return new Command<string>((Url) =>
                {
                    Device.OpenUri(new System.Uri(Url));
                });
            }
        }
        #endregion

        private List<Model> _model;
        private Command<Object> _tabCommand;
        private INavigation _navigation;

        public List<Model> Model
        {
            get
            {
              return _model;
            }

            set
            {
                _model = value;
                OnPropertyChanged();
            }

        }

        public Command<Object> TabCommand
        {
            get
            {
              return _tabCommand;
            } 
            set => _tabCommand = value;
        }

        public INavigation Navigation
        {
            get
            { 
                return _navigation;
            } 
            set => _navigation = value;
        }

        public HomeViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _tabCommand = new Command<Object>(OnTapped);
        }

        private void OnTapped(object obj)
        {
            var newPage = new TabbedPages();
            newPage.BindingContext = obj;
            Navigation.PushAsync(newPage);
        }

        public HomeViewModel()
        {
                var homeservices = new HomeServices();
                Model = homeservices.GetHomeList();
        }
        

       
        #region  INotify
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
