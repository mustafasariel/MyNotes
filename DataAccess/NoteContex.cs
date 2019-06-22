using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class NoteContex:DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NoteContex():base("name=NoteContext")
        {

        }
    }
}
