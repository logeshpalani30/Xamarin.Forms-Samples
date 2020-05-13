using System;
using System.Collections.Generic;
using System.Text;

namespace RestarantAppDemo.Models
{
    public class ImageModel
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }

        public List<ImageModel> GetImage()
        {
            return new List<ImageModel>()
            {
                new ImageModel() {Name = "Briyani Hotel No 1 ", ImageSource = "MoonriseHome.png"},
                new ImageModel() {Name = "Veg Hotel", ImageSource = "Drawhotelpng.png"},
                new ImageModel() {Name = "New Hotel No 1 ", ImageSource = "MoonriseHome.png"},
                new ImageModel() {Name = "RR Briyani", ImageSource = "Drawhotelpng.png"},
                new ImageModel() {Name = "Briyani Hotel No 2", ImageSource = "MoonriseHome.png"},
                new ImageModel() {Name = "Veg Hotel", ImageSource = "Drawhotelpng.png"},
                new ImageModel() {Name = "Briyani Hotel No 3  ", ImageSource = "MoonriseHome.png"},
                new ImageModel() {Name = "Veg Hotel", ImageSource = "Drawhotelpng.png"},
                new ImageModel() {Name = "Briyani Hotel No 5 ", ImageSource = "MoonriseHome.png"},
                new ImageModel() {Name = "Veg Hotel", ImageSource = "Drawhotelpng.png"},
            };
        }


    }
}

