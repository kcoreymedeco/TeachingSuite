using TeachingSuite.Databases.DBContexts;
using TeachingSuite.Databases.Interfaces;

namespace TeachingSuite.FrontEnd.Models
{
    public class Databases
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
