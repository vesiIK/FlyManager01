using FlyManager01.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FlyManager01.Data
{
    public class FlyManagerData : IdentityDbContext<AccountsUser>
    {
        private static FlyManagerData instance;

        public FlyManagerData(DbContextOptions<FlyManagerData> options)
           : base(options)
        {
        }
        public FlyManagerData()
        {

        }
        //public virtual DbSet<FlyManagerDatabase.Models.Book> Book { get; set; } = default!;
        //public virtual DbSet<FlyManager01.Models.AccountsUser> Account { get; set; } = default!;
        public virtual DbSet<FlyManager01.Models.Flights> Flights { get; set; } = default!;
        //public virtual DbSet<FlyManager01.Models.Person> Person { get; set; } = default!;
        //public virtual DbSet<FlyManager01.Models.Reservations> Reservations { get; set; } = default!;
        //public virtual DbSet<FlyManager01.Models.Works> Works { get; set; } = default!;
    }
}
