using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarantAppDemo.Models;
using RestarantAppDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestarantAppDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCollectionCheck : ContentPage
    {
        public ListViewCollectionCheck(List<CollectionModel> list)
        {

            InitializeComponent();
            collectionList.ItemsSource = list;


        }
    }
}