using DataAccess.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Business.Abstract;

namespace Business.Concrete
{
    public class NoteManager:INoteService
    {
        INoteDal noteDal;
        public NoteManager(INoteDal noteDal)
        {
            this.noteDal = noteDal;
        }
        public List<Note> GetAll()
        {
            return noteDal.GetAll();
        }
        public void Add(Note note)
        {
            noteDal.Add(note);
        }
    }
}
