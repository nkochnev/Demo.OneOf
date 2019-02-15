using System.Collections.Generic;

namespace Demo.Initial
{
    public class TShirtService
    {
        public IEnumerable<TShirt> GetTShirts(IFootballer[] footballers)
        {
            for (var num = 1; num < footballers.Length; num++)
            {
                var footballer = footballers[num];
                var nickname = footballer.NickName ?? $"{footballer.Name} {footballer.Surname}";
                yield return new TShirt(num, nickname);
            }
        }
    }
}