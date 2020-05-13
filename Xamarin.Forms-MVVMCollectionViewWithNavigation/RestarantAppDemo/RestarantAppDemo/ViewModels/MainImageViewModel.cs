using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RestarantAppDemo.Models;
using Xamarin.Forms;

namespace RestarantAppDemo.ViewModels
{
    public class MainImageViewModel : INotifyPropertyChanged
    {
        public List<CollectionModel> list { get; set; }

        private ObservableCollection<CollectionModel> _listCollections;
        public ObservableCollection<CollectionModel> ListCollections
        {
            get
            {
                return _listCollections;
            }
            set
            {
                _listCollections = value;
            }
        }
        private ObservableCollection<CollectionModel> _imageFood;

        public ObservableCollection<CollectionModel> ImageFood
        {
            get
            {
                return _imageFood;
            }
            set
            {
                _imageFood = value;
            }
        }

        public ICommand ClickCommand { get; }
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


        public MainImageViewModel()
        {
            _imageFood = new CollectionModel().GetImageSelection();
            _listCollections = new ObservableCollection<CollectionModel>();
            list = new List<CollectionModel>();
            ClickCommand = new Command(ChangeTickIcon);
            _position = 0;
            _image = new ImageModel().GetImage();
            Image_click = new Command(ImageClick);
        }
        private void ImageClick(object image)
        {
            var path = (image as Image).Source.ToString().Split(':')[1].Trim();
            _image.IndexOf(_image.Find(x => x.ImageSource == image));
        }
        private void ChangeTickIcon(object obj)
        {
            var selectItem = (CollectionModel)((Image)obj).BindingContext;
            var positionOf = _imageFood.IndexOf(selectItem);
            var imageSource = _imageFood[positionOf].TickSource;
            //ImageFood[positionOf].TickSource = "itemcheckedicon.png";
            if (string.IsNullOrEmpty(imageSource))
            {
                _imageFood[positionOf].TickSource = "itemcheckedicon.png";
                list.Add(selectItem);
                _listCollections.Add(selectItem);
            }
            else if (imageSource == "itemcheckedicon.png")
            {
                _imageFood[positionOf].TickSource = null;
                 list.Remove(selectItem);
                _listCollections.Remove(selectItem);
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
