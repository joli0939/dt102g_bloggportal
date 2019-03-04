using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bloggportal.Models
{
    public class PostDetail
    {
        public PostDetail() { }

        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
    }
}
