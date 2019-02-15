using JetBrains.Annotations;

namespace Demo.Option
{
    public interface IFootballer
    {
        [NotNull] string Name { get; }

        [NotNull] string Surname { get; }

        [NotNull] Option<string> NickName { get; }
    }
}