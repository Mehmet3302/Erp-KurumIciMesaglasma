﻿using Erp___Kurum_Ici_Haberlesme_2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Erp___Kurum_Ici_Haberlesme_2.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Birimler> Birim => Set<Birimler>();
        public DbSet<AltBirimler> AltBirim => Set<AltBirimler>();
        public DbSet<Message> Messages => Set<Message>();
    }
}
