using System;
using System.Collections.Generic;
using System.Linq;
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

            this.Titulo.Text = anime.Name;
        }
    }
}
