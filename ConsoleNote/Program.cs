using Business.Concrete;
using DataAccess.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace ConsoleNote
{
    class Program
    {
        static INoteService note;
        static ICategoryService cat;
        static IUserService user;
        static IFileService file;
        static void Main(string[] args)
        {
            files();
            users();
            notes();
            category();
        }

        private static void files()
        {
            file = new FileManager(new EfFileDal());
            file.Add(new File { Path = "c:\\abc.txt" });
            var lst = file.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item.Path);
            }
        }

        static void notes()
        {
            note = new NoteManager(new EfNoteDal());
            note.Add(new Note { Name = "test", Decsription = "makale yaz oğlum", CreateDate = DateTime.Now });

            var lst = note.GetAll();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void category()
        {
            cat = new CategoryManager(new EfCategoryDal());
            cat.Add(new Category { Name = "Programlama" });

            var lst = cat.GetAll();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void users()
        {
            user = new UserManager(new EfUserDal());
            user.Add(new User { FullName = "mustafa sarıel", Password = "12345", UserName = "msariel2" });

            var lst = user.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
