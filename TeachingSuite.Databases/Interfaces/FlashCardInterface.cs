using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingSuite.Databases.Interfaces
{
    public static class FlashCardInterface
    {
        public static List<DBContexts.FlashCard> GetFlashCards(int Quantity)
        {
            var flashcards = new List<DBContexts.FlashCard>();
            flashcards.Add(new DBContexts.FlashCard() { Id = new Guid(), FrontValue = "Hello", BackValue = "Goodbye" });
            return flashcards;
        }


    }
}
