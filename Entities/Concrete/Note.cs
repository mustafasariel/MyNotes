using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decsription { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
