using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC_Identity.Models.Context
{
    public class ProjectContext:IdentityDbContext
    {

        //aşağıdaki constructor servis tarafında kullanılan AddDbContext<> tarafında kullanılan bağlantı cümlesini (connectionString) Context'e inject edebilmek adına tanımlanmıştır.
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
    }
}
