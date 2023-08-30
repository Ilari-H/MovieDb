using ML_DB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ML_DB.Controllers
{
    internal class Movie_Controller
    {
        internal static async Task<Movie_Model> FetchMovieAsync(string name, string key, string length)
        {
            string url = "https://www.omdbapi.com/?apikey=" + key.ToString() + "&t="+ name + "&plot="+length;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                var jsonString = await response.Content.ReadAsStringAsync();
                try
                {
                    var Movie = JsonConvert.DeserializeObject<Movie_Model>(jsonString);
                    return Movie;
                }
                catch (Exception ex)
                {
                    return null;
                }

                
            }

        }




    }
}
