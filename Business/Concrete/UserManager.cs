using Business.Abstract;
using Business.Validations.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        public IUserDal dal { get; }
        public UserManager(IUserDal dal)
        {
            this.dal = dal;
        }

        public void Add(User user)
        {
            Utilities.ValidationTool.Validate(new UserValidator(), user);
            this.dal.Add(user);

        }
        public List<User> GetAll()
        {
            return dal.GetAll();
        }
        public User GetByID(int id)
        {
            return dal.GetAll(p => p.Id == id).SingleOrDefault();
        }
    }
}
