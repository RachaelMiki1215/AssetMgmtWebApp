using System;
using System.Collections.Generic;

namespace AssetMgmtWebApp3.Models
{
    public partial class NewsArticle
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AuthorUserId { get; set; }
        public string HeadLine { get; set; } = null!;
        public string ContentHtml { get; set; } = null!;

        public virtual User AuthorUser { get; set; } = null!;
    }
}
