﻿using EmailDeliverySystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailDeliverySystem.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<EmailRequest> EmailRequests { get; set; }
    }

}
