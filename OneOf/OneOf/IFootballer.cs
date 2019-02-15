using JetBrains.Annotations;

namespace Demo.OneOf
{
    public interface IFootballer
    {
        [NotNull] string Name { get; }

        [NotNull] string Surname { get; }

        [NotNull] NickNameOneOf NickName { get; }
    }
}