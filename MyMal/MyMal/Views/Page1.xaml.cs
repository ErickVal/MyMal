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
            this.Title = "PaginaA";
            NavigationPage.SetHasNavigationBar(this, false);
            this.Icon = "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/sign-check-icon.png";
            NavigationPage.SetTitleIcon(this, "http://icons.iconarchive.com/icons/paomedia/small-n-flat/1024/sign-check-icon.png");
                        
            Debug.WriteLine("Page1 Chamada!");
            var obj = new ViewModels.CarregarModel();
            this.BindingContext = obj;
            this.NomeAnime.TextChanged +=  (sender, e) =>
            {
                obj.AnimeBusca = NomeAnime.Text;
            };

            this.Lista.ItemTapped += async (sender, e) =>
            {
                anime = e.Item as Model.Anime;
                await App.Current.MainPage.Navigation.PushAsync(new Views.Detalhes(anime));
            };
            //ChamaXml busca = new ViewModels.ChamaXml();
        }
        
    }
}
