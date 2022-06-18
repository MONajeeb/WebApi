using Lab3models;


using Microsoft.EntityFrameworkCore;

namespace Lab3_WebApi.Models
{
    public class MyContext :DbContext
    {

        public MyContext(DbContextOptions option):base(option)
        {

        }

        public virtual DbSet<Product> Products { get; set; }    

        public virtual DbSet<Category> Categories { get; set; }


    }
}
