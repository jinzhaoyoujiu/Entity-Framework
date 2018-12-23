using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookContext:System.Data.Entity.DbContext
    {
        public BookContext() :base("BookEntityDataBase")
        { }
        public DbSet<Books> Books { get; set; }
    }
}