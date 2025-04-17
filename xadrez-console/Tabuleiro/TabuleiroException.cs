using System;

namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
