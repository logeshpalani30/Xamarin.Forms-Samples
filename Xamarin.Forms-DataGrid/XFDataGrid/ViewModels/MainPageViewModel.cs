// 16:48
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XFDataGrid.Models;
using XFDataGrid.Utils;

namespace XFDataGrid.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private List<Professional> _professionals;
        private Professional _selectedProfessional;
        private bool _isRefreshing;

        public List<Professional> Professionals
        {
            get
            {
                return _professionals;
            }
            set
            {
                _professionals = value;
                OnPropertyChanged(nameof(Professionals));
            }
        }
        public Professional SelectedProfesstional
        {
            get
            {
                return _selectedProfessional;
            }
            set
            {
                _selectedProfessional = value;
                OnPropertyChanged(nameof(SelectedProfesstional));
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand { get; set; }

        public MainPageViewModel()
        {
            Professionals = DummyProfessionalData.GetProfessionals();
            RefreshCommand = new Command(CmdRefresh);
        }

        private async void CmdRefresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
