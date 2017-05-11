using System.Collections.Generic;

namespace SofiAssignment.Tests.Models
{
    public class Movie
    {
        public bool Adult { get; set; }
        public string Backdrop_Path { get; set; }
        public Collection Belongs_To_Collection { get; set; }
        public int Budget { get; set; }
        public List<Genre> Genres { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string Imdb_Id { get; set; }
        public string Original_Language { get; set; }
        public string Original_Title { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_Path { get; set; }
        public List<ProductionCompany> Production_Companies { get; set; }
        public List<ProductionCountry> Production_Countries { get; set; }
        public string Release_Date { get; set; }
        public double Revenue { get; set; }
        public int Runtime { get; set; }
        public List<Language> Spoken_Languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double Vote_Average { get; set; }
        public int Vote_Count { get; set; }
    }
}