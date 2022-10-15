using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books {get;set;}

        public override string ToString()
        {
            return Name;
        }
    }
}
