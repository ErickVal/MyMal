using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyMal.ViewModels
{
    class ChamaXml
    {
        public String respostaString;

        public ChamaXml()
        {
            //ChamaBusca();
        }

        public async Task<XDocument> ChamaBusca(String anime)
        {
            Debug.WriteLine("ChamaBusca Chamado!");

            String username = "Detona";
            String password = "8857761De";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://myanimelist.net/api/anime/search.xml?q="+anime);

            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + encoded;

            XDocument doc;
            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    doc = XDocument.Load(stream);
                }
            }
            //Debug.WriteLine(doc);
            return doc;
            
        }

        /*
        public static async Task<string> GetResponseText(string address)
        {
            using (var httpClient = new HttpClient())
            return await httpClient.GetStringAsync(address);
        }

        public async void ChamaBusca()
        {
            Debug.WriteLine("Chama Busca");

            String username = "Detona";
            String password = "8857761De";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://myanimelist.net/api/anime/search.xml?q=bleach");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + encoded;

                WebResponse resposta = await request.GetResponseAsync();

                using (Stream stream = resposta.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String respostaString = reader.ReadToEnd();
                }

                Debug.WriteLine(respostaString);

        }*/

    }

}
