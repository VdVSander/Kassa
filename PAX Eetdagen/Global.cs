using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAX_Eetdagen
{
    public class Article
    {
        public string naam;
        public string categorie;
        public float prijs;

        public Article(string artName, string artCat, float artPrice)
        {
            naam = artName;
            categorie = artCat;
            prijs = artPrice;
        }
    }
    class Global
    {
        public static string path = "";
        public static List<Article> Artikels = new List<Article>();
        public static string logo_path = "";
        public static string config_path = "";
    }
}
