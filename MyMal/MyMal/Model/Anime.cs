using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMal.Model
{
    public class Anime : INotifyPropertyChanged
    {

        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        /// <summary>
        ///  NOME DO ANIME
        /// </summary>

        private string name;

        public string Name
        {

            get
            {
                return name;
            }
            set
            {
                name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }

        }

        /// <summary>
        /// NOME DO ANIME EM INGLES
        /// </summary>
        /// 

        private string english;

        public string English
        {

            get
            {
                return english;
            }
            set
            {
                english = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(English)));
            }

        }

        /// <summary>
        /// IMAGEM
        /// </summary>

        private string imagem;

        public string Imagem
        {

            get
            {
                return imagem;
            }
            set
            {
                imagem = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Imagem)));
            }

        }

        /// <summary>
        /// Sinopse
        /// </summary>

        private string sinopse;

        public string Sinopse
        {

            get
            {
                return sinopse;
            }
            set
            {
                sinopse = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sinopse)));
            }

        }
        /// <summary>
        /// Episodios
        /// </summary>

        private string episodios;

        public string Episodios
        {

            get
            {
                return episodios;
            }
            set
            {
                episodios = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Episodios)));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
