using System.Collections.Generic;

namespace IMDB
{
    public class ImdbMovieSearchResult
    {
        public List<ImdbMovieSearchResultItem> Search = new List<ImdbMovieSearchResultItem>();
        public int TotalResults;

        public bool Response;
        public string Error;
    }
}
