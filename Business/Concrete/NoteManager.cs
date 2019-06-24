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
        public List<Note> GetByCategoryId(int categoryId)
        {
            return noteDal.GetAll(p => p.Category.Id == categoryId);
        }
        public List<Note> GetByUserId(int userId)
        {
            return noteDal.GetAll(p => p.User.Id == userId);
        }
        public void Add(Note note)
        {
            noteDal.Add(note);
        }
    }
}
