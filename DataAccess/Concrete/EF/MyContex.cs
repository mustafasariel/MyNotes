﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class MyContex : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }

        public MyContex() : base("name=MyContext")
        {
            // Database.SetInitializer<MyContex>(new DropCreateDatabaseAlways<MyContex>());

            Database.SetInitializer<MyContex>(new CreateDatabaseIfNotExists<MyContex>());
        }
    }
}
