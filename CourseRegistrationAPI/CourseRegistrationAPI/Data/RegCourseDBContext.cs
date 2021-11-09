using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseRegistrationAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseRegistrationAPI.Data
{
    public class RegCourseDBContext: DbContext
    {
        public RegCourseDBContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<User> Users { get; set; }


        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(s => new { s.UserId, s.CourseId });
            builder.HasOne(ss => ss.User)
                .WithMany(s => s.Registrations)
                .HasForeignKey(ss => ss.UserId);
            builder.HasOne(ss => ss.Course)
                .WithMany(s => s.Registrations)
                .HasForeignKey(ss => ss.CourseId);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
            .HasKey(s => new { s.UserId, s.CourseId });

            base.OnModelCreating(modelBuilder);
        }


    }



}
