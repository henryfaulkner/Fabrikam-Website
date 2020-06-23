using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fabrikam_MVCv2.Models
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string DatePublished { get; set; }
        public string Author { get; set; }
    }
}