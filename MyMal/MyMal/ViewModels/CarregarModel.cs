using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace MyMal.ViewModels
{
    class CarregarModel
    {

        public ICommand CarregarCommand { get; set; }

        public ObservableCollection<Model.Anime> Carregar { get; set; }

        public XDocument doc;
        public ChamaXml busca;
        public String AnimeBusca;

        public async void chamador(String anime)
        {

            busca = new ViewModels.ChamaXml();
            try
            {
                doc = await busca.ChamaBusca(anime);
                
                Debug.WriteLine(doc);

                foreach (XElement element in doc.Descendants("entry"))
                {
                    Debug.WriteLine(element);
                    Carregar.Add(new Model.Anime
                    {
                        Id = int.Parse(element.Element("id").Value),
                        Name = element.Element("title").Value,
                        English = element.Element("english").Value,
                        Imagem = element.Element("image").Value,
                        Sinopse = element.Element("synopsis").Value,
                        Episodios = element.Element("episodes").Value
                    });
                }

            } //FIM DO TRY
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }


        }

        public CarregarModel()
        {
            Debug.WriteLine("CaregarModel Chamado!");

            chamador("");

            Carregar = new ObservableCollection<Model.Anime>();
           // Carregar.Add(new Model.Anime { Id = 1, Name = "Primeiro elemento" });

            
            CarregarCommand = new Xamarin.Forms.Command(() =>
            {
                Carregar.Clear();
                
                chamador(AnimeBusca);
                //Carregar.Add(new Model.Anime { Id = 1, Name = "Aeroooooo" });
                
            });
        }

    }

}
