namespace Demo.Option
{
    public class IbragimovichFootballer : IFootballer
    {
        public string Name => "Златан";
        public string Surname => "Ибрагимович";
        public Option<string> NickName => Option<string>.Some("Lion");
    }
}