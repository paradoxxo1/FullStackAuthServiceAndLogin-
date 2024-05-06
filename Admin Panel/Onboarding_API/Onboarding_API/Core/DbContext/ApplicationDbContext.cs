﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onboarding_API.Core.Entities.AuthEntities;
using Onboarding_API.Core.Entities.FormEntities;
using System.Reflection.Emit;

namespace Onboarding_API.Core.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OnBoardForm> onboarding_POC { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Config anything we want
            //1

            builder.Entity<ApplicationUser>(e =>
            {
                e.ToTable("Users");
            });

            //2
            builder.Entity<IdentityUserClaim<string>>(e =>
            {
                e.ToTable("UserClaims");
            });

            //3
            builder.Entity<IdentityUserLogin<string>>(e =>
            {
                e.ToTable("UserLogins");
            });

            //4
            builder.Entity<IdentityUserToken<string>>(e =>
            {
                e.ToTable("UserTokens");
            });

            //5
            builder.Entity<IdentityRole>(e =>
            {
                e.ToTable("Roles");
            });

            //6
            builder.Entity<IdentityRoleClaim<string>>(e =>
            {
                e.ToTable("RoleClaims");
            });

            //7
            builder.Entity<IdentityUserRole<string>>(e =>
            {
                e.ToTable("UserRoles");
            });

            // Need Dbset Database Table
            builder.Entity<OnBoardForm>(e =>
            {
                e.ToTable("onboarding_POC");
                e.HasKey(o => o.Id);
            });

        }




    }
}
