using Microsoft.EntityFrameworkCore;

namespace TeachingSuite.Databases.DBContexts
{
    public class FlashcardContext : DbContext
    {
        public FlashcardContext()
        {

        }
    }

    public class FlashCard
    {
        public Guid Id { get; set; }
        public string FrontValue { get; set; } = "";
        public string BackValue { get; set; } = "";
        public string ImageLocation { get; set; } = "";
    }
}
