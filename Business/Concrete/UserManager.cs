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
    public class UserManager : IUserService
    {
        public IUserDal dal { get; }
        public UserManager(IUserDal dal)
        {
           this.dal = dal;
        }
       
        public void Add(User user)
        {
            this.dal.Add(user);
        }
        public List<User> GetAll()
        {
            return dal.GetAll();
        }
    }
}
