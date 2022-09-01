using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingSuite.Databases.DBContexts;

namespace TeachingSuite.Databases.Interfaces
{
    public static class FlashCardInterface
    {
        public static List<FlashCard> GetFlashCards(int Quantity)
        {
            var flashcards = FlashcardContext.GetFlashCards(Quantity);
            return flashcards;
        }


    }
}
