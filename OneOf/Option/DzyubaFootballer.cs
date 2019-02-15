namespace Demo.Option
{
    public class DzyubaFootballer : IFootballer
    {
        public string Name => "Артём";
        public string Surname => "Дзюба";
        public Option<string> NickName => Option<string>.None();
    }
}