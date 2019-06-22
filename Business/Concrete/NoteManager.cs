using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NoteManager
    {
        NoteDal noteDal = new NoteDal();
        public List<Note> GetAll()
        {
            return noteDal.GetAllNotes();
        }
        public void Add(Note note)
        {
            noteDal.Add(note);
        }
    }
}
