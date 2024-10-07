using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options) 
        {
            
        }

        public DbSet<PostEntity> Posts => Set<PostEntity>();
        
        public DbSet<UserEntity> Users => Set<UserEntity>();


    }
}
