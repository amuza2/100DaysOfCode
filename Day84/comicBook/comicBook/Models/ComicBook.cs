using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comicBook.Models
{
    public class ComicBook
    {
        public int Id {  get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNupber { get; set; }
        public int DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

    }
}