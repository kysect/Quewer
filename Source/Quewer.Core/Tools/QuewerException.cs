using System;

namespace Quewer.Core.Tools
{
    public class QuewerException : Exception
    {
        public QuewerException(string message) : base(message)
        {
        }

        public static QuewerException IsNotQueamMember() => new QuewerException("Quser is not queam member");
        public static QuewerException MemberAlreadyInQue() => new QuewerException("Member already in que");
    }
}