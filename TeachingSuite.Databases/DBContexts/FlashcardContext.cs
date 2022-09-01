using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace TeachingSuite.Databases.DBContexts
{
    internal static class Info
    {
        public const string TestConnection =
            "";
    }
    public class FlashcardContext : DbContext
    {
        public FlashcardContext()
        {

        }

        public static List<FlashCard> GetFlashCards(int Qty)
        {
            var FlashCards = new List<FlashCard>();
            var QueryString = "Select top " + Qty
                                + " * from FlashCards order by NEWID()";

            using (var Connection = new SqlConnection(Info.TestConnection))
            {
                Connection.Open();

                using (var Command = new SqlCommand(QueryString, Connection))
                {
                    var Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        var Card = new FlashCard();

                        Card.Id = new Guid(Reader["Id"].ToString());
                        Card.FrontValue = Reader["FrontValue"].ToString();
                        Card.BackValue = Reader["BackValue"].ToString();
                        Card.ImageLocation =
                            Reader.IsDBNull(Reader.GetOrdinal("ImageURL"))
                            ? ""
                            : Reader["ImageURL"].ToString();
                        FlashCards.Add(Card);
                    }
                }

                Connection.Close();
            }

            return FlashCards;

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
