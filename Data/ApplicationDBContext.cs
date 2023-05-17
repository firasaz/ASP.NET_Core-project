using Microsoft.EntityFrameworkCore; //this package('extension') allows us to create db from our models
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBContext :DbContext
    {
        //this class is the constructor class
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        // this class takes our Category model which we imported above from CategoryModel.cs
        // then create a table in our database called Category, the 2nd 'Category' highlighted
        // in white probably
        public DbSet<CategoryModel> Category { get; set; }
    }
}
