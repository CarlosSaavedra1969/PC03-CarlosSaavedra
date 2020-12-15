using Microsoft.EntityFrameworkCore;
using PC03_CarlosSaavedra.Models;





namespace PC03_CarlosSaavedra.Models
{
   public class WebAppContext: DbContext
   {
       public DbSet<Productos> Productos {get;set; }
       public WebAppContext(DbContextOptions dco) : base(dco) {

       }
   }


}