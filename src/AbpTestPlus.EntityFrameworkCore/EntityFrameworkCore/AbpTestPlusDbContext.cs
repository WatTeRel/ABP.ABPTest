using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpTestPlus.Authorization.Roles;
using AbpTestPlus.Authorization.Users;
using AbpTestPlus.MultiTenancy;

namespace AbpTestPlus.EntityFrameworkCore
{
    public class AbpTestPlusDbContext : AbpZeroDbContext<Tenant, Role, User, AbpTestPlusDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpTestPlusDbContext(DbContextOptions<AbpTestPlusDbContext> options)
            : base(options)
        {
        }
    }
}
