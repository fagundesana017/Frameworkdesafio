using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FrameworkDesafio
{
   public class Albuns
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }

        public static List<Albuns> ListarAlbum()
        {
            string url = "https://jsonplaceholder.typicode.com/albums";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var album = JsonConvert.DeserializeObject<List<Albuns>>(json);
            return album;
        }
    }
}
