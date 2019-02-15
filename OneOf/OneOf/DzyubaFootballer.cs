namespace Demo.OneOf
{
    public class DzyubaFootballer : IFootballer
    {
        public string Name => "Артём";
        public string Surname => "Дзюба";
        public NickNameOneOf NickName => NickNameOneOf.NameAndSurname();
    }
}