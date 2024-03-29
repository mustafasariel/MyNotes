﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
  public  class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();
        }
    }
}
