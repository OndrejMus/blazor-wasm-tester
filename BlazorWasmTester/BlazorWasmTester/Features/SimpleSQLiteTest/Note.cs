using System.Diagnostics.CodeAnalysis;

namespace BlazorWasmTester.Features.SimpleSQLiteTest
{
    public class Note
    {
        public int Id { get; set; }
        [AllowNull]
        public string? Title { get; set; }
        [AllowNull]
        public string? Content { get; set; }
        [AllowNull]
        public string? Creator { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
