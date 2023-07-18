using Microsoft.EntityFrameworkCore;

namespace BlazorWasmTester.Features.SimpleSQLiteTest
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
        : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
