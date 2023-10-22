using Microsoft.EntityFrameworkCore;
using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<FormRecord> FormRecords { get; set; }
        public DbSet<QuestionRecord> QuestionRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
