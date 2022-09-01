using TeachingSuite.Databases.DBContexts;
using TeachingSuite.Databases.Interfaces;

namespace FrontEnd.Models
{
    public class Databases
    {
        public static class FlashCards
        {
            public static List<FlashCard> GetFlashCards(int Quantity)
            {
                return FlashCardInterface.GetFlashCards(Quantity);
            }
           
        }
    }
}
