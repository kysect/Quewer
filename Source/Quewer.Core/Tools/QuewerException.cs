using System;

namespace Quewer.Core.Tools
{
    public class QuewerException : Exception
    {
        public QuewerException(string message) : base(message)
        {
        }
    }
}