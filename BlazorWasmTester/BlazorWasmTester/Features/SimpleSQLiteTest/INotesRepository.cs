

namespace BlazorWasmTester.Features.SimpleSQLiteTest
{
    public interface INotesRepository
    {
        IEnumerable<Note> GetNotes();
        Note GetNoteById(int id);
        void CreateNote(Note note);
        void UpdateNote(Note note);
        void DeleteNote(int id);
    }
}
