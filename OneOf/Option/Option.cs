using System;

namespace Demo.Option
{
    public class Option<T> where T : class
    {
        private readonly T value;

        private Option(T some) => value = some;

        public T Value => IsSome ? value : throw new MemberAccessException();

        public bool IsSome => value != null;
        public bool IsNone => !IsSome;

        public static Option<T> Some(T value)
        {
            return new Option<T>(value);
        }

        public static Option<T> None()
        {
            return new Option<T>(null);
        }
    }
}