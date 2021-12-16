using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
}
