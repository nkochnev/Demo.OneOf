namespace Demo
{
    public class TShirt
    {
        public TShirt(int number, string nickname)
        {
            Number = number;
            Nickname = nickname;
        }

        public int Number { get; }
        public string Nickname { get; }
    }
}