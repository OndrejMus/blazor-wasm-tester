using BlazorWasmTester.Features.SimpleSQLiteTest;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using SqliteWasmHelper;

namespace BlazorWasmTester.Features.SimpleSQLiteTest
{
    public class NotesRepository : INotesRepository
    {
        private readonly NotesDbContext _context;

        public NotesRepository(NotesDbContext context)
        {
            _context = context;
        }

        //public static async Task<NotesRepository> NotesRepositoryAsync()
        //{
        //    ISqliteWasmDbContextFactory<NotesDbContext> Factory;
        //    NotesDbContext context = await Factory.CreateDbContextAsync();

        //    NotesRepository notesRepository = new NotesRepository();
            
        //}
        

        public IEnumerable<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _context.Notes.SingleOrDefault(n => n.Id == id);
        }

        public async void CreateNote(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
        }

        public async void UpdateNote(Note note)
        {
            _context.Entry(note).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void DeleteNote(int id)
        {
            var note = _context.Notes.SingleOrDefault(n => n.Id == id);
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
        }
    }
}
