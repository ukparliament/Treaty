namespace UKParliament
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    public class QueryParameters
    {
        [FromQuery(Name = "q")]
        public string SearchTerms { get; set; }

        [FromQuery(Name = "start")]
        public int StartIndex { get; set; } = 1;

        [FromQuery(Name = "count")]
        public int Count { get; set; } = 10;

        public string Format { get; set; }

        public static string ParseSearchTerms(string searchTerms, string facetPrefix)
        {
            return string.Join(" ", searchTerms.Split().Select(term => string.Format("{0}{1}", facetPrefix, term)));
        }
    }
}
