using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ML_DB.Models
{
    public class Rating
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }


    internal class Movie_Model
    {
        [JsonProperty("Title")]
        public string Title;

        [JsonProperty("Year")]
        public int Year;

        [JsonProperty("Rated")]
        public string Rated;

        [JsonProperty("Release")]
        public string Release;

        [JsonProperty("Genre")]
        public string Genre;

        [JsonProperty("Director")]
        public string Director;

        [JsonProperty("Writer")]
        public string Writer;

        [JsonProperty("Actors")]
        public string Actors;

        [JsonProperty("Plot")]
        public string Plot;

        [JsonProperty("Language")]
        public string Language;

        [JsonProperty("Country")]
        public string Country;

        [JsonProperty("Awards")]
        public string Awards;

        [JsonProperty("Poster")]
        public string Poster;

        [JsonProperty("Ratings")]
        public List<Rating> Ratings { get; set; }

        [JsonProperty("Metascore")]
        public int Metascore;

        [JsonProperty("imdbRating")]
        public double imdbRating;

        [JsonProperty("imdbVotes")]
        public string imdbVotes;

        [JsonProperty("imdbID")]
        public string imdbID;

        [JsonProperty("Type")]
        public string Type;

        [JsonProperty("DVD")]
        public string DVD;

        [JsonProperty("BoxOffice")]
        public string BoxOffice;

    }
}
