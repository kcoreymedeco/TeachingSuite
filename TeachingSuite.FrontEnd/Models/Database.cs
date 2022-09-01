using Microsoft.EntityFrameworkCore;
using TeachingSuite.Databases.DBContexts;
using TeachingSuite.Databases.Interfaces;

namespace TeachingSuite.FrontEnd.Models
{
    public class Database
    {
        public static class FlashCards
        {
            public static List<FlashCard> GetFlashCards(int Quantity)
            {
                return FlashCards.GetFlashCards(Quantity);
            }
        }
    }
}
