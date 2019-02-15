using System;
using JetBrains.Annotations;

namespace Demo.OneOf
{
    public class NickNameOneOf
    {
        private readonly string _nickName;

        private NickNameOneOf(string nickName)
        {
            _nickName = nickName;
        }

        public static NickNameOneOf NameAndSurname()
        {
            return new NickNameOneOf(null);
        }

        public static NickNameOneOf CustomNick([NotNull] string nickname)
        {
            if (string.IsNullOrEmpty(nickname))
                throw new ArgumentException("Value cannot be null or empty.", nameof(nickname));
            return new NickNameOneOf(nickname);
        }

        public string Switch(Func<string> ifUseNameAndSurname, Func<string, string> ifUseCustomNick)
        {
            return _nickName != null ? ifUseCustomNick(_nickName) : ifUseNameAndSurname();
        }
    }
}