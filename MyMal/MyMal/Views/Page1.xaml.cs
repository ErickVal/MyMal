using MyMal.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyMal.Views
{
    public partial class Page1 : ContentPage
    {
        public string URL = "http://jsonplaceholder.typicode.com/users";
        public Model.Anime anime;

        public Page1()
        {
            InitializeComponent();
            Debug.WriteLine("Page1 Chamada!");
            this.BindingContext = new ViewModels.CarregarModel();
            this.Lista.ItemTapped += async (sender, e) =>
            {
                anime = e.Item as Model.Anime;
                await App.Current.MainPage.Navigation.PushAsync(new Views.Detalhes(anime));
            };
            //ChamaXml busca = new ViewModels.ChamaXml();
        }
        
    }
}
