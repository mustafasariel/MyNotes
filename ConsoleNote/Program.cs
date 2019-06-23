using Business.Concrete;
using DataAccess.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;

namespace ConsoleNote
{
    class Program
    {
       static INoteService note;
        static ICategoryService cat;
        static void Main(string[] args)
        {

            //note = new NoteManager(new EfNoteDal());
            //note.Add(new Entities.Concrete.Note { Name = "test", Decsription = "makale yaz oğlum", CreateDate = DateTime.Now });

            //var lst = note.GetAll();

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.Name);
            //}


            cat = new CategoryManager(new EfCategoryDal());
            cat.Add(new Entities.Concrete.Category { Name = "Programlama" });

            var lst = cat.GetAll();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
