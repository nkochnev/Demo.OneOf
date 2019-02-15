namespace Demo.OneOf
{
    public class IbragimovichFootballer : IFootballer
    {
        public string Name => "Златан";
        public string Surname => "Ибрагимович";
        public NickNameOneOf NickName => NickNameOneOf.CustomNick("Lion");
    }
}