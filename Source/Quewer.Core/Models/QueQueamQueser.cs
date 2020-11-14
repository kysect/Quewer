using System;

namespace Quewer.Core.Models
{
    public class QueQueamQueser
    {
        public Que Que { get; private set; }
        public QueamQueser QueamQueser { get; private set; }

        public DateTime PushTime { get; private set; }

        public String Comment { get; private set; }

        private QueQueamQueser(Que que, QueamQueser queamQueser, String comment)
        {
            Que = que;
            QueamQueser = queamQueser;
            Comment = comment;
            PushTime = DateTime.UtcNow;
        }

        public static QueQueamQueser Create(Que que, QueamQueser queamQueser, String comment)
        {
            return new QueQueamQueser(que, queamQueser, comment);
        }
    }
}