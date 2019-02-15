using System.Collections.Generic;
using JetBrains.Annotations;

namespace Demo.OneOf
{
    [UsedImplicitly]
    public class TShirtService
    {
        [UsedImplicitly]
        public IEnumerable<TShirt> GetTShirts(IFootballer[] footballers)
        {
            for (var num = 1; num < footballers.Length; num++)
            {
                var footballer = footballers[num];
                var nickname = footballer.NickName.Switch(
                    () => $"{footballer.Name} {footballer.Surname}",
                    customNick => customNick);
                yield return new TShirt(num, nickname);
            }
        }
    }
}