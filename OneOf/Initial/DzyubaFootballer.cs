namespace Demo.Initial
{
    public class DzyubaFootballer : IFootballer
    {
        public string Name => "Артём";
        public string Surname => "Дзюба";
        public string NickName { get; }
    }
}