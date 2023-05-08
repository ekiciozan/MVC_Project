using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete_Somut_
{
    public class Writer
    {
        public int WriterID { get; set; }
        public string WirterName { get; set; }
        public string WirterSurName { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; } 
        public ICollection<Content> Contents { get; set; }  

    }
}
