using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestarantAppDemo.Models
{
    public class CollectionModel : INotifyPropertyChanged
    {
        private string _imageSource;

        public string ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }


        private string _tickSource;

        public string TickSource
        {
            get { return _tickSource; }
            set
            {
                _tickSource = value;
                OnPropertyChanged("TickSource");
            }
        }



        public ObservableCollection<CollectionModel> GetImageSelection()
        {
            return new ObservableCollection<CollectionModel>() 
            {
                new CollectionModel() {_imageSource = "MoonriseHome.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "Drawhotelpng.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "MoonriseHome.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "Drawhotelpng.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "MoonriseHome.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "Drawhotelpng.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "MoonriseHome.png", _tickSource = ""},
                new CollectionModel() {_imageSource = "Drawhotelpng.png", _tickSource = ""},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
