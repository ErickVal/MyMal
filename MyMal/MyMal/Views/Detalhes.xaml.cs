using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyMal.Views
{
    public partial class Detalhes : ContentPage
    {
        public Detalhes(Model.Anime anime)
        {
            InitializeComponent();

        
            NavigationPage.SetTitleIcon(this, "icont.png");


            this.Title = anime.Name;           

            this.Titulo.Text = anime.Name;
            this.Imagem.Source = anime.Imagem;


            //FORMATA O HTML USANDO HTMLAGILITYPACK PARA SINOPSE
            //HtmlDocument htmlDoc = new HtmlDocument();
            //htmlDoc.LoadHtml(anime.Sinopse);

            //this.Sinopse.Text = htmlDoc.DocumentNode.InnerHtml;
            this.Sinopse.Text = ViewModels.HtmlRemoval.StripTagsCharArray(WebUtility.HtmlDecode(anime.Sinopse));
            
            
            //this.Sinopse.Text = anime.Sinopse;
        }
    }
}
