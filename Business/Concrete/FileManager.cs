using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FileManager : IFileService
    {
        IFileDal dal;
        
        public FileManager(IFileDal dal)
        {
            this.dal = dal;
        }
        public void Add(File file)
        {
            dal.Add(file);
        }

        public List<File> GetAll()
        {
           return  dal.GetAll();
        }
    }
}
