using CardGame.Enums;
namespace CardGame.Entities
{
    public class GameCards
    {
        public int CardId { get; set; }
        public string Value{ get; set; }
        public string Type{ get; set; }
        public CardStatus Status { get; set; }

    }
}
