using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNote
{
    class Program
    {
        static void Main(string[] args)
        {

            NoteManager manager = new NoteManager();

            manager.Add(new Entities.Concrete.Note { Name = "test", Decsription = "makale yaz oğlum", CreateDate = DateTime.Now });

            var lst = manager.GetAll();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
