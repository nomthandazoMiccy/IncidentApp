using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentApp.Models
{
    public class IncidentAppContext : IdentityDbContext<User_Account>
    {
        public IncidentAppContext(DbContextOptions<IncidentAppContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Manager", NormalizedName = "MANAGER", RoleName = "manager", Handle = "manager", RoleIcon = "/uploads/roles/icons/default/role.png", IsActive = true },
                new { Id = "2", Name = "Technician", NormalizedName = "TECHNICIAN", RoleName = "technician", Handle = "technician", RoleIcon = "/uploads/roles/icons/default/role.png", IsActive = true },
                new { Id = "3", Name = "User", NormalizedName = "USER", RoleName = "user", Handle = "user", RoleIcon = "/uploads/roles/icons/default/role.png", IsActive = true }
            );
        }
        public DbSet<User_Account> User_Accounts { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task_Detail> Task_Details { get; set; }
    }

}
