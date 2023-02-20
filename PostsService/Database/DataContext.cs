using System;
using Microsoft.EntityFrameworkCore;
using PostsService.Domain;

namespace PostsService.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PostEntity> Posts { get; set; }

    }
}

