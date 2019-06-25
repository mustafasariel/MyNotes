using Business.Abstract;
using Business.Utilities;
using Business.Validations.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal dal;
       
 

        public CategoryManager(ICategoryDal dal)
        {
            this.dal = dal;
        }

        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            dal.Add(category);

        }

        public List<Category> GetAll()
        {
            return dal.GetAll();
        }
    }
}