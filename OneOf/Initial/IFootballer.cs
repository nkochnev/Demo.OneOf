using JetBrains.Annotations;

namespace Demo.Initial
{
    public interface IFootballer
    {
        [NotNull] string Name { get; }

        [NotNull] string Surname { get; }

        [CanBeNull] string NickName { get; }
    }
}