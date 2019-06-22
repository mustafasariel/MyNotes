using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class NoteDal
    {
        public List<Note> GetAllNotes()
        {
            using (NoteContex contex=new NoteContex() )
            {
                return contex.Notes.ToList();
            }
        }
        public Note GetNote(int id)
        {
            using (NoteContex contex = new NoteContex())
            {
                return contex.Notes.SingleOrDefault(p => p.Id == id);
            }
        }

        public void Add(Note note)
        {
            using (NoteContex contex = new NoteContex())
            {
                contex.Notes.Add(note);
                contex.SaveChanges();
            }
        }

        public void Update(Note note)
        {
            using (NoteContex contex = new NoteContex())
            {
              var mynote= contex.Notes.SingleOrDefault(p => p.Id == note.Id);
                contex.SaveChanges();
            }
        }

        public void Delete(Note note)
        {
            using (NoteContex contex = new NoteContex())
            {
                var mynote = contex.Notes.SingleOrDefault(p => p.Id == note.Id);
                contex.SaveChanges();
            }
        }
    }
}