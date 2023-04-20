using System.ComponentModel;

namespace CardGame.Enums
{
    public enum CardStatus
    {
        [Description("Face para baixo")]
        FaceDown = 1,
        [Description("Face para cima")]
        FaceUp = 2,
        [Description("Na mão do jogador")]
        Hand = 3
    }
}
