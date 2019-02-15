using System.Collections.Generic;
using JetBrains.Annotations;

namespace Demo.Option
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

                var nickname = footballer.NickName.IsSome
                    ? footballer.NickName.Value
                    : $"{footballer.Name} {footballer.Surname}";

                yield return new TShirt(num, nickname);
            }
        }
    }
}