using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6.Bibl
{
    internal abstract class Items:Ipubs 
    {
        private string Author { get; set; }
        private string Title { get; set; }
        private string PublishHouse { get; set; }
        private int Page { get; set; }
        private int Year { get; set; }
        private int InvNumber { get; set; }
        private bool Existence { get; set; } //Наличие 
    }
}
