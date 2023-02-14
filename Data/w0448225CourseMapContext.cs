using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Data
{
    public class w0448225CourseMapContext : DbContext
    {
        public w0448225CourseMapContext (DbContextOptions<w0448225CourseMapContext> options)
            : base(options)
        {
        }

        public DbSet<w0448225CourseMap.Models.Diploma> Diplomas { get; set; } = default!;

        public DbSet<w0448225CourseMap.Models.DiplomaYear> DiplomaYears { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.Instructor> Instructors { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.AdvisingAssignment> AdvisingAssignments { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.DiplomaYearSection> DiplomaYearSections { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.Course> Courses { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.CoursePrerequisite> CoursePrerequisites { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.AcademicYear> AcademicYears { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.Semester> Semesters { get; set; } = default!;
        public DbSet<w0448225CourseMap.Models.CourseOffering> CourseOfferings { get; set; } = default!;

        // CUSTOM CONFIGURATION WITH FLUENT API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // RECONCILE THE MANY TO MANY RECURSIVE (VERSION 1)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Prerequisites)
                .WithOne(cpr => cpr.Course)
                .HasForeignKey(cpr => cpr.CourseId);
            modelBuilder.Entity<Course>()
                .HasMany(c => c.IsPrerequisiteFor)
                .WithOne(cpr => cpr.Prerequisite)
                .HasForeignKey(cpr => cpr.PrerequisiteId);
            modelBuilder.Entity<Semester>()
                .ToTable( d => d.HasCheckConstraint("CK_Check_End_date", "[EndDate] > [StartDate]"));

            // // RECONCILE THE MANY TO MANY RECURSIVE (VERSION 2)
            // modelBuilder.Entity<Course>()
            // .HasMany(c => c.Prerequisites)
            // .WithMany(c => c.IsPrerequisiteFor);
        
            // TURN OFF CASCADE DELETE FOR ALL RELATIONSHIPS
            foreach(var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach(var fk in entity.GetForeignKeys()){
                    fk.DeleteBehavior = DeleteBehavior.NoAction;
                }
            }
        }
    }
}
