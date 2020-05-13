using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using RestarantAppDemo.Models;
using Xamarin.Forms;

namespace RestarantAppDemo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private List<ImageModel> _image;

        private int _position;
        public ICommand Image_click { get; }
        public List<ImageModel> ImageModel
        {
            get { return _image; }
            set { _image = value; }
        }

        public int PositionImage
        {
            get { return _position; }
            set { _position = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageViewModel()
        {
            _position = 0;
            _image = new ImageModel().GetImage();
            Image_click = new Command(ImageClick);
        }

        private void ImageClick(object image)
        {
            var path = (image as Image).Source.ToString().Split(':')[1].Trim();
            _image.IndexOf(_image.Find(x => x.ImageSource == image));
        }
    }
}
