using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingSuite.Databases.Interfaces
{
    internal class FlashCardInterface
    {
        public List<DBContexts.FlashCard> GetFlashCards(int Quantity)
        {
            var flashcards = new List<DBContexts.FlashCard>();

            return flashcards;
        }


    }
}
