using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Magazine : MediaItem
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, int publicationYear, int issueNumber, Catalog catalog, string? edition = null) : base(title, publicationYear, catalog, edition)
        {
            IssueNumber = issueNumber;
        }
        public override string GetMediaType() => "Magazine";
    }
}
